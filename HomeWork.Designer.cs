namespace ManageStudentsProject
{
    partial class HomeWork
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
            this.txtTenBt = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLinkBaiTap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgayKetThuc = new System.Windows.Forms.MaskedTextBox();
            this.txtNgayBatDau = new System.Windows.Forms.MaskedTextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lstClass = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bài tập";
            // 
            // txtTenBt
            // 
            this.txtTenBt.Location = new System.Drawing.Point(337, 88);
            this.txtTenBt.Name = "txtTenBt";
            this.txtTenBt.Size = new System.Drawing.Size(257, 26);
            this.txtTenBt.TabIndex = 1;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(337, 140);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(257, 26);
            this.txtTacGia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày kết thúc";
            // 
            // txtLinkBaiTap
            // 
            this.txtLinkBaiTap.Location = new System.Drawing.Point(337, 255);
            this.txtLinkBaiTap.Name = "txtLinkBaiTap";
            this.txtLinkBaiTap.Size = new System.Drawing.Size(257, 26);
            this.txtLinkBaiTap.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Link bài tập";
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.Location = new System.Drawing.Point(567, 196);
            this.txtNgayKetThuc.Mask = "00/00/0000";
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Size = new System.Drawing.Size(104, 26);
            this.txtNgayKetThuc.TabIndex = 10;
            this.txtNgayKetThuc.ValidatingType = typeof(System.DateTime);
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.Location = new System.Drawing.Point(337, 196);
            this.txtNgayBatDau.Mask = "00/00/0000";
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Size = new System.Drawing.Size(112, 26);
            this.txtNgayBatDau.TabIndex = 11;
            this.txtNgayBatDau.ValidatingType = typeof(System.DateTime);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(247, 375);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 41);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(356, 375);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 41);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(475, 375);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 41);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lớp học";
            // 
            // lstClass
            // 
            this.lstClass.FormattingEnabled = true;
            this.lstClass.Location = new System.Drawing.Point(337, 308);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(257, 28);
            this.lstClass.TabIndex = 16;
            // 
            // HomeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 471);
            this.Controls.Add(this.lstClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtNgayBatDau);
            this.Controls.Add(this.txtNgayKetThuc);
            this.Controls.Add(this.txtLinkBaiTap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenBt);
            this.Controls.Add(this.label1);
            this.Name = "HomeWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeWork";
            this.Load += new System.EventHandler(this.HomeWork_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenBt;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLinkBaiTap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtNgayKetThuc;
        private System.Windows.Forms.MaskedTextBox txtNgayBatDau;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox lstClass;
    }
}