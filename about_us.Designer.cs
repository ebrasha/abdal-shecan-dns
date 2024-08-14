namespace Abdal_Security_Group_App
{
    partial class about_us
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about_us));
            visualStudio2022DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2022DarkTheme();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            richTextBox_about_us = new RichTextBox();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            label_version = new Telerik.WinControls.UI.RadLabel();
            btn_minimize = new PictureBox();
            btn_exit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)label_version).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(152, 32);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(191, 21);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "با عشق کار دست ابراهیم شفیعی";
            radLabel1.TextAlignment = ContentAlignment.TopRight;
            radLabel1.ThemeName = "VisualStudio2022Dark";
            // 
            // radPictureBox1
            // 
            radPictureBox1.Image = Properties.Resources.Untitled_3;
            radPictureBox1.Location = new Point(11, 20);
            radPictureBox1.Name = "radPictureBox1";
            radPictureBox1.Size = new Size(123, 259);
            radPictureBox1.TabIndex = 1;
            radPictureBox1.ThemeName = "VisualStudio2022Dark";
            // 
            // richTextBox_about_us
            // 
            richTextBox_about_us.BackColor = Color.FromArgb(60, 60, 70);
            richTextBox_about_us.BorderStyle = BorderStyle.None;
            richTextBox_about_us.ForeColor = SystemColors.InactiveCaption;
            richTextBox_about_us.Location = new Point(152, 178);
            richTextBox_about_us.Name = "richTextBox_about_us";
            richTextBox_about_us.ReadOnly = true;
            richTextBox_about_us.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox_about_us.Size = new Size(311, 105);
            richTextBox_about_us.TabIndex = 2;
            richTextBox_about_us.Text = "";
            // 
            // radLabel2
            // 
            radLabel2.Location = new Point(152, 63);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(189, 21);
            radLabel2.TabIndex = 1;
            radLabel2.Text = "ایمیل: Prof.Shafiei@Gmail.com";
            radLabel2.TextAlignment = ContentAlignment.TopRight;
            radLabel2.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel3
            // 
            radLabel3.Location = new Point(152, 94);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(308, 21);
            radLabel3.TabIndex = 1;
            radLabel3.Text = "وب سایتها: www.Hackers.Zone - www.ebrasha.com";
            radLabel3.TextAlignment = ContentAlignment.TopRight;
            radLabel3.ThemeName = "VisualStudio2022Dark";
            // 
            // label_version
            // 
            label_version.Location = new Point(152, 125);
            label_version.Name = "label_version";
            label_version.Size = new Size(57, 21);
            label_version.TabIndex = 1;
            label_version.Text = "نسخه :....";
            label_version.TextAlignment = ContentAlignment.TopRight;
            label_version.ThemeName = "VisualStudio2022Dark";
            // 
            // btn_minimize
            // 
            btn_minimize.BackColor = Color.Transparent;
            btn_minimize.BackgroundImage = Properties.Resources.minus_circle_21x21;
            btn_minimize.Cursor = Cursors.Hand;
            btn_minimize.Location = new Point(447, 12);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(21, 21);
            btn_minimize.TabIndex = 5;
            btn_minimize.TabStop = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.BackgroundImage = Properties.Resources.x_circle_21x21;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Location = new Point(420, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(21, 21);
            btn_exit.TabIndex = 4;
            btn_exit.TabStop = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // about_us
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 304);
            Controls.Add(btn_minimize);
            Controls.Add(btn_exit);
            Controls.Add(label_version);
            Controls.Add(radLabel3);
            Controls.Add(radLabel2);
            Controls.Add(richTextBox_about_us);
            Controls.Add(radPictureBox1);
            Controls.Add(radLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "about_us";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "درباره ما";
            ThemeName = "VisualStudio2022Dark";
            FormClosing += about_us_FormClosing;
            Load += about_us_Load;
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)label_version).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2022DarkTheme visualStudio2022DarkTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;
        private RichTextBox richTextBox_about_us;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel label_version;
        private PictureBox btn_minimize;
        private PictureBox btn_exit;
    }
}
