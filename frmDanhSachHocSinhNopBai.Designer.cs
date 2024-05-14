namespace ManageStudentsProject
{
    partial class frmDanhSachHocSinhNopBai
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
            this.dgvDsHocSinhNopBt = new System.Windows.Forms.DataGridView();
            this.ListStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHocSinhNopBt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDsHocSinhNopBt
            // 
            this.dgvDsHocSinhNopBt.AllowUserToAddRows = false;
            this.dgvDsHocSinhNopBt.AllowUserToDeleteRows = false;
            this.dgvDsHocSinhNopBt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsHocSinhNopBt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsHocSinhNopBt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDsHocSinhNopBt.Location = new System.Drawing.Point(0, 72);
            this.dgvDsHocSinhNopBt.MultiSelect = false;
            this.dgvDsHocSinhNopBt.Name = "dgvDsHocSinhNopBt";
            this.dgvDsHocSinhNopBt.ReadOnly = true;
            this.dgvDsHocSinhNopBt.RowHeadersWidth = 62;
            this.dgvDsHocSinhNopBt.RowTemplate.Height = 28;
            this.dgvDsHocSinhNopBt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsHocSinhNopBt.Size = new System.Drawing.Size(800, 378);
            this.dgvDsHocSinhNopBt.TabIndex = 0;
            this.dgvDsHocSinhNopBt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsHocSinhNopBt_CellContentClick);
            // 
            // ListStatus
            // 
            this.ListStatus.FormattingEnabled = true;
            this.ListStatus.Items.AddRange(new object[] {
            "Đã Chấm",
            "Chưa Chấm"});
            this.ListStatus.Location = new System.Drawing.Point(437, 27);
            this.ListStatus.Name = "ListStatus";
            this.ListStatus.Size = new System.Drawing.Size(233, 28);
            this.ListStatus.TabIndex = 1;
            this.ListStatus.SelectedIndexChanged += new System.EventHandler(this.ListStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trạng thái";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(676, 27);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(101, 32);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmDanhSachHocSinhNopBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListStatus);
            this.Controls.Add(this.dgvDsHocSinhNopBt);
            this.Name = "frmDanhSachHocSinhNopBai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDanhSachHocSinhNopBai";
            this.Load += new System.EventHandler(this.frmDanhSachHocSinhNopBai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHocSinhNopBt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsHocSinhNopBt;
        private System.Windows.Forms.ComboBox ListStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
    }
}