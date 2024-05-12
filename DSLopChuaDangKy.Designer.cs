namespace ManageStudentsProject
{
    partial class DSLopChuaDangKy
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
            this.dgvDSLopChuaDangKy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLopChuaDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSLopChuaDangKy
            // 
            this.dgvDSLopChuaDangKy.AllowUserToAddRows = false;
            this.dgvDSLopChuaDangKy.AllowUserToDeleteRows = false;
            this.dgvDSLopChuaDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLopChuaDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLopChuaDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSLopChuaDangKy.Location = new System.Drawing.Point(0, 0);
            this.dgvDSLopChuaDangKy.MultiSelect = false;
            this.dgvDSLopChuaDangKy.Name = "dgvDSLopChuaDangKy";
            this.dgvDSLopChuaDangKy.ReadOnly = true;
            this.dgvDSLopChuaDangKy.RowHeadersWidth = 62;
            this.dgvDSLopChuaDangKy.RowTemplate.Height = 28;
            this.dgvDSLopChuaDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSLopChuaDangKy.Size = new System.Drawing.Size(944, 489);
            this.dgvDSLopChuaDangKy.TabIndex = 0;
            this.dgvDSLopChuaDangKy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLopChuaDangKy_CellContentClick);
            // 
            // DSLopChuaDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 489);
            this.Controls.Add(this.dgvDSLopChuaDangKy);
            this.Name = "DSLopChuaDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách lớp học chưa đăng ký";
            this.Load += new System.EventHandler(this.DSLopChuaDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLopChuaDangKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSLopChuaDangKy;
    }
}