
namespace doanwinform.form
{
    partial class donhang
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
            this.dgv_Infor = new System.Windows.Forms.DataGridView();
            this.MaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuatDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Infor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Infor
            // 
            this.dgv_Infor.AllowUserToAddRows = false;
            this.dgv_Infor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Infor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Infor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonHang,
            this.MaKhachHang,
            this.HoTen,
            this.NgayXuatDon,
            this.TongTienThanhToan});
            this.dgv_Infor.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_Infor.Location = new System.Drawing.Point(22, 100);
            this.dgv_Infor.Name = "dgv_Infor";
            this.dgv_Infor.RowHeadersVisible = false;
            this.dgv_Infor.RowHeadersWidth = 62;
            this.dgv_Infor.RowTemplate.Height = 28;
            this.dgv_Infor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Infor.Size = new System.Drawing.Size(1125, 525);
            this.dgv_Infor.TabIndex = 12;
            // 
            // MaDonHang
            // 
            this.MaDonHang.HeaderText = "Mã đơn hàng";
            this.MaDonHang.MinimumWidth = 8;
            this.MaDonHang.Name = "MaDonHang";
            this.MaDonHang.Width = 150;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.HeaderText = "Mã khách hàng";
            this.MaKhachHang.MinimumWidth = 8;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // NgayXuatDon
            // 
            this.NgayXuatDon.HeaderText = "Ngày xuất đơn";
            this.NgayXuatDon.MinimumWidth = 8;
            this.NgayXuatDon.Name = "NgayXuatDon";
            this.NgayXuatDon.Width = 150;
            // 
            // TongTienThanhToan
            // 
            this.TongTienThanhToan.HeaderText = "Tổng tiền thanh toán";
            this.TongTienThanhToan.MinimumWidth = 8;
            this.TongTienThanhToan.Name = "TongTienThanhToan";
            this.TongTienThanhToan.Width = 150;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.Silver;
            this.txt_Search.Location = new System.Drawing.Point(22, 22);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(582, 32);
            this.txt_Search.TabIndex = 9;
            this.txt_Search.Text = "Nhập mã đơn hàng hoặc thông tin khách hàng (mã khách hàng, họ tên)";
            this.txt_Search.Enter += new System.EventHandler(this.txt_Search_Enter);
            this.txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave);
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reload.Image = global::doanwinform.Properties.Resources.ReloadIcon;
            this.btn_Reload.Location = new System.Drawing.Point(652, 22);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(36, 32);
            this.btn_Reload.TabIndex = 11;
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Image = global::doanwinform.Properties.Resources.SearchIcon;
            this.btn_Search.Location = new System.Drawing.Point(610, 22);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(36, 32);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // donhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.dgv_Infor);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "donhang";
            this.Text = "Đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Infor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Infor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuatDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienThanhToan;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
    }
}