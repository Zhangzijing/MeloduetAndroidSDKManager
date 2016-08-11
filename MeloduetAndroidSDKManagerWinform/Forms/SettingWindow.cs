using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeloduetAndroidSDKManagerWinform.Forms
{
    public partial class SettingWindow : Form
    {
        public SettingWindow()
        {
            InitializeComponent();
        }

        private void SettingWindow_Load(object sender, EventArgs e)
        {
            
            foreach (var item in Data.AppSet.Repository)
            {
                textBoxRepository.AppendText(item + "\n");
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Data.AppSet.Repository.Clear();
            string[] source = textBoxRepository.Text.Split('\n');
            foreach (var item in source)
            {
                if (Valid(item))
                {
                    Data.AppSet.Repository.Add(item);
                }
            }
            Data.AppSet.Save("setting.json");
            this.Close();

        }
        private bool Valid(string url)
        {
            
            if (!(url.StartsWith("http://") || url.StartsWith("https://")))
                return false;
            if (!(url.ToLower().EndsWith("repository")))
                return false;
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
