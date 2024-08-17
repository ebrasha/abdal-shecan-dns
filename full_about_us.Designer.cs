namespace Abdal_Security_Group_App
{
    partial class full_about_us
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(full_about_us));
            visualStudio2022DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2022DarkTheme();
            richTextBox_about_us = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // richTextBox_about_us
            // 
            richTextBox_about_us.BackColor = Color.FromArgb(60, 60, 70);
            richTextBox_about_us.BorderStyle = BorderStyle.None;
            richTextBox_about_us.Dock = DockStyle.Fill;
            richTextBox_about_us.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_about_us.ForeColor = SystemColors.InactiveCaption;
            richTextBox_about_us.Location = new Point(0, 0);
            richTextBox_about_us.Name = "richTextBox_about_us";
            richTextBox_about_us.ReadOnly = true;
            richTextBox_about_us.RightToLeft = RightToLeft.Yes;
            richTextBox_about_us.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox_about_us.Size = new Size(622, 315);
            richTextBox_about_us.TabIndex = 3;
            richTextBox_about_us.Text = "";
            // 
            // full_about_us
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 315);
            Controls.Add(richTextBox_about_us);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "full_about_us";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "درباره ما";
            ThemeName = "VisualStudio2022Dark";
            WindowState = FormWindowState.Maximized;
            FormClosing += full_about_us_FormClosing;
            Load += full_about_us_Load;
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2022DarkTheme visualStudio2022DarkTheme1;
        private RichTextBox richTextBox_about_us;
    }
}
