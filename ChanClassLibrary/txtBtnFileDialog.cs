using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChanClassLibrary {
    public abstract partial class txtBtnFileDialog : txtBtn {
        public txtBtnFileDialog() {
            InitializeComponent();
        }

        public string FileName
        {
            get
            {
                return txt.Text;
            }
            set
            {
                txt.Text = value;
            }
        }

        public string Filter
        {
            get
            {
                return openFileDialog1.Filter;
            }
            set
            {
                openFileDialog1.Filter = value;
            }

        }

    }

}
