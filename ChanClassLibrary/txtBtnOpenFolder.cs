using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChanClassLibrary
{
    public partial class txtBtnOpenFolder : txtBtn
    {
        public txtBtnOpenFolder()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK ==  folderBrowserDialog1.ShowDialog(this.FindForm ()))
            {
                txt.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
