
using System.Drawing;
using System.Windows.Forms;

namespace ImageMark
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSelectFolder = new System.Windows.Forms.Button();
            this.tbExtraText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbListFiles = new System.Windows.Forms.RichTextBox();
            this.btRun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBoxPreview = new System.Windows.Forms.PictureBox();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btColorPicker = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioNoInsertFileName = new System.Windows.Forms.RadioButton();
            this.radioIsInserFileName = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.radioLeft = new System.Windows.Forms.RadioButton();
            this.btPreview = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBottom = new System.Windows.Forms.RadioButton();
            this.radioTop = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.progressBarInsert = new System.Windows.Forms.ProgressBar();
            this.lbPercent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPreview)).BeginInit();
            this.gbControl.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSelectFolder
            // 
            this.btSelectFolder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectFolder.Location = new System.Drawing.Point(6, 19);
            this.btSelectFolder.Name = "btSelectFolder";
            this.btSelectFolder.Size = new System.Drawing.Size(111, 28);
            this.btSelectFolder.TabIndex = 1;
            this.btSelectFolder.Text = "Select Folder";
            this.btSelectFolder.UseVisualStyleBackColor = true;
            this.btSelectFolder.Click += new System.EventHandler(this.btSelectFolder_Click);
            // 
            // tbExtraText
            // 
            this.tbExtraText.Location = new System.Drawing.Point(6, 191);
            this.tbExtraText.Name = "tbExtraText";
            this.tbExtraText.Size = new System.Drawing.Size(254, 20);
            this.tbExtraText.TabIndex = 0;
            this.tbExtraText.Text = "Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập text cần chèn vào ảnh";
            // 
            // rtbListFiles
            // 
            this.rtbListFiles.Location = new System.Drawing.Point(12, 25);
            this.rtbListFiles.Name = "rtbListFiles";
            this.rtbListFiles.Size = new System.Drawing.Size(356, 309);
            this.rtbListFiles.TabIndex = 11;
            this.rtbListFiles.Text = "";
            // 
            // btRun
            // 
            this.btRun.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRun.Location = new System.Drawing.Point(123, 230);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(105, 42);
            this.btRun.TabIndex = 3;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBoxPreview);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(374, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 578);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview:";
            // 
            // picBoxPreview
            // 
            this.picBoxPreview.Location = new System.Drawing.Point(6, 14);
            this.picBoxPreview.Name = "picBoxPreview";
            this.picBoxPreview.Size = new System.Drawing.Size(509, 558);
            this.picBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPreview.TabIndex = 0;
            this.picBoxPreview.TabStop = false;
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.label3);
            this.gbControl.Controls.Add(this.btColorPicker);
            this.gbControl.Controls.Add(this.groupBox4);
            this.gbControl.Controls.Add(this.groupBox3);
            this.gbControl.Controls.Add(this.btSelectFolder);
            this.gbControl.Controls.Add(this.btPreview);
            this.gbControl.Controls.Add(this.groupBox2);
            this.gbControl.Controls.Add(this.tbExtraText);
            this.gbControl.Controls.Add(this.btRun);
            this.gbControl.Controls.Add(this.label1);
            this.gbControl.Location = new System.Drawing.Point(12, 332);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(356, 277);
            this.gbControl.TabIndex = 1;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Option:";
            // 
            // btColorPicker
            // 
            this.btColorPicker.BackColor = System.Drawing.Color.Lime;
            this.btColorPicker.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btColorPicker.Location = new System.Drawing.Point(197, 138);
            this.btColorPicker.Name = "btColorPicker";
            this.btColorPicker.Size = new System.Drawing.Size(137, 28);
            this.btColorPicker.TabIndex = 15;
            this.btColorPicker.Text = "Color";
            this.btColorPicker.UseVisualStyleBackColor = false;
            this.btColorPicker.Click += new System.EventHandler(this.btColorPicker_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioNoInsertFileName);
            this.groupBox4.Controls.Add(this.radioIsInserFileName);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 53);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Có chèn cả tên file hay không?";
            // 
            // radioNoInsertFileName
            // 
            this.radioNoInsertFileName.AutoSize = true;
            this.radioNoInsertFileName.Checked = true;
            this.radioNoInsertFileName.Location = new System.Drawing.Point(83, 19);
            this.radioNoInsertFileName.Name = "radioNoInsertFileName";
            this.radioNoInsertFileName.Size = new System.Drawing.Size(56, 18);
            this.radioNoInsertFileName.TabIndex = 8;
            this.radioNoInsertFileName.TabStop = true;
            this.radioNoInsertFileName.Text = "Không";
            this.radioNoInsertFileName.UseVisualStyleBackColor = true;
            // 
            // radioIsInserFileName
            // 
            this.radioIsInserFileName.AutoSize = true;
            this.radioIsInserFileName.Location = new System.Drawing.Point(6, 19);
            this.radioIsInserFileName.Name = "radioIsInserFileName";
            this.radioIsInserFileName.Size = new System.Drawing.Size(38, 18);
            this.radioIsInserFileName.TabIndex = 7;
            this.radioIsInserFileName.Text = "Có";
            this.radioIsInserFileName.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioRight);
            this.groupBox3.Controls.Add(this.radioLeft);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(197, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 53);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trái / Phải";
            // 
            // radioRight
            // 
            this.radioRight.AutoSize = true;
            this.radioRight.Checked = true;
            this.radioRight.Location = new System.Drawing.Point(83, 19);
            this.radioRight.Name = "radioRight";
            this.radioRight.Size = new System.Drawing.Size(46, 18);
            this.radioRight.TabIndex = 8;
            this.radioRight.TabStop = true;
            this.radioRight.Text = "Phải";
            this.radioRight.UseVisualStyleBackColor = true;
            // 
            // radioLeft
            // 
            this.radioLeft.AutoSize = true;
            this.radioLeft.Location = new System.Drawing.Point(6, 19);
            this.radioLeft.Name = "radioLeft";
            this.radioLeft.Size = new System.Drawing.Size(45, 18);
            this.radioLeft.TabIndex = 7;
            this.radioLeft.Text = "Trái";
            this.radioLeft.UseVisualStyleBackColor = true;
            // 
            // btPreview
            // 
            this.btPreview.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPreview.Location = new System.Drawing.Point(6, 230);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(111, 42);
            this.btPreview.TabIndex = 2;
            this.btPreview.Text = "Preview";
            this.btPreview.UseVisualStyleBackColor = true;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBottom);
            this.groupBox2.Controls.Add(this.radioTop);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 53);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trên / Dưới";
            // 
            // radioBottom
            // 
            this.radioBottom.AutoSize = true;
            this.radioBottom.Location = new System.Drawing.Point(83, 19);
            this.radioBottom.Name = "radioBottom";
            this.radioBottom.Size = new System.Drawing.Size(48, 18);
            this.radioBottom.TabIndex = 8;
            this.radioBottom.Text = "Dưới";
            this.radioBottom.UseVisualStyleBackColor = true;
            // 
            // radioTop
            // 
            this.radioTop.AutoSize = true;
            this.radioTop.Checked = true;
            this.radioTop.Location = new System.Drawing.Point(6, 19);
            this.radioTop.Name = "radioTop";
            this.radioTop.Size = new System.Drawing.Size(48, 18);
            this.radioTop.TabIndex = 7;
            this.radioTop.TabStop = true;
            this.radioTop.Text = "Trên";
            this.radioTop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "List File:";
            // 
            // progressBarInsert
            // 
            this.progressBarInsert.Location = new System.Drawing.Point(12, 609);
            this.progressBarInsert.Name = "progressBarInsert";
            this.progressBarInsert.Size = new System.Drawing.Size(883, 28);
            this.progressBarInsert.TabIndex = 16;
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.Location = new System.Drawing.Point(432, 616);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(44, 13);
            this.lbPercent.TabIndex = 17;
            this.lbPercent.Text = "Percent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "* Tối thiểu 4 ký tự";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 832);
            this.Controls.Add(this.lbPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarInsert);
            this.Controls.Add(this.rtbListFiles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbControl);
            this.Name = "Form1";
            this.Text = "Image Mark";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPreview)).EndInit();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSelectFolder;
        private System.Windows.Forms.TextBox tbExtraText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbListFiles;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picBoxPreview;
        private System.Windows.Forms.GroupBox gbControl;
        private Button btPreview;
        private Label label2;
        private RadioButton radioTop;
        private GroupBox groupBox2;
        private RadioButton radioBottom;
        private GroupBox groupBox3;
        private RadioButton radioRight;
        private RadioButton radioLeft;
        private GroupBox groupBox4;
        private RadioButton radioNoInsertFileName;
        private RadioButton radioIsInserFileName;
        private Button btColorPicker;
        private ColorDialog colorDialog1;
        private ProgressBar progressBarInsert;
        private Label lbPercent;
        private Label label3;
    }
}

