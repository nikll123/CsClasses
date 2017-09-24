using System.Windows.Forms;

namespace ChanClassLibrary
{
    public partial class txtBtnOpenFile : txtBtn
    {
        public txtBtnOpenFile()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, System.EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog(this.FindForm()))
            {
                this.txt.Text = openFileDialog1.FileName;
            }
        }

        public string FileName
        {
            get
            {
                return txt.Text;
            }
        }

        public string Filter
        {
            get
            {
                return openFileDialog1.Filter ;
            }
            set
            {
                openFileDialog1.Filter = value;
            }

        }
    }
}
