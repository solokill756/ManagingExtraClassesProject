namespace ManageStudentsProject
{
    partial class DangSachLopHocDaDk
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
            this.dgvDanhSachLopHoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachLopHoc
            // 
            this.dgvDanhSachLopHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLopHoc.Location = new System.Drawing.Point(483, 191);
            this.dgvDanhSachLopHoc.MultiSelect = false;
            this.dgvDanhSachLopHoc.Name = "dgvDanhSachLopHoc";
            this.dgvDanhSachLopHoc.RowHeadersWidth = 62;
            this.dgvDanhSachLopHoc.RowTemplate.Height = 28;
            this.dgvDanhSachLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachLopHoc.Size = new System.Drawing.Size(240, 150);
            this.dgvDanhSachLopHoc.TabIndex = 0;
            // 
            // DangSachLopHocDaDk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 495);
            this.Controls.Add(this.dgvDanhSachLopHoc);
            this.Name = "DangSachLopHocDaDk";
            this.Text = "Danh sách lớp học đã đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachLopHoc;
    }
}