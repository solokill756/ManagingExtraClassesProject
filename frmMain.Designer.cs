namespace ManageStudentsProject
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hocSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaiTapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LopHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NopBaiTapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangKiLopHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LopDaDangKyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.ChamDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLíToolStripMenuItem,
            this.NopBaiTapToolStripMenuItem,
            this.DangKiLopHocToolStripMenuItem,
            this.LopDaDangKyToolStripMenuItem,
            this.ChamDiemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1719, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMatKhauToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(103, 30);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hocSinhToolStripMenuItem,
            this.BaiTapToolStripMenuItem,
            this.LopHocToolStripMenuItem});
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(92, 30);
            this.quảnLíToolStripMenuItem.Text = "Quản Lý";
            // 
            // hocSinhToolStripMenuItem
            // 
            this.hocSinhToolStripMenuItem.Name = "hocSinhToolStripMenuItem";
            this.hocSinhToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.hocSinhToolStripMenuItem.Text = "Học sinh";
            this.hocSinhToolStripMenuItem.Click += new System.EventHandler(this.hocSinhToolStripMenuItem_Click);
            // 
            // BaiTapToolStripMenuItem
            // 
            this.BaiTapToolStripMenuItem.Name = "BaiTapToolStripMenuItem";
            this.BaiTapToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.BaiTapToolStripMenuItem.Text = "Bài tập";
            this.BaiTapToolStripMenuItem.Click += new System.EventHandler(this.BaiTapToolStripMenuItem_Click);
            // 
            // LopHocToolStripMenuItem
            // 
            this.LopHocToolStripMenuItem.Name = "LopHocToolStripMenuItem";
            this.LopHocToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.LopHocToolStripMenuItem.Text = "Lớp học";
            this.LopHocToolStripMenuItem.Click += new System.EventHandler(this.lớpToolStripMenuItem_Click);
            // 
            // NopBaiTapToolStripMenuItem
            // 
            this.NopBaiTapToolStripMenuItem.Name = "NopBaiTapToolStripMenuItem";
            this.NopBaiTapToolStripMenuItem.Size = new System.Drawing.Size(82, 30);
            this.NopBaiTapToolStripMenuItem.Text = "Bài tập";
            this.NopBaiTapToolStripMenuItem.Click += new System.EventHandler(this.NopBaiTapToolStripMenuItem_Click);
            // 
            // DangKiLopHocToolStripMenuItem
            // 
            this.DangKiLopHocToolStripMenuItem.Name = "DangKiLopHocToolStripMenuItem";
            this.DangKiLopHocToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.DangKiLopHocToolStripMenuItem.Text = "Đăng ký lớp học";
            this.DangKiLopHocToolStripMenuItem.Click += new System.EventHandler(this.DangKiLopHocToolStripMenuItem_Click);
            // 
            // LopDaDangKyToolStripMenuItem
            // 
            this.LopDaDangKyToolStripMenuItem.Name = "LopDaDangKyToolStripMenuItem";
            this.LopDaDangKyToolStripMenuItem.Size = new System.Drawing.Size(95, 30);
            this.LopDaDangKyToolStripMenuItem.Text = "Lớp Học";
            this.LopDaDangKyToolStripMenuItem.Click += new System.EventHandler(this.LopDaDangKyToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 33);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1719, 495);
            this.pnlContent.TabIndex = 1;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // ChamDiemToolStripMenuItem
            // 
            this.ChamDiemToolStripMenuItem.Name = "ChamDiemToolStripMenuItem";
            this.ChamDiemToolStripMenuItem.Size = new System.Drawing.Size(119, 30);
            this.ChamDiemToolStripMenuItem.Text = "Chấm điểm";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 528);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hocSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BaiTapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LopHocToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripMenuItem NopBaiTapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangKiLopHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LopDaDangKyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChamDiemToolStripMenuItem;
    }
}

