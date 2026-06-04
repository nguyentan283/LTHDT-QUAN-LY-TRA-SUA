namespace WindowsFormsApp1
{
    partial class Mon
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(15, 134);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(44, 16);
            this.lblTenMon.TabIndex = 1;
            this.lblTenMon.Text = "label1";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(15, 155);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(44, 16);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "label2";
            // 
            // Mon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTenMon);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Mon";
            this.Size = new System.Drawing.Size(167, 179);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblGia;
    }
}
