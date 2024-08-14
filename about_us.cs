using Abdal_Security_Group_App.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdal_Security_Group_App
{
    public partial class about_us : Telerik.WinControls.UI.RadForm
    {
        private AbdalSoundPlayer ab_player = new AbdalSoundPlayer();


        public about_us()
        {
            InitializeComponent();
            Version version = Assembly.GetExecutingAssembly().GetName().Version!;
            label_version.Text = "نسخه:" + " " + version.Major + "." + version.Minor;
            ab_player.sPlayer("ab-us");
        }

        private void about_us_Load(object sender, EventArgs e)
        {
            richTextBox_about_us.Text = AboutUsWriter.about_us_content();
        }

        private void about_us_FormClosing(object sender, FormClosingEventArgs e)
        {
            ab_player.sPlayer("checkbox");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
          
            this.Close();

        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}