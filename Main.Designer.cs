namespace Abdal_Security_Group_App
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            visualStudio2022DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2022DarkTheme();
            menuItem_about_us = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_donate = new Telerik.WinControls.UI.RadMenuItem();
            irDonationBtn = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_github = new Telerik.WinControls.UI.RadMenuItem();
            desk_alert = new Telerik.WinControls.UI.RadDesktopAlert(components);
            bg_worker = new System.ComponentModel.BackgroundWorker();
            btn_start_shecan = new Telerik.WinControls.UI.RadButton();
            btn_exit = new PictureBox();
            btn_minimize = new PictureBox();
            nicList = new Telerik.WinControls.UI.RadDropDownList();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ShecanPro = new Telerik.WinControls.UI.RadToggleSwitch();
            radRichTextEditorResult = new RichTextBox();
            radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            switchIPUpdater = new Telerik.WinControls.UI.RadToggleSwitch();
            radLabel6 = new Telerik.WinControls.UI.RadLabel();
            radLabel5 = new Telerik.WinControls.UI.RadLabel();
            radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            textUpdaterCodeStatus = new Telerik.WinControls.UI.RadLabel();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            pictureBox1 = new PictureBox();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            UpdateIpPassword = new Telerik.WinControls.UI.RadTextBoxControl();
            TimeSpanPickerIpU = new Telerik.WinControls.UI.RadTimeSpanPicker();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            bg_IpUpdatre = new System.ComponentModel.BackgroundWorker();
            btn_set_dhcp = new Telerik.WinControls.UI.RadButton();
            bg_auto_dns = new System.ComponentModel.BackgroundWorker();
            tb_cf_g_dns = new Telerik.WinControls.UI.RadButton();
            radLabel7 = new Telerik.WinControls.UI.RadLabel();
            bgw_cloudflare = new System.ComponentModel.BackgroundWorker();
            radMenu1 = new Telerik.WinControls.UI.RadMenu();
            radButton1 = new Telerik.WinControls.UI.RadButton();
            bgw_google = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)btn_start_shecan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nicList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShecanPro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).BeginInit();
            radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)switchIPUpdater).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radSeparator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textUpdaterCodeStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateIpPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TimeSpanPickerIpU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_set_dhcp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb_cf_g_dns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // menuItem_about_us
            // 
            menuItem_about_us.Image = Properties.Resources.user_16x16;
            menuItem_about_us.Name = "menuItem_about_us";
            menuItem_about_us.Text = "درباره ما";
            menuItem_about_us.Click += menuItem_about_us_Click;
            // 
            // menuItem_donate
            // 
            menuItem_donate.Image = Properties.Resources.dollar16x16;
            menuItem_donate.Items.AddRange(new Telerik.WinControls.RadItem[] { irDonationBtn });
            menuItem_donate.Name = "menuItem_donate";
            menuItem_donate.Text = "کمک به پروژه";
            // 
            // irDonationBtn
            // 
            irDonationBtn.Image = Properties.Resources.iran_16x16;
            irDonationBtn.Name = "irDonationBtn";
            irDonationBtn.Text = "فارسی زبانان";
            irDonationBtn.Click += irDonationBtn_Click;
            // 
            // radMenuItem3
            // 
            radMenuItem3.Image = Properties.Resources.git_pull_request16x16;
            radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] { menuItem_github });
            radMenuItem3.Name = "radMenuItem3";
            radMenuItem3.Text = "سورس کد";
            // 
            // menuItem_github
            // 
            menuItem_github.Image = Properties.Resources.github;
            menuItem_github.Name = "menuItem_github";
            menuItem_github.Text = "Github";
            menuItem_github.Click += menuItem_github_Click;
            // 
            // bg_worker
            // 
            bg_worker.DoWork += bg_worker_DoWork;
            bg_worker.RunWorkerCompleted += bg_worker_RunWorkerCompleted;
            // 
            // btn_start_shecan
            // 
            btn_start_shecan.Font = new Font("Tahoma", 9F);
            btn_start_shecan.Image = Properties.Resources._20;
            btn_start_shecan.Location = new Point(10, 233);
            btn_start_shecan.Name = "btn_start_shecan";
            btn_start_shecan.Size = new Size(95, 24);
            btn_start_shecan.TabIndex = 1;
            btn_start_shecan.Text = "تنظیم شکن";
            btn_start_shecan.TextAlignment = ContentAlignment.MiddleRight;
            btn_start_shecan.ThemeName = "VisualStudio2022Dark";
            btn_start_shecan.Click += btn_start_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.BackgroundImage = Properties.Resources.x_circle_21x21;
            btn_exit.BackgroundImageLayout = ImageLayout.Stretch;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Location = new Point(412, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(21, 21);
            btn_exit.TabIndex = 2;
            btn_exit.TabStop = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_minimize
            // 
            btn_minimize.BackColor = Color.Transparent;
            btn_minimize.BackgroundImage = Properties.Resources.minus_circle_21x21;
            btn_minimize.BackgroundImageLayout = ImageLayout.Stretch;
            btn_minimize.Cursor = Cursors.Hand;
            btn_minimize.Location = new Point(439, 12);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(21, 21);
            btn_minimize.TabIndex = 3;
            btn_minimize.TabStop = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // nicList
            // 
            nicList.DropDownAnimationEnabled = true;
            nicList.Font = new Font("Tahoma", 9F);
            radListDataItem1.Selected = true;
            radListDataItem1.Tag = "all";
            radListDataItem1.Text = "همه کارت شبکه ها";
            nicList.Items.Add(radListDataItem1);
            nicList.Location = new Point(258, 55);
            nicList.Name = "nicList";
            nicList.Size = new Size(184, 22);
            nicList.TabIndex = 4;
            nicList.Text = "همه کارت شبکه ها";
            nicList.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel1
            // 
            radLabel1.Font = new Font("Tahoma", 9F);
            radLabel1.Location = new Point(362, 31);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(80, 18);
            radLabel1.TabIndex = 5;
            radLabel1.Text = "کارت شبکه ها";
            radLabel1.TextAlignment = ContentAlignment.TopRight;
            radLabel1.ThemeName = "VisualStudio2022Dark";
            // 
            // ShecanPro
            // 
            ShecanPro.Font = new Font("Tahoma", 9F);
            ShecanPro.Location = new Point(151, 55);
            ShecanPro.Name = "ShecanPro";
            ShecanPro.OffText = "شکن رایگان";
            ShecanPro.OnText = "شکن حرفه ای";
            ShecanPro.Size = new Size(101, 22);
            ShecanPro.TabIndex = 6;
            ShecanPro.ThemeName = "VisualStudio2022Dark";
            ShecanPro.ThumbTickness = 16;
            ShecanPro.ValueChanged += ShecanPro_ValueChanged;
            // 
            // radRichTextEditorResult
            // 
            radRichTextEditorResult.BackColor = Color.FromArgb(47, 47, 47);
            radRichTextEditorResult.BorderStyle = BorderStyle.None;
            radRichTextEditorResult.ForeColor = Color.SpringGreen;
            radRichTextEditorResult.Location = new Point(9, 268);
            radRichTextEditorResult.Name = "radRichTextEditorResult";
            radRichTextEditorResult.Size = new Size(453, 206);
            radRichTextEditorResult.TabIndex = 7;
            radRichTextEditorResult.Text = "";
            // 
            // radGroupBox1
            // 
            radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox1.Controls.Add(switchIPUpdater);
            radGroupBox1.Controls.Add(radLabel6);
            radGroupBox1.Controls.Add(radLabel5);
            radGroupBox1.Controls.Add(radSeparator1);
            radGroupBox1.Controls.Add(textUpdaterCodeStatus);
            radGroupBox1.Controls.Add(radLabel3);
            radGroupBox1.Controls.Add(pictureBox1);
            radGroupBox1.Controls.Add(radLabel4);
            radGroupBox1.Controls.Add(UpdateIpPassword);
            radGroupBox1.Controls.Add(radLabel1);
            radGroupBox1.Controls.Add(TimeSpanPickerIpU);
            radGroupBox1.Controls.Add(nicList);
            radGroupBox1.Controls.Add(radLabel2);
            radGroupBox1.Controls.Add(ShecanPro);
            radGroupBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radGroupBox1.HeaderMargin = new Padding(1);
            radGroupBox1.HeaderText = "تنظیمات شکن";
            radGroupBox1.Location = new Point(9, 43);
            radGroupBox1.Name = "radGroupBox1";
            radGroupBox1.Size = new Size(450, 181);
            radGroupBox1.TabIndex = 8;
            radGroupBox1.Text = "تنظیمات شکن";
            radGroupBox1.ThemeName = "VisualStudio2022Dark";
            // 
            // switchIPUpdater
            // 
            switchIPUpdater.Font = new Font("Tahoma", 9F);
            switchIPUpdater.Location = new Point(6, 141);
            switchIPUpdater.Name = "switchIPUpdater";
            switchIPUpdater.OffText = "خاموش";
            switchIPUpdater.OnText = "روشن";
            switchIPUpdater.Size = new Size(69, 22);
            switchIPUpdater.TabIndex = 7;
            switchIPUpdater.ThemeName = "VisualStudio2022Dark";
            switchIPUpdater.ThumbTickness = 16;
            switchIPUpdater.ValueChanged += IPUpdaterSwitch_ValueChanged;
            // 
            // radLabel6
            // 
            radLabel6.Font = new Font("Tahoma", 9F);
            radLabel6.Location = new Point(71, 143);
            radLabel6.Name = "radLabel6";
            radLabel6.Size = new Size(140, 18);
            radLabel6.TabIndex = 9;
            radLabel6.Text = "بروزرسان خودکار آی پی : ";
            radLabel6.TextAlignment = ContentAlignment.TopRight;
            radLabel6.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel5
            // 
            radLabel5.Font = new Font("Tahoma", 9F);
            radLabel5.Location = new Point(229, 87);
            radLabel5.Name = "radLabel5";
            radLabel5.Size = new Size(213, 18);
            radLabel5.TabIndex = 10;
            radLabel5.Text = " بروزرسان آی پی  (برای شکن حرفه ای)";
            radLabel5.TextAlignment = ContentAlignment.TopRight;
            radLabel5.ThemeName = "VisualStudio2022Dark";
            // 
            // radSeparator1
            // 
            radSeparator1.Location = new Point(7, 91);
            radSeparator1.Name = "radSeparator1";
            radSeparator1.Size = new Size(239, 10);
            radSeparator1.TabIndex = 9;
            radSeparator1.ThemeName = "VisualStudio2022Dark";
            // 
            // textUpdaterCodeStatus
            // 
            textUpdaterCodeStatus.Font = new Font("Tahoma", 9F);
            textUpdaterCodeStatus.Location = new Point(0, 108);
            textUpdaterCodeStatus.Name = "textUpdaterCodeStatus";
            textUpdaterCodeStatus.Size = new Size(121, 18);
            textUpdaterCodeStatus.TabIndex = 10;
            textUpdaterCodeStatus.Text = "وضعیت کد : نامشخص";
            textUpdaterCodeStatus.TextAlignment = ContentAlignment.TopRight;
            textUpdaterCodeStatus.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel3
            // 
            radLabel3.Font = new Font("Tahoma", 9F);
            radLabel3.Location = new Point(327, 111);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(115, 18);
            radLabel3.TabIndex = 9;
            radLabel3.Text = "کد  بروزرسان آی پی:";
            radLabel3.TextAlignment = ContentAlignment.TopRight;
            radLabel3.ThemeName = "VisualStudio2022Dark";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.gray;
            pictureBox1.Location = new Point(8, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 58);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // radLabel4
            // 
            radLabel4.Font = new Font("Tahoma", 9F);
            radLabel4.Location = new Point(271, 143);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(176, 18);
            radLabel4.TabIndex = 8;
            radLabel4.Text = "چرخه بروزرسان آی پی بر ث / د :";
            radLabel4.TextAlignment = ContentAlignment.TopRight;
            radLabel4.ThemeName = "VisualStudio2022Dark";
            // 
            // UpdateIpPassword
            // 
            UpdateIpPassword.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateIpPassword.Location = new Point(124, 108);
            UpdateIpPassword.Name = "UpdateIpPassword";
            UpdateIpPassword.NullText = "7f078bd456470b7b";
            UpdateIpPassword.RightToLeft = RightToLeft.Yes;
            UpdateIpPassword.ShowNullText = true;
            UpdateIpPassword.Size = new Size(190, 21);
            UpdateIpPassword.TabIndex = 10;
            UpdateIpPassword.TextAlign = HorizontalAlignment.Center;
            UpdateIpPassword.ThemeName = "VisualStudio2022Dark";
            // 
            // TimeSpanPickerIpU
            // 
            TimeSpanPickerIpU.BackColor = Color.FromArgb(36, 36, 36);
            TimeSpanPickerIpU.ForeColor = Color.FromArgb(221, 221, 221);
            TimeSpanPickerIpU.Format = "mm:ss";
            TimeSpanPickerIpU.Location = new Point(212, 141);
            TimeSpanPickerIpU.MaxValue = TimeSpan.Parse("60.00:00:00");
            TimeSpanPickerIpU.MinValue = TimeSpan.Parse("00:00:04");
            TimeSpanPickerIpU.Name = "TimeSpanPickerIpU";
            TimeSpanPickerIpU.Size = new Size(57, 22);
            TimeSpanPickerIpU.TabIndex = 9;
            TimeSpanPickerIpU.TabStop = false;
            TimeSpanPickerIpU.TextAlign = HorizontalAlignment.Right;
            TimeSpanPickerIpU.ThemeName = "VisualStudio2022Dark";
            TimeSpanPickerIpU.Value = TimeSpan.Parse("00:00:10");
            TimeSpanPickerIpU.ValueChanged += TimeSpanPickerIpU_ValueChanged;
            // 
            // radLabel2
            // 
            radLabel2.Font = new Font("Tahoma", 9F);
            radLabel2.Location = new Point(197, 31);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(55, 18);
            radLabel2.TabIndex = 6;
            radLabel2.Text = "نوع شکن";
            radLabel2.TextAlignment = ContentAlignment.TopRight;
            radLabel2.ThemeName = "VisualStudio2022Dark";
            // 
            // bg_IpUpdatre
            // 
            bg_IpUpdatre.DoWork += bg_IpUpdatre_DoWork;
            bg_IpUpdatre.RunWorkerCompleted += bg_IpUpdatre_RunWorkerCompleted;
            // 
            // btn_set_dhcp
            // 
            btn_set_dhcp.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_set_dhcp.Image = Properties.Resources.fresh3;
            btn_set_dhcp.Location = new Point(112, 233);
            btn_set_dhcp.Name = "btn_set_dhcp";
            btn_set_dhcp.Size = new Size(111, 24);
            btn_set_dhcp.TabIndex = 9;
            btn_set_dhcp.Text = "DNS پیشفرض";
            btn_set_dhcp.TextAlignment = ContentAlignment.MiddleRight;
            btn_set_dhcp.ThemeName = "VisualStudio2022Dark";
            btn_set_dhcp.Click += btn_set_dhcp_Click;
            // 
            // bg_auto_dns
            // 
            bg_auto_dns.DoWork += bg_auto_dns_DoWork;
            bg_auto_dns.RunWorkerCompleted += bg_auto_dns_RunWorkerCompleted;
            // 
            // tb_cf_g_dns
            // 
            tb_cf_g_dns.Image = Properties.Resources.cf;
            tb_cf_g_dns.Location = new Point(230, 233);
            tb_cf_g_dns.Name = "tb_cf_g_dns";
            tb_cf_g_dns.Size = new Size(113, 24);
            tb_cf_g_dns.TabIndex = 10;
            tb_cf_g_dns.Text = "DNS گلودفلیر";
            tb_cf_g_dns.TextAlignment = ContentAlignment.MiddleRight;
            tb_cf_g_dns.ThemeName = "VisualStudio2022Dark";
            tb_cf_g_dns.Click += tb_cf_g_dns_Click;
            // 
            // radLabel7
            // 
            radLabel7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radLabel7.Location = new Point(5, 12);
            radLabel7.Name = "radLabel7";
            radLabel7.Size = new Size(193, 18);
            radLabel7.TabIndex = 11;
            radLabel7.Text = "نرم افزار مدیریت شکن تیم ابدال ";
            radLabel7.TextAlignment = ContentAlignment.TopRight;
            radLabel7.ThemeName = "VisualStudio2022Dark";
            // 
            // bgw_cloudflare
            // 
            bgw_cloudflare.DoWork += bgw_cloudflare_DoWork;
            bgw_cloudflare.RunWorkerCompleted += bgw_cloudflare_RunWorkerCompleted;
            // 
            // radMenu1
            // 
            radMenu1.Dock = DockStyle.Bottom;
            radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] { menuItem_about_us, menuItem_donate, radMenuItem3 });
            radMenu1.Location = new Point(0, 482);
            radMenu1.Name = "radMenu1";
            radMenu1.Size = new Size(472, 28);
            radMenu1.TabIndex = 0;
            radMenu1.ThemeName = "VisualStudio2022Dark";
            // 
            // radButton1
            // 
            radButton1.Image = Properties.Resources.googledns;
            radButton1.Location = new Point(350, 233);
            radButton1.Name = "radButton1";
            radButton1.Size = new Size(88, 24);
            radButton1.TabIndex = 11;
            radButton1.Text = "DNS گوگل";
            radButton1.TextAlignment = ContentAlignment.MiddleRight;
            radButton1.ThemeName = "VisualStudio2022Dark";
            radButton1.Click += radButton1_Click;
            // 
            // bgw_google
            // 
            bgw_google.DoWork += bgw_google_DoWork;
            bgw_google.RunWorkerCompleted += bgw_google_RunWorkerCompleted;
            // 
            // Main
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(472, 510);
            Controls.Add(radButton1);
            Controls.Add(radLabel7);
            Controls.Add(tb_cf_g_dns);
            Controls.Add(btn_set_dhcp);
            Controls.Add(radGroupBox1);
            Controls.Add(radRichTextEditorResult);
            Controls.Add(btn_minimize);
            Controls.Add(btn_exit);
            Controls.Add(btn_start_shecan);
            Controls.Add(radMenu1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ThemeName = "VisualStudio2022Dark";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)btn_start_shecan).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nicList).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShecanPro).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).EndInit();
            radGroupBox1.ResumeLayout(false);
            radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)switchIPUpdater).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)radSeparator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)textUpdaterCodeStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateIpPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)TimeSpanPickerIpU).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_set_dhcp).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb_cf_g_dns).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel7).EndInit();
            ((System.ComponentModel.ISupportInitialize)radMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2022DarkTheme visualStudio2022DarkTheme1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem menuItem_about_us;
        private Telerik.WinControls.UI.RadMenuItem menuItem_donate;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem menuItem_github;
        private Telerik.WinControls.UI.RadDesktopAlert desk_alert;
        private System.ComponentModel.BackgroundWorker bg_worker;
        private Telerik.WinControls.UI.RadButton btn_start_shecan;
        private PictureBox btn_exit;
        private PictureBox btn_minimize;
        private Telerik.WinControls.UI.RadMenuItem irDonationBtn;
        private Telerik.WinControls.UI.RadDropDownList nicList;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadToggleSwitch ShecanPro;
        private RichTextBox radRichTextEditorResult;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTimeSpanPicker TimeSpanPickerIpU;
        private Telerik.WinControls.UI.RadTextBoxControl UpdateIpPassword;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker bg_IpUpdatre;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel textUpdaterCodeStatus;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadToggleSwitch switchIPUpdater;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadButton btn_set_dhcp;
        private System.ComponentModel.BackgroundWorker bg_auto_dns;
        private Telerik.WinControls.UI.RadButton tb_cf_g_dns;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private System.ComponentModel.BackgroundWorker bgw_cloudflare;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.ComponentModel.BackgroundWorker bgw_google;
    }
}
