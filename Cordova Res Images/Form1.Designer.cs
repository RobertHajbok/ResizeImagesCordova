namespace ResizeImagesCordova
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
            this.ofd_Image = new System.Windows.Forms.OpenFileDialog();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.btn_ChooseFile = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.rb_Icons = new System.Windows.Forms.RadioButton();
            this.rb_ScreensPortrait = new System.Windows.Forms.RadioButton();
            this.rbScreensLandscape = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Image
            // 
            this.pb_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Image.Location = new System.Drawing.Point(12, 12);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(320, 320);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 0;
            this.pb_Image.TabStop = false;
            // 
            // btn_ChooseFile
            // 
            this.btn_ChooseFile.Location = new System.Drawing.Point(12, 361);
            this.btn_ChooseFile.Name = "btn_ChooseFile";
            this.btn_ChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btn_ChooseFile.TabIndex = 1;
            this.btn_ChooseFile.Text = "Choose File";
            this.btn_ChooseFile.UseVisualStyleBackColor = true;
            this.btn_ChooseFile.Click += new System.EventHandler(this.btn_ChooseFile_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Enabled = false;
            this.btn_Create.Location = new System.Drawing.Point(257, 361);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 2;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // rb_Icons
            // 
            this.rb_Icons.AutoSize = true;
            this.rb_Icons.Checked = true;
            this.rb_Icons.Location = new System.Drawing.Point(12, 338);
            this.rb_Icons.Name = "rb_Icons";
            this.rb_Icons.Size = new System.Drawing.Size(51, 17);
            this.rb_Icons.TabIndex = 3;
            this.rb_Icons.TabStop = true;
            this.rb_Icons.Text = "Icons";
            this.rb_Icons.UseVisualStyleBackColor = true;
            // 
            // rb_ScreensPortrait
            // 
            this.rb_ScreensPortrait.AutoSize = true;
            this.rb_ScreensPortrait.Location = new System.Drawing.Point(88, 338);
            this.rb_ScreensPortrait.Name = "rb_ScreensPortrait";
            this.rb_ScreensPortrait.Size = new System.Drawing.Size(105, 17);
            this.rb_ScreensPortrait.TabIndex = 4;
            this.rb_ScreensPortrait.TabStop = true;
            this.rb_ScreensPortrait.Text = "Screens (portrait)";
            this.rb_ScreensPortrait.UseVisualStyleBackColor = true;
            // 
            // rbScreensLandscape
            // 
            this.rbScreensLandscape.AutoSize = true;
            this.rbScreensLandscape.Location = new System.Drawing.Point(210, 338);
            this.rbScreensLandscape.Name = "rbScreensLandscape";
            this.rbScreensLandscape.Size = new System.Drawing.Size(122, 17);
            this.rbScreensLandscape.TabIndex = 5;
            this.rbScreensLandscape.TabStop = true;
            this.rbScreensLandscape.Text = "Screens (landscape)";
            this.rbScreensLandscape.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 395);
            this.Controls.Add(this.rbScreensLandscape);
            this.Controls.Add(this.rb_ScreensPortrait);
            this.Controls.Add(this.rb_Icons);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_ChooseFile);
            this.Controls.Add(this.pb_Image);
            this.Name = "Form1";
            this.Text = "Cordova Res Images";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd_Image;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Button btn_ChooseFile;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.RadioButton rb_Icons;
        private System.Windows.Forms.RadioButton rb_ScreensPortrait;
        private System.Windows.Forms.RadioButton rbScreensLandscape;
    }
}

