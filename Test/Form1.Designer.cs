namespace Test
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new ChanClassLibrary.btn();
            this.btnCancel1 = new ChanClassLibrary.btnCancel();
            this.btnOk1 = new ChanClassLibrary.btnOk();
            this.btnOk2 = new ChanClassLibrary.btnOk();
            this.txtBtnOpenFile1 = new ChanClassLibrary.txtBtnOpenFile();
            this.txtBtnOpenFolder1 = new ChanClassLibrary.txtBtnOpenFolder();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(97, 29);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "btn1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(97, 58);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnCancel1.TabIndex = 1;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            // 
            // btnOk1
            // 
            this.btnOk1.Location = new System.Drawing.Point(97, 88);
            this.btnOk1.Name = "btnOk1";
            this.btnOk1.Size = new System.Drawing.Size(75, 23);
            this.btnOk1.TabIndex = 2;
            this.btnOk1.Text = "Ok";
            this.btnOk1.UseVisualStyleBackColor = true;
            // 
            // btnOk2
            // 
            this.btnOk2.Location = new System.Drawing.Point(97, 117);
            this.btnOk2.Name = "btnOk2";
            this.btnOk2.Size = new System.Drawing.Size(75, 23);
            this.btnOk2.TabIndex = 3;
            this.btnOk2.Text = "btnOk2";
            this.btnOk2.UseVisualStyleBackColor = true;
            // 
            // txtBtnOpenFile1
            // 
            this.txtBtnOpenFile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBtnOpenFile1.Location = new System.Drawing.Point(80, 159);
            this.txtBtnOpenFile1.Name = "txtBtnOpenFile1";
            this.txtBtnOpenFile1.Size = new System.Drawing.Size(129, 26);
            this.txtBtnOpenFile1.TabIndex = 4;
            // 
            // txtBtnOpenFolder1
            // 
            this.txtBtnOpenFolder1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBtnOpenFolder1.Location = new System.Drawing.Point(80, 192);
            this.txtBtnOpenFolder1.Name = "txtBtnOpenFolder1";
            this.txtBtnOpenFolder1.Size = new System.Drawing.Size(129, 26);
            this.txtBtnOpenFolder1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtBtnOpenFolder1);
            this.Controls.Add(this.txtBtnOpenFile1);
            this.Controls.Add(this.btnOk2);
            this.Controls.Add(this.btnOk1);
            this.Controls.Add(this.btnCancel1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ChanClassLibrary.btn btn1;
        private ChanClassLibrary.btnCancel btnCancel1;
        private ChanClassLibrary.btnOk btnOk1;
        private ChanClassLibrary.btnOk btnOk2;
        private ChanClassLibrary.txtBtnOpenFile txtBtnOpenFile1;
        private ChanClassLibrary.txtBtnOpenFolder txtBtnOpenFolder1;
    }
}

