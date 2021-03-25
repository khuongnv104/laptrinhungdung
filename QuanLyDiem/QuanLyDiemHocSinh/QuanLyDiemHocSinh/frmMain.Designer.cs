
namespace QuanLyDiemHocSinh
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.stripHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.stripTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpDanhmuc = new System.Windows.Forms.GroupBox();
            this.btnQuanLyLop = new System.Windows.Forms.Button();
            this.btnQuanLyGiaoVien = new System.Windows.Forms.Button();
            this.btnQuanLyHocSinh = new System.Windows.Forms.Button();
            this.gridContent = new System.Windows.Forms.DataGridView();
            this.stripDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.stripDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.stripDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.stripTheoLop = new System.Windows.Forms.ToolStripMenuItem();
            this.stripTheoHS = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuanLyDiem = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.grpDanhmuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContent)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripHeThong,
            this.stripTimKiem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1271, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // stripHeThong
            // 
            this.stripHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripDangNhap,
            this.stripDoiMK,
            this.stripDangXuat});
            this.stripHeThong.Name = "stripHeThong";
            this.stripHeThong.Size = new System.Drawing.Size(69, 20);
            this.stripHeThong.Text = "Hệ thống";
            // 
            // stripTimKiem
            // 
            this.stripTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripTheoLop,
            this.stripTheoHS});
            this.stripTimKiem.Name = "stripTimKiem";
            this.stripTimKiem.Size = new System.Drawing.Size(68, 20);
            this.stripTimKiem.Text = "Tìm kiếm";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1271, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 563);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1271, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // grpDanhmuc
            // 
            this.grpDanhmuc.Controls.Add(this.btnQuanLyDiem);
            this.grpDanhmuc.Controls.Add(this.btnQuanLyLop);
            this.grpDanhmuc.Controls.Add(this.btnQuanLyGiaoVien);
            this.grpDanhmuc.Controls.Add(this.btnQuanLyHocSinh);
            this.grpDanhmuc.Location = new System.Drawing.Point(0, 52);
            this.grpDanhmuc.Name = "grpDanhmuc";
            this.grpDanhmuc.Size = new System.Drawing.Size(200, 508);
            this.grpDanhmuc.TabIndex = 4;
            this.grpDanhmuc.TabStop = false;
            this.grpDanhmuc.Text = "Danh mục";
            // 
            // btnQuanLyLop
            // 
            this.btnQuanLyLop.Location = new System.Drawing.Point(12, 182);
            this.btnQuanLyLop.Name = "btnQuanLyLop";
            this.btnQuanLyLop.Size = new System.Drawing.Size(151, 74);
            this.btnQuanLyLop.TabIndex = 6;
            this.btnQuanLyLop.Text = "Quản Lý Lớp";
            this.btnQuanLyLop.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyGiaoVien
            // 
            this.btnQuanLyGiaoVien.Location = new System.Drawing.Point(12, 106);
            this.btnQuanLyGiaoVien.Name = "btnQuanLyGiaoVien";
            this.btnQuanLyGiaoVien.Size = new System.Drawing.Size(151, 70);
            this.btnQuanLyGiaoVien.TabIndex = 6;
            this.btnQuanLyGiaoVien.Text = "Quản Lý Giáo Viên";
            this.btnQuanLyGiaoVien.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyHocSinh
            // 
            this.btnQuanLyHocSinh.Location = new System.Drawing.Point(12, 34);
            this.btnQuanLyHocSinh.Name = "btnQuanLyHocSinh";
            this.btnQuanLyHocSinh.Size = new System.Drawing.Size(151, 66);
            this.btnQuanLyHocSinh.TabIndex = 6;
            this.btnQuanLyHocSinh.Text = "Quản Lý Học Sinh";
            this.btnQuanLyHocSinh.UseVisualStyleBackColor = true;
            // 
            // gridContent
            // 
            this.gridContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContent.Location = new System.Drawing.Point(331, 103);
            this.gridContent.Name = "gridContent";
            this.gridContent.Size = new System.Drawing.Size(796, 378);
            this.gridContent.TabIndex = 5;
            // 
            // stripDangNhap
            // 
            this.stripDangNhap.Name = "stripDangNhap";
            this.stripDangNhap.Size = new System.Drawing.Size(180, 22);
            this.stripDangNhap.Text = "Đăng Nhập";
            // 
            // stripDoiMK
            // 
            this.stripDoiMK.Name = "stripDoiMK";
            this.stripDoiMK.Size = new System.Drawing.Size(180, 22);
            this.stripDoiMK.Text = "Đổi Mật Khẩu";
            // 
            // stripDangXuat
            // 
            this.stripDangXuat.Name = "stripDangXuat";
            this.stripDangXuat.Size = new System.Drawing.Size(180, 22);
            this.stripDangXuat.Text = "Đăng Xuất";
            // 
            // stripTheoLop
            // 
            this.stripTheoLop.Name = "stripTheoLop";
            this.stripTheoLop.Size = new System.Drawing.Size(180, 22);
            this.stripTheoLop.Text = "Tìm kiếm theo lớp";
            // 
            // stripTheoHS
            // 
            this.stripTheoHS.Name = "stripTheoHS";
            this.stripTheoHS.Size = new System.Drawing.Size(180, 22);
            this.stripTheoHS.Text = "Tìm kiếm học sinh";
            // 
            // btnQuanLyDiem
            // 
            this.btnQuanLyDiem.Location = new System.Drawing.Point(12, 262);
            this.btnQuanLyDiem.Name = "btnQuanLyDiem";
            this.btnQuanLyDiem.Size = new System.Drawing.Size(151, 72);
            this.btnQuanLyDiem.TabIndex = 7;
            this.btnQuanLyDiem.Text = "Quản Lý Điểm";
            this.btnQuanLyDiem.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 585);
            this.Controls.Add(this.gridContent);
            this.Controls.Add(this.grpDanhmuc);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "Quản Lý Học Sinh";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.grpDanhmuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem stripHeThong;
        private System.Windows.Forms.ToolStripMenuItem stripTimKiem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpDanhmuc;
        private System.Windows.Forms.Button btnQuanLyLop;
        private System.Windows.Forms.Button btnQuanLyGiaoVien;
        private System.Windows.Forms.Button btnQuanLyHocSinh;
        private System.Windows.Forms.DataGridView gridContent;
        private System.Windows.Forms.ToolStripMenuItem stripDangNhap;
        private System.Windows.Forms.ToolStripMenuItem stripDoiMK;
        private System.Windows.Forms.ToolStripMenuItem stripDangXuat;
        private System.Windows.Forms.ToolStripMenuItem stripTheoLop;
        private System.Windows.Forms.ToolStripMenuItem stripTheoHS;
        private System.Windows.Forms.Button btnQuanLyDiem;
    }
}



