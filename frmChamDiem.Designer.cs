namespace ManageStudentsProject
{
    partial class frmChamDiem
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
            this.dgvDanhSachChamDiem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.ListClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChamDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachChamDiem
            // 
            this.dgvDanhSachChamDiem.AllowUserToAddRows = false;
            this.dgvDanhSachChamDiem.AllowUserToDeleteRows = false;
            this.dgvDanhSachChamDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachChamDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChamDiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachChamDiem.Location = new System.Drawing.Point(0, 97);
            this.dgvDanhSachChamDiem.MultiSelect = false;
            this.dgvDanhSachChamDiem.Name = "dgvDanhSachChamDiem";
            this.dgvDanhSachChamDiem.ReadOnly = true;
            this.dgvDanhSachChamDiem.RowHeadersWidth = 62;
            this.dgvDanhSachChamDiem.RowTemplate.Height = 28;
            this.dgvDanhSachChamDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachChamDiem.Size = new System.Drawing.Size(1020, 403);
            this.dgvDanhSachChamDiem.TabIndex = 0;
            this.dgvDanhSachChamDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachChamDiem_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(672, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 26);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(888, 34);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 35);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // ListClass
            // 
            this.ListClass.FormattingEnabled = true;
            this.ListClass.Location = new System.Drawing.Point(394, 38);
            this.ListClass.Name = "ListClass";
            this.ListClass.Size = new System.Drawing.Size(186, 28);
            this.ListClass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lớp học";
            // 
            // frmChamDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListClass);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachChamDiem);
            this.Name = "frmChamDiem";
            this.Text = "frmChamDiem";
            this.Load += new System.EventHandler(this.frmChamDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChamDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachChamDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox ListClass;
        private System.Windows.Forms.Label label2;
    }
}