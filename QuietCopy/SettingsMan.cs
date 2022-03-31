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
        }

        private void specYes_CheckedChanged(object sender, EventArgs e)
        {
            if(specYes.Checked == true)
            {
                specDirPthTxtBx.Enabled = true;
                label3.Enabled = true;
            }
        }
    }
}
