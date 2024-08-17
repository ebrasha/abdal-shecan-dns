using Abdal_Security_Group_App.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Abdal_Security_Group_App
{
    public partial class full_about_us : Telerik.WinControls.UI.RadForm
    {
        public full_about_us()
        {
            InitializeComponent();
        }

        private void full_about_us_Load(object sender, EventArgs e)
        {
            richTextBox_about_us.Text = AboutUsWriter.about_us_content();
        }

        private void full_about_us_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
