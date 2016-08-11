using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeloduetAndroidSDKManagerWinform.Forms
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }



        private void AboutBox_Load(object sender, EventArgs e)
        {
            txtVersion.Text = "版本: " + Application.ProductVersion
            +"(Debug)";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.meloduet.com/");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://android.meloduet.com/");
        }
    }
}
