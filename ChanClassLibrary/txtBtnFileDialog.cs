using System.Drawing;
using System.Windows.Forms;

namespace ChanClassLibrary
{
/// <summary>
/// 
/// </summary>
    public abstract class txtBtnFileDialog : txtBtn
    {
        protected OpenFileDialog openFileDialog1;

        public txtBtnFileDialog()
        {
            this.btn.Click += new System.EventHandler(this.btn_Click);

            this.openFileDialog1 = new OpenFileDialog();

            this.SuspendLayout();

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Name = "txtBtnFileDialog";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public bool CheckFileExists
        {
            get
            {
                return openFileDialog1.CheckFileExists;
            }
            set
            {
                openFileDialog1.CheckFileExists = value;
            }
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

        private void btn_Click(object sender, System.EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog(this.FindForm()))
            {
                this.txt.Text = openFileDialog1.FileName;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class txtBtnOpenFile : txtBtnFileDialog
    {
        public txtBtnOpenFile() 
        {
        }
    }

}
