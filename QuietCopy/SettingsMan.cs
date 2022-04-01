using QuietCopy.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuietCopy
{
    public partial class SettingsMan : Form
    {
        public SettingsMan()
        {
            InitializeComponent();
            load();
        }

        private void specYes_CheckedChanged(object sender, EventArgs e)
        {
            if(specYes.Checked == true)
            {
                specDirPthTxtBx.Enabled = true;
                label3.Enabled = true;
            }
        }
        void save()
        {
            Settings.Default.destDir = destDirTbox.Text;
            Settings.Default.specDir = specYes.Checked;
            Settings.Default.specDirPath = specDirPthTxtBx.Text;
        }
        void load()
        {
            destDirTbox.Text = Settings.Default.destDir;
        }

        private void okBut_Click(object sender, EventArgs e)
        {
            save();
            Close();
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            save();
        }

        private void destDirBut_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.MyVideos; 
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                destDirTbox.Text = dialog.SelectedPath;
            }
        }
    }
}
