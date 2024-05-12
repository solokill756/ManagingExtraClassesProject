namespace ManageStudentsProject
{
    partial class frmDangKiLopHoc
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
            this.dvgDangkiLophoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDangKi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDangkiLophoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgDangkiLophoc
            // 
            this.dvgDangkiLophoc.AllowUserToAddRows = false;
            this.dvgDangkiLophoc.AllowUserToDeleteRows = false;
            this.dvgDangkiLophoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDangkiLophoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDangkiLophoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dvgDangkiLophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDangkiLophoc.Location = new System.Drawing.Point(-1, 87);
            this.dvgDangkiLophoc.MultiSelect = false;
            this.dvgDangkiLophoc.Name = "dvgDangkiLophoc";
            this.dvgDangkiLophoc.ReadOnly = true;
            this.dvgDangkiLophoc.RowHeadersWidth = 62;
            this.dvgDangkiLophoc.RowTemplate.Height = 28;
            this.dvgDangkiLophoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDangkiLophoc.Size = new System.Drawing.Size(870, 379);
            this.dvgDangkiLophoc.TabIndex = 0;
            this.dvgDangkiLophoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDangkiLophoc_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ khóa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTuKhoa.Location = new System.Drawing.Point(355, 34);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(251, 26);
            this.txtTuKhoa.TabIndex = 2;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(622, 32);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 35);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKi.Location = new System.Drawing.Point(747, 32);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(110, 35);
            this.btnDangKi.TabIndex = 4;
            this.btnDangKi.Text = "Đăng ký";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // frmDangKiLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 466);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgDangkiLophoc);
            this.Name = "frmDangKiLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách lớp học đã đăng ký";
            this.Load += new System.EventHandler(this.frmDangKiLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDangkiLophoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgDangkiLophoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDangKi;
    }
}