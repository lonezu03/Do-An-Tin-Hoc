namespace Do_An_Tin_Hoc
{
    partial class frmCaLam
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
            this.pnlLich = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlLich
            // 
            this.pnlLich.Location = new System.Drawing.Point(12, 43);
            this.pnlLich.Name = "pnlLich";
            this.pnlLich.Size = new System.Drawing.Size(823, 418);
            this.pnlLich.TabIndex = 0;
            this.pnlLich.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLich_Paint);
            // 
            // frmCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 467);
            this.Controls.Add(this.pnlLich);
            this.Name = "frmCaLam";
            this.Text = "frmCaLam";
            this.Load += new System.EventHandler(this.frmCaLam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLich;
    }
}