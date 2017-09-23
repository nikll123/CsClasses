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
    abstract public partial class txtBtn : UserControl
    {
        int originalHeight = 0;
        public txtBtn()
        {
            InitializeComponent();
            originalHeight = this.Height;
        }

       /* private void refresh()
        {
            btn.Left  = this.Width - btn.Width;
            txt.Width = btn.Left;
            this.Height = txt.Height;
        }*/

        private void txtbtn_Resize(object sender, EventArgs e)
        {
            this.Height = originalHeight;
        }
    }
}
