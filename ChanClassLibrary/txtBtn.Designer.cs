namespace ChanClassLibrary
{
    partial class txtBtn
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt = new ChanClassLibrary.txt();
            this.btn = new ChanClassLibrary.btn();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.Location = new System.Drawing.Point(3, 3);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.Location = new System.Drawing.Point(103, 2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(24, 22);
            this.btn.TabIndex = 1;
            this.btn.Text = "...";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // txtBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txt);
            this.Name = "txtBtn";
            this.Size = new System.Drawing.Size(129, 26);
            this.Resize += new System.EventHandler(this.txtbtn_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChanClassLibrary.txt txt;
        private ChanClassLibrary.btn btn;
    }
}
