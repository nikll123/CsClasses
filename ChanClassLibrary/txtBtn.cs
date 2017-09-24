﻿using System;
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
     public partial class txtBtn : UserControl
    {
        int originalHeight = 0;
        public txtBtn()
        {
            InitializeComponent();
            originalHeight = this.Height;
        }
        
        private void txtbtn_Resize(object sender, EventArgs e)
        {
            this.Height = originalHeight;
        }
    }
}
