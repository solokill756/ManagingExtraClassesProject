namespace ManageStudentsProject
{
    partial class XemDiem
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
            this.dgvXemDiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXemDiem
            // 
            this.dgvXemDiem.AllowDrop = true;
            this.dgvXemDiem.AllowUserToAddRows = false;
            this.dgvXemDiem.AllowUserToDeleteRows = false;
            this.dgvXemDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXemDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXemDiem.Location = new System.Drawing.Point(0, 0);
            this.dgvXemDiem.MultiSelect = false;
            this.dgvXemDiem.Name = "dgvXemDiem";
            this.dgvXemDiem.ReadOnly = true;
            this.dgvXemDiem.RowHeadersWidth = 62;
            this.dgvXemDiem.RowTemplate.Height = 28;
            this.dgvXemDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXemDiem.Size = new System.Drawing.Size(964, 542);
            this.dgvXemDiem.TabIndex = 0;
            this.dgvXemDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXemDiem_CellContentClick);
            // 
            // XemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 542);
            this.Controls.Add(this.dgvXemDiem);
            this.Name = "XemDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemDiem";
            this.Load += new System.EventHandler(this.XemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXemDiem;
    }
}