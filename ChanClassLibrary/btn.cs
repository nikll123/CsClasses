using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChanClassLibrary
{
    public class btn : Button
    {
        public btn()
        {

        }

        public btn(String text)
        {
            this.Text = text;
        }
    }

    public class btnOk : btn
    {
        public btnOk() : base("Ok"){ }
    }

    public class btnCancel : btn
    {
        public btnCancel(): base("Cancel"){ }
    }

    public class btnClose : btn {
        public btnClose() : base("Close") { }
        protected override void OnClick(EventArgs e) {
            base.OnClick(e);
            (this.FindForm()).Close();
        }
    }

}
