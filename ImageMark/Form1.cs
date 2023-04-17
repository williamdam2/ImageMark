using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ImageMark
{
    public partial class Form1 : Form
    {
        public struct TextStyleType
        {
            public Color textColor { get; set; }
            public bool topOrBottom { get; set; }
            public bool rightOrLeft { get; set; }
            public bool isInsertFileName { get; set; }
            public string extraText { get; set; }
        }

        List<string> applyFiles = new List<string>();
        TextStyleType textStyle = new TextStyleType();
        public Form1()
        {
            InitializeComponent();
            Form1.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radioTop.CheckedChanged += new System.EventHandler(this.updateTextStyle);
            this.radioIsInserFileName.CheckedChanged += new System.EventHandler(this.updateTextStyle);
            this.radioRight.CheckedChanged += new System.EventHandler(this.updateTextStyle);
            this.btColorPicker.BackColorChanged += new System.EventHandler(this.updateTextStyle);
            this.tbExtraText.TextChanged += new System.EventHandler(this.updateTextStyle);

            updateTextStyle(sender,null);
            try
            {
                this.Icon = Properties.Resources.logo;
            }
            catch
            { }
        }

        void updateTextStyle(object sender, EventArgs e)
        {
            textStyle.textColor = btColorPicker.BackColor;
            textStyle.isInsertFileName = radioIsInserFileName.Checked;
            textStyle.rightOrLeft = radioRight.Checked;
            textStyle.topOrBottom = radioTop.Checked;
            textStyle.extraText = tbExtraText.Text;
        }

        private void btSelectFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderDialog = new CommonOpenFileDialog();
            folderDialog.IsFolderPicker = true;
            folderDialog.InitialDirectory = Application.StartupPath;
            if(folderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                List<string> listFiles = searchImageAll(folderDialog.FileName);
                applyFiles.Clear();
                applyFiles.AddRange(listFiles);
                rtbListFiles.Text = "";
                if(applyFiles.Count > 0)
                {
                    progressBarInsert.Value = 0;
                    lbPercent.Text = "0%";
                }
                for(int i = 0; i < listFiles.Count; i ++)
                {
                    rtbListFiles.Text += i.ToString() + ". " + listFiles[i] + System.Environment.NewLine;
                }
            }
        }

        List<string> searchImageCurrent(string folderPath)
        {
            List<string> listFiles = new List<string>();
            string[] temp = Directory.GetFiles(folderPath);
            foreach (string filePath in temp)
            {
                string extension = Path.GetExtension(filePath).ToLower();
                if (String.Equals(extension, ".jpg", StringComparison.OrdinalIgnoreCase) ||
                    String.Equals(extension, ".jpeg", StringComparison.OrdinalIgnoreCase) ||
                    String.Equals(extension, ".png", StringComparison.OrdinalIgnoreCase))
                {
                    listFiles.Add(filePath);
                }
            }
            return listFiles;
        }

        List<string> searchSubFolder(string folderPath)
        {
            List<string> subfolders = new List<string>();
            try
            {
                // Get an array of subfolder names
                string[] subfolderNames = Directory.GetDirectories(folderPath);

                // Loop through the subfolder names and add them to the list
                foreach (string subfolderName in subfolderNames)
                {
                    subfolders.Add(subfolderName);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                Console.WriteLine(ex.Message);
            }

            // Return the list of subfolders
            return subfolders;
        }

        List<string> searchImageAll(string folderPath)
        {
            List<string> listFiles = new List<string>();
            List<string> current = searchImageCurrent(folderPath);
            listFiles.AddRange(current);
            List<string> listSubFolders = searchSubFolder(folderPath);
            if(listSubFolders.Count > 0)
            {
                foreach (string subFolder in listSubFolders)
                {
                    listFiles.AddRange(searchImageAll(subFolder));
                }
            }
            return listFiles;
        }

        private void btPreview_Click(object sender, EventArgs e)
        {
             // this pointer only for memory leak solve
            if(applyFiles.Count > 0)
            {
                try
                {
                    Image temp;
                    if(picBoxPreview.Image != null)
                    {
                        temp = picBoxPreview.Image;
                        picBoxPreview.Image = null;
                        temp.Dispose();
                    }

                    Image previewImage = Image.FromFile(applyFiles[0]);
                    string insertText = textStyle.extraText;
                    if (textStyle.isInsertFileName)
                    {
                        insertText += "_" + Path.GetFileNameWithoutExtension(applyFiles[0]); ;
                    }

                    temp = new Bitmap(addText2Image(previewImage, insertText, textStyle));
                    previewImage.Dispose();

                    picBoxPreview.Image = temp;

                }
                catch
                {
                    MessageBox.Show("Không thể Preview ảnh");
                }
            }
        }

        private void btColorPicker_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btColorPicker.BackColor = colorDialog1.Color;
            }    
        }

        Image addText2Image(Image image, string text,TextStyleType style)
        {
            // Create a graphics object from the image
            Graphics graphics = Graphics.FromImage(image);

            // Create a font object with the desired font family and a large size
            Font font = new Font("Arial", 20);

            // Measure the size of the text using the large font
            SizeF textSize = graphics.MeasureString(text, font);

            // Calculate the maximum font size that will fit the text in the available space
            int maxFontSize = (int)((image.Height * 0.1f / textSize.Height) * font.Size);

            // Create a new font object with the maximum font size
            Font newFont = new Font("Arial", maxFontSize);

            // Create a string format object with right alignment
            StringFormat format = new StringFormat();
            if(textStyle.rightOrLeft)
            {
                format.Alignment = StringAlignment.Far;
            }
            else
            {
                format.Alignment = StringAlignment.Near;
            }
            
            format.LineAlignment = StringAlignment.Near;

            // Loop until the entire text fits within the available width
            while (true)
            {
                // Measure the size of the text using the new font
                textSize = graphics.MeasureString(text, newFont);

                // If the text fits within the available width, break out of the loop
                if (textSize.Width <= image.Width * 0.7f)
                {
                    break;
                }

                // If the text is too long, reduce the font size by 1 point and try again
                newFont = new Font("Arial", newFont.Size - 1);
                if (newFont.Size < 1)
                {
                    throw new Exception("Text is too long to fit within the available space.");
                }
            }

            Color textColor = style.textColor;

            // Use the new font to render the text on the image
            //align top or bottom
            float yForTopBottom = 0;
            if(!textStyle.topOrBottom)
            {
                yForTopBottom = image.Height - textSize.Height;
            }
            graphics.DrawString(text, newFont, new SolidBrush(textColor), new RectangleF(0, yForTopBottom, image.Width, image.Height * 0.1f), format);

            //clear memory
            graphics.Dispose();
            format.Dispose();
            font.Dispose();
            newFont.Dispose();
            
            return image;
        }
        
        private void btRun_Click(object sender, EventArgs e)
        {
            if(tbExtraText.Text.Length < 4)
            {
                MessageBox.Show("Phải nhập text chèn vào ảnh (dài tối thiểu 4 ký tự)", "Status");
                return;
            }    
            DialogResult runQuestionResult = MessageBox.Show("Bạn đã chắc chắn muốn chèn text này chưa", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (runQuestionResult == DialogResult.Yes)
            {
                DoStuff(); 
            }
            else
            {
                
            }
        }
        
        void DoStuff()
        {
            if (applyFiles.Count > 0)
            {
                gbControl.Enabled = false;
                progressBarInsert.Value = 0;
                Thread t = new Thread(() => {
                    List<string> imageFileNames = new List<string>();
                    
                    foreach (string target in applyFiles)
                    {
                        imageFileNames.Add(Path.GetFileNameWithoutExtension(target));
                    }
                    float numberOfImage = imageFileNames.Count;
                    for (int i = 0; i < applyFiles.Count; i++)
                    {
                        string targetPath = applyFiles[i];
                        Bitmap bmp = (Bitmap)(Image.FromFile(targetPath));
                        Image image = new Bitmap(bmp);
                        bmp.Dispose();
                        File.Delete(targetPath);
                        string insertText = textStyle.extraText;
                        if (textStyle.isInsertFileName)
                        {
                            insertText += "_" + imageFileNames[i];
                        }
                        image = addText2Image(image, insertText, textStyle);
                        image.Save(targetPath, ImageFormat.Png);
                        image.Dispose();
                        float percentNumber = ((float)i) / numberOfImage * 100.0f;
                        int percent = (int)(percentNumber);

                        ThreadPool.QueueUserWorkItem(_ => {
                            progressBarInsert.Invoke(new Action(() => {
                                progressBarInsert.Value = percent;
                                lbPercent.Text = percent.ToString() + "%";
                            }));
                        });
                        
                    }
                    imageFileNames.Clear();

                    ThreadPool.QueueUserWorkItem(_ => {
                        progressBarInsert.Invoke(new Action(() => {
                            progressBarInsert.Value = 100;
                            lbPercent.Text = 100.ToString() + "%";
                            gbControl.Enabled = true;
                        }));
                    });
                    MessageBox.Show("Hoàn thành","Status");
                });
                t.IsBackground = true;
                t.Start();
                

            }
            else
            {
                MessageBox.Show("Đùa à đã chon folder đâu", "Nhìn bạn không chắc chắn =))",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
