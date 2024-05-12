namespace ManageStudentsProject
{
    partial class frmclass
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtControng = new System.Windows.Forms.RadioButton();
            this.rbtHetcho = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(259, 121);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(274, 26);
            this.txtLop.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(259, 175);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(274, 26);
            this.txtSoluong.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng";
            // 
            // rbtControng
            // 
            this.rbtControng.AutoSize = true;
            this.rbtControng.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rbtControng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtControng.ForeColor = System.Drawing.Color.ForestGreen;
            this.rbtControng.Location = new System.Drawing.Point(268, 230);
            this.rbtControng.Name = "rbtControng";
            this.rbtControng.Size = new System.Drawing.Size(54, 24);
            this.rbtControng.TabIndex = 7;
            this.rbtControng.Text = "Mở";
            this.rbtControng.UseVisualStyleBackColor = true;
            // 
            // rbtHetcho
            // 
            this.rbtHetcho.AutoSize = true;
            this.rbtHetcho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtHetcho.ForeColor = System.Drawing.Color.Red;
            this.rbtHetcho.Location = new System.Drawing.Point(412, 230);
            this.rbtHetcho.Name = "rbtHetcho";
            this.rbtHetcho.Size = new System.Drawing.Size(71, 24);
            this.rbtHetcho.TabIndex = 8;
            this.rbtHetcho.Text = "Đóng";
            this.rbtHetcho.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trạng thái";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Green;
            this.btnLuu.Location = new System.Drawing.Point(195, 291);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 37);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(312, 291);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 37);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Gray;
            this.btnHuy.Location = new System.Drawing.Point(428, 291);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 37);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtHetcho);
            this.Controls.Add(this.rbtControng);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.label1);
            this.Name = "frmclass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmclass";
            this.Load += new System.EventHandler(this.frmclass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtControng;
        private System.Windows.Forms.RadioButton rbtHetcho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
    }
}