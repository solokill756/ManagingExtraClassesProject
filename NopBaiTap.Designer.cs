namespace ManageStudentsProject
{
    partial class NopBaiTap
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
            this.label1 = new System.Windows.Forms.Label();
            this.LinkBaiTap = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLinkNopBai = new System.Windows.Forms.TextBox();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenBaiTap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgayBatDau = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNgayKetThuc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaBaiTap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link bài tập";
            // 
            // LinkBaiTap
            // 
            this.LinkBaiTap.AutoSize = true;
            this.LinkBaiTap.LinkColor = System.Drawing.Color.DarkRed;
            this.LinkBaiTap.Location = new System.Drawing.Point(420, 214);
            this.LinkBaiTap.Name = "LinkBaiTap";
            this.LinkBaiTap.Size = new System.Drawing.Size(0, 20);
            this.LinkBaiTap.TabIndex = 1;
            this.LinkBaiTap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkBaiTap_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Link nộp bài";
            // 
            // txtLinkNopBai
            // 
            this.txtLinkNopBai.Location = new System.Drawing.Point(396, 334);
            this.txtLinkNopBai.Name = "txtLinkNopBai";
            this.txtLinkNopBai.Size = new System.Drawing.Size(232, 26);
            this.txtLinkNopBai.TabIndex = 3;
            // 
            // btnNopBai
            // 
            this.btnNopBai.Location = new System.Drawing.Point(374, 387);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(91, 37);
            this.btnNopBai.TabIndex = 4;
            this.btnNopBai.Text = "Nộp bài";
            this.btnNopBai.UseVisualStyleBackColor = true;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(502, 387);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 37);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên bài tập";
            // 
            // txtTenBaiTap
            // 
            this.txtTenBaiTap.Location = new System.Drawing.Point(400, 158);
            this.txtTenBaiTap.Name = "txtTenBaiTap";
            this.txtTenBaiTap.ReadOnly = true;
            this.txtTenBaiTap.Size = new System.Drawing.Size(217, 26);
            this.txtTenBaiTap.TabIndex = 7;
            this.txtTenBaiTap.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.Location = new System.Drawing.Point(414, 263);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.ReadOnly = true;
            this.txtNgayBatDau.Size = new System.Drawing.Size(106, 26);
            this.txtNgayBatDau.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày kết thúc";
            // 
            // TxtNgayKetThuc
            // 
            this.TxtNgayKetThuc.Location = new System.Drawing.Point(667, 263);
            this.TxtNgayKetThuc.Name = "TxtNgayKetThuc";
            this.TxtNgayKetThuc.ReadOnly = true;
            this.TxtNgayKetThuc.Size = new System.Drawing.Size(100, 26);
            this.TxtNgayKetThuc.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã bài tập";
            // 
            // txtMaBaiTap
            // 
            this.txtMaBaiTap.Location = new System.Drawing.Point(400, 99);
            this.txtMaBaiTap.Name = "txtMaBaiTap";
            this.txtMaBaiTap.ReadOnly = true;
            this.txtMaBaiTap.Size = new System.Drawing.Size(217, 26);
            this.txtMaBaiTap.TabIndex = 9;
            this.txtMaBaiTap.TextChanged += new System.EventHandler(this.txtMaBaiTap_TextChanged);
            // 
            // NopBaiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 553);
            this.Controls.Add(this.TxtNgayKetThuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNgayBatDau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaBaiTap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenBaiTap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnNopBai);
            this.Controls.Add(this.txtLinkNopBai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LinkBaiTap);
            this.Controls.Add(this.label1);
            this.Name = "NopBaiTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NopBaiTap";
            this.Load += new System.EventHandler(this.NopBaiTap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkBaiTap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLinkNopBai;
        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenBaiTap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtNgayBatDau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TxtNgayKetThuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaBaiTap;
    }
}