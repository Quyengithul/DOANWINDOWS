
namespace doanwinform.form
{
    partial class sanpham
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
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.dgv_san_pham = new System.Windows.Forms.DataGridView();
            this.cbb_don_vi = new System.Windows.Forms.ComboBox();
            this.cbb_loai = new System.Windows.Forms.ComboBox();
            this.txb_gia_ban = new System.Windows.Forms.TextBox();
            this.txb_so_luong = new System.Windows.Forms.TextBox();
            this.txb_ten_san_pham = new System.Windows.Forms.TextBox();
            this.txb_ma_san_pham = new System.Windows.Forms.TextBox();
            this.lb_don_vi = new System.Windows.Forms.Label();
            this.lb_loai = new System.Windows.Forms.Label();
            this.lb_gia_ban = new System.Windows.Forms.Label();
            this.lb_so_luong = new System.Windows.Forms.Label();
            this.lb_ten_san_pham = new System.Windows.Forms.Label();
            this.lb_ma_san_pham = new System.Windows.Forms.Label();
            this.txb_timkiem = new System.Windows.Forms.TextBox();
            this.cbb_loc_loai_sp = new System.Windows.Forms.ComboBox();
            this.btn_loc = new System.Windows.Forms.Button();
            this.anh_sp = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_chon_anh = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.ma_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.don_vi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_san_pham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh_sp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search.Location = new System.Drawing.Point(705, 45);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(89, 32);
            this.btn_search.TabIndex = 121;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_change.Location = new System.Drawing.Point(17, 457);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(100, 30);
            this.btn_change.TabIndex = 119;
            this.btn_change.Text = "Chỉnh sửa";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // dgv_san_pham
            // 
            this.dgv_san_pham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_san_pham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_sp,
            this.ten_sp,
            this.so_luong,
            this.don_vi,
            this.loai_sp,
            this.gia_ban});
            this.dgv_san_pham.Location = new System.Drawing.Point(369, 87);
            this.dgv_san_pham.Name = "dgv_san_pham";
            this.dgv_san_pham.RowHeadersWidth = 51;
            this.dgv_san_pham.RowTemplate.Height = 24;
            this.dgv_san_pham.Size = new System.Drawing.Size(659, 422);
            this.dgv_san_pham.TabIndex = 118;
            this.dgv_san_pham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_san_pham_CellClick);
            // 
            // cbb_don_vi
            // 
            this.cbb_don_vi.FormattingEnabled = true;
            this.cbb_don_vi.Location = new System.Drawing.Point(144, 341);
            this.cbb_don_vi.Name = "cbb_don_vi";
            this.cbb_don_vi.Size = new System.Drawing.Size(192, 24);
            this.cbb_don_vi.TabIndex = 116;
            // 
            // cbb_loai
            // 
            this.cbb_loai.FormattingEnabled = true;
            this.cbb_loai.Location = new System.Drawing.Point(144, 374);
            this.cbb_loai.Name = "cbb_loai";
            this.cbb_loai.Size = new System.Drawing.Size(192, 24);
            this.cbb_loai.TabIndex = 115;
            // 
            // txb_gia_ban
            // 
            this.txb_gia_ban.Location = new System.Drawing.Point(144, 415);
            this.txb_gia_ban.Name = "txb_gia_ban";
            this.txb_gia_ban.Size = new System.Drawing.Size(192, 22);
            this.txb_gia_ban.TabIndex = 114;
            // 
            // txb_so_luong
            // 
            this.txb_so_luong.ForeColor = System.Drawing.Color.Black;
            this.txb_so_luong.Location = new System.Drawing.Point(144, 303);
            this.txb_so_luong.Name = "txb_so_luong";
            this.txb_so_luong.Size = new System.Drawing.Size(192, 22);
            this.txb_so_luong.TabIndex = 112;
            // 
            // txb_ten_san_pham
            // 
            this.txb_ten_san_pham.Location = new System.Drawing.Point(144, 267);
            this.txb_ten_san_pham.Name = "txb_ten_san_pham";
            this.txb_ten_san_pham.Size = new System.Drawing.Size(192, 22);
            this.txb_ten_san_pham.TabIndex = 111;
            // 
            // txb_ma_san_pham
            // 
            this.txb_ma_san_pham.Location = new System.Drawing.Point(144, 234);
            this.txb_ma_san_pham.Name = "txb_ma_san_pham";
            this.txb_ma_san_pham.Size = new System.Drawing.Size(192, 22);
            this.txb_ma_san_pham.TabIndex = 110;
            // 
            // lb_don_vi
            // 
            this.lb_don_vi.AutoSize = true;
            this.lb_don_vi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_don_vi.Location = new System.Drawing.Point(10, 341);
            this.lb_don_vi.Name = "lb_don_vi";
            this.lb_don_vi.Size = new System.Drawing.Size(56, 20);
            this.lb_don_vi.TabIndex = 109;
            this.lb_don_vi.Text = "Đơn vị";
            // 
            // lb_loai
            // 
            this.lb_loai.AutoSize = true;
            this.lb_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loai.Location = new System.Drawing.Point(13, 374);
            this.lb_loai.Name = "lb_loai";
            this.lb_loai.Size = new System.Drawing.Size(41, 20);
            this.lb_loai.TabIndex = 108;
            this.lb_loai.Text = "Loại";
            // 
            // lb_gia_ban
            // 
            this.lb_gia_ban.AutoSize = true;
            this.lb_gia_ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gia_ban.Location = new System.Drawing.Point(13, 415);
            this.lb_gia_ban.Name = "lb_gia_ban";
            this.lb_gia_ban.Size = new System.Drawing.Size(66, 20);
            this.lb_gia_ban.TabIndex = 107;
            this.lb_gia_ban.Text = "Đơn giá";
            // 
            // lb_so_luong
            // 
            this.lb_so_luong.AutoSize = true;
            this.lb_so_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_so_luong.Location = new System.Drawing.Point(10, 303);
            this.lb_so_luong.Name = "lb_so_luong";
            this.lb_so_luong.Size = new System.Drawing.Size(74, 20);
            this.lb_so_luong.TabIndex = 105;
            this.lb_so_luong.Text = "Số lượng";
            // 
            // lb_ten_san_pham
            // 
            this.lb_ten_san_pham.AutoSize = true;
            this.lb_ten_san_pham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten_san_pham.Location = new System.Drawing.Point(10, 269);
            this.lb_ten_san_pham.Name = "lb_ten_san_pham";
            this.lb_ten_san_pham.Size = new System.Drawing.Size(115, 20);
            this.lb_ten_san_pham.TabIndex = 104;
            this.lb_ten_san_pham.Text = "Tên sản phẩm";
            // 
            // lb_ma_san_pham
            // 
            this.lb_ma_san_pham.AutoSize = true;
            this.lb_ma_san_pham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ma_san_pham.Location = new System.Drawing.Point(10, 236);
            this.lb_ma_san_pham.Name = "lb_ma_san_pham";
            this.lb_ma_san_pham.Size = new System.Drawing.Size(110, 20);
            this.lb_ma_san_pham.TabIndex = 103;
            this.lb_ma_san_pham.Text = "Mã sản phẩm";
            // 
            // txb_timkiem
            // 
            this.txb_timkiem.Location = new System.Drawing.Point(369, 50);
            this.txb_timkiem.Name = "txb_timkiem";
            this.txb_timkiem.Size = new System.Drawing.Size(330, 22);
            this.txb_timkiem.TabIndex = 120;
            this.txb_timkiem.Text = "Tìm kiếm sản phẩm";
            this.txb_timkiem.Click += new System.EventHandler(this.txb_timkiem_Click);
            // 
            // cbb_loc_loai_sp
            // 
            this.cbb_loc_loai_sp.FormattingEnabled = true;
            this.cbb_loc_loai_sp.Location = new System.Drawing.Point(800, 50);
            this.cbb_loc_loai_sp.Name = "cbb_loc_loai_sp";
            this.cbb_loc_loai_sp.Size = new System.Drawing.Size(121, 24);
            this.cbb_loc_loai_sp.TabIndex = 122;
            // 
            // btn_loc
            // 
            this.btn_loc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_loc.Location = new System.Drawing.Point(927, 45);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(82, 32);
            this.btn_loc.TabIndex = 123;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = false;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // anh_sp
            // 
            this.anh_sp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.anh_sp.Location = new System.Drawing.Point(17, 12);
            this.anh_sp.Name = "anh_sp";
            this.anh_sp.Size = new System.Drawing.Size(322, 178);
            this.anh_sp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anh_sp.TabIndex = 117;
            this.anh_sp.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_save.Location = new System.Drawing.Point(239, 457);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 30);
            this.btn_save.TabIndex = 124;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_chon_anh
            // 
            this.btn_chon_anh.Location = new System.Drawing.Point(126, 196);
            this.btn_chon_anh.Name = "btn_chon_anh";
            this.btn_chon_anh.Size = new System.Drawing.Size(114, 23);
            this.btn_chon_anh.TabIndex = 125;
            this.btn_chon_anh.Text = "Tải ảnh lên";
            this.btn_chon_anh.UseVisualStyleBackColor = true;
            this.btn_chon_anh.Click += new System.EventHandler(this.btn_chon_anh_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_delete.Location = new System.Drawing.Point(129, 457);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 30);
            this.btn_delete.TabIndex = 126;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // ma_sp
            // 
            this.ma_sp.DataPropertyName = "MaSP";
            this.ma_sp.HeaderText = "Mã sản phẩm";
            this.ma_sp.MinimumWidth = 6;
            this.ma_sp.Name = "ma_sp";
            this.ma_sp.Width = 60;
            // 
            // ten_sp
            // 
            this.ten_sp.DataPropertyName = "TenSP";
            this.ten_sp.HeaderText = "Tên sản phẩm";
            this.ten_sp.MinimumWidth = 6;
            this.ten_sp.Name = "ten_sp";
            this.ten_sp.Width = 125;
            // 
            // so_luong
            // 
            this.so_luong.DataPropertyName = "SoLuong";
            this.so_luong.HeaderText = "Số lượng";
            this.so_luong.MinimumWidth = 6;
            this.so_luong.Name = "so_luong";
            this.so_luong.Width = 50;
            // 
            // don_vi
            // 
            this.don_vi.DataPropertyName = "Donvi";
            this.don_vi.HeaderText = "Đơn vị";
            this.don_vi.MinimumWidth = 6;
            this.don_vi.Name = "don_vi";
            this.don_vi.Width = 50;
            // 
            // loai_sp
            // 
            this.loai_sp.DataPropertyName = "Loai";
            this.loai_sp.HeaderText = "Loại sản phẩm";
            this.loai_sp.MinimumWidth = 6;
            this.loai_sp.Name = "loai_sp";
            this.loai_sp.Width = 80;
            // 
            // gia_ban
            // 
            this.gia_ban.DataPropertyName = "Dongia";
            this.gia_ban.HeaderText = "Đơn giá";
            this.gia_ban.MinimumWidth = 6;
            this.gia_ban.Name = "gia_ban";
            this.gia_ban.Width = 75;
            // 
            // sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1039, 536);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_chon_anh);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_loc);
            this.Controls.Add(this.cbb_loc_loai_sp);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txb_timkiem);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.dgv_san_pham);
            this.Controls.Add(this.anh_sp);
            this.Controls.Add(this.cbb_don_vi);
            this.Controls.Add(this.cbb_loai);
            this.Controls.Add(this.txb_gia_ban);
            this.Controls.Add(this.txb_so_luong);
            this.Controls.Add(this.txb_ten_san_pham);
            this.Controls.Add(this.txb_ma_san_pham);
            this.Controls.Add(this.lb_don_vi);
            this.Controls.Add(this.lb_loai);
            this.Controls.Add(this.lb_gia_ban);
            this.Controls.Add(this.lb_so_luong);
            this.Controls.Add(this.lb_ten_san_pham);
            this.Controls.Add(this.lb_ma_san_pham);
            this.Name = "sanpham";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_san_pham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh_sp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.DataGridView dgv_san_pham;
        private System.Windows.Forms.PictureBox anh_sp;
        private System.Windows.Forms.ComboBox cbb_don_vi;
        private System.Windows.Forms.ComboBox cbb_loai;
        private System.Windows.Forms.TextBox txb_gia_ban;
        private System.Windows.Forms.TextBox txb_so_luong;
        private System.Windows.Forms.TextBox txb_ten_san_pham;
        private System.Windows.Forms.TextBox txb_ma_san_pham;
        private System.Windows.Forms.Label lb_don_vi;
        private System.Windows.Forms.Label lb_loai;
        private System.Windows.Forms.Label lb_gia_ban;
        private System.Windows.Forms.Label lb_so_luong;
        private System.Windows.Forms.Label lb_ten_san_pham;
        private System.Windows.Forms.Label lb_ma_san_pham;
        private System.Windows.Forms.TextBox txb_timkiem;
        private System.Windows.Forms.ComboBox cbb_loc_loai_sp;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_chon_anh;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn don_vi;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_ban;
    }
}