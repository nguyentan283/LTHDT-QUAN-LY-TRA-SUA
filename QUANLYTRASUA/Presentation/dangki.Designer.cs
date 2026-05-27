namespace WindowsFormsApp1
{
    partial class dangki
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
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtxnmk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btndangki = new System.Windows.Forms.Button();
            this.txtten = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.lblxnmk = new System.Windows.Forms.Label();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.lblsdt = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(211, 216);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(100, 20);
            this.txtsdt.TabIndex = 2;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(211, 253);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(64, 20);
            this.txtmatkhau.TabIndex = 4;
            // 
            // txtxnmk
            // 
            this.txtxnmk.Location = new System.Drawing.Point(211, 288);
            this.txtxnmk.Name = "txtxnmk";
            this.txtxnmk.Size = new System.Drawing.Size(64, 20);
            this.txtxnmk.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // btndangki
            // 
            this.btndangki.BackColor = System.Drawing.Color.Red;
            this.btndangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndangki.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndangki.Location = new System.Drawing.Point(69, 341);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(119, 43);
            this.btndangki.TabIndex = 9;
            this.btndangki.Text = "Đăng kí ✍";
            this.btndangki.UseVisualStyleBackColor = false;
            this.btndangki.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(211, 179);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(140, 20);
            this.txtten.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnquaylai);
            this.panel2.Controls.Add(this.btndangki);
            this.panel2.Controls.Add(this.txtten);
            this.panel2.Controls.Add(this.txtxnmk);
            this.panel2.Controls.Add(this.lblxnmk);
            this.panel2.Controls.Add(this.txtmatkhau);
            this.panel2.Controls.Add(this.lblmatkhau);
            this.panel2.Controls.Add(this.lblsdt);
            this.panel2.Controls.Add(this.lblten);
            this.panel2.Controls.Add(this.txtsdt);
            this.panel2.Location = new System.Drawing.Point(436, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 450);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 110);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(113, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "ĐĂNG KÍ";
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnquaylai.Location = new System.Drawing.Point(211, 341);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(119, 43);
            this.btnquaylai.TabIndex = 13;
            this.btnquaylai.Text = "Quay Lại ↩";
            this.btnquaylai.UseVisualStyleBackColor = false;
            // 
            // lblxnmk
            // 
            this.lblxnmk.AutoSize = true;
            this.lblxnmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblxnmk.Location = new System.Drawing.Point(18, 288);
            this.lblxnmk.Name = "lblxnmk";
            this.lblxnmk.Size = new System.Drawing.Size(153, 18);
            this.lblxnmk.TabIndex = 11;
            this.lblxnmk.Text = "Xác nhận lại mật khẩu";
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblmatkhau.Location = new System.Drawing.Point(102, 252);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(88, 18);
            this.lblmatkhau.TabIndex = 10;
            this.lblmatkhau.Text = "Mật khẩu 🔒";
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblsdt.Location = new System.Drawing.Point(77, 218);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(115, 18);
            this.lblsdt.TabIndex = 9;
            this.lblsdt.Text = "Số điện thoại 📞";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblten.Location = new System.Drawing.Point(66, 179);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(124, 18);
            this.lblten.TabIndex = 8;
            this.lblten.Text = "Tên đăng nhập 👤";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Location = new System.Drawing.Point(436, -10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 460);
            this.panel3.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.ChatGPT_Image_16_20_40_26_thg_5__2026;
            this.pictureBox1.Location = new System.Drawing.Point(-18, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SandyBrown;
            this.panel4.Location = new System.Drawing.Point(436, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(383, 10);
            this.panel4.TabIndex = 15;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dangki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Name = "dangki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dangki";
            this.Load += new System.EventHandler(this.dangki_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtxnmk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndangki;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label lblxnmk;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
    }
}