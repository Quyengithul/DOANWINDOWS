
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
            this.txb_timkiem = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.dgv_san_pham = new System.Windows.Forms.DataGridView();
            this.ma_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.don_vi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anh_sp = new System.Windows.Forms.PictureBox();
            this.cbb_don_vi = new System.Windows.Forms.ComboBox();
            this.cbb_loai = new System.Windows.Forms.ComboBox();
            this.txb_gia_ban = new System.Windows.Forms.TextBox();
            this.txb_gia_nhap = new System.Windows.Forms.TextBox();
            this.txb_so_luong = new System.Windows.Forms.TextBox();
            this.txb_ten_san_pham = new System.Windows.Forms.TextBox();
            this.txb_ma_san_pham = new System.Windows.Forms.TextBox();
            this.lb_don_vi = new System.Windows.Forms.Label();
            this.lb_loai = new System.Windows.Forms.Label();
            this.lb_gia_ban = new System.Windows.Forms.Label();
            this.lb_gia_nhap = new System.Windows.Forms.Label();
            this.lb_so_luong = new System.Windows.Forms.Label();
            this.lb_ten_san_pham = new System.Windows.Forms.Label();
            this.lb_ma_san_pham = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_san_pham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh_sp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search.Location = new System.Drawing.Point(769, 45);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(89, 32);
            this.btn_search.TabIndex = 121;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // txb_timkiem
            // 
            this.txb_timkiem.Location = new System.Drawing.Point(369, 50);
            this.txb_timkiem.Name = "txb_timkiem";
            this.txb_timkiem.Size = new System.Drawing.Size(378, 22);
            this.txb_timkiem.TabIndex = 120;
            this.txb_timkiem.Text = "Tìm kiếm sản phẩm";
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_change.Location = new System.Drawing.Point(99, 477);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(124, 32);
            this.btn_change.TabIndex = 119;
            this.btn_change.Text = "Chỉnh sửa";
            this.btn_change.UseVisualStyleBackColor = false;
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
            this.gia_nhap,
            this.gia_ban});
            this.dgv_san_pham.Location = new System.Drawing.Point(369, 87);
            this.dgv_san_pham.Name = "dgv_san_pham";
            this.dgv_san_pham.RowHeadersWidth = 51;
            this.dgv_san_pham.RowTemplate.Height = 24;
            this.dgv_san_pham.Size = new System.Drawing.Size(659, 422);
            this.dgv_san_pham.TabIndex = 118;
            // 
            // ma_sp
            // 
            this.ma_sp.HeaderText = "Mã sản phẩm";
            this.ma_sp.MinimumWidth = 6;
            this.ma_sp.Name = "ma_sp";
            this.ma_sp.Width = 125;
            // 
            // ten_sp
            // 
            this.ten_sp.HeaderText = "Tên sản phẩm";
            this.ten_sp.MinimumWidth = 6;
            this.ten_sp.Name = "ten_sp";
            this.ten_sp.Width = 125;
            // 
            // so_luong
            // 
            this.so_luong.HeaderText = "Số lượng";
            this.so_luong.MinimumWidth = 6;
            this.so_luong.Name = "so_luong";
            this.so_luong.Width = 125;
            // 
            // don_vi
            // 
            this.don_vi.HeaderText = "Đơn vị";
            this.don_vi.MinimumWidth = 6;
            this.don_vi.Name = "don_vi";
            this.don_vi.Width = 125;
            // 
            // loai_sp
            // 
            this.loai_sp.HeaderText = "Loại sản phẩm";
            this.loai_sp.MinimumWidth = 6;
            this.loai_sp.Name = "loai_sp";
            this.loai_sp.Width = 125;
            // 
            // gia_nhap
            // 
            this.gia_nhap.HeaderText = "Giá nhập";
            this.gia_nhap.MinimumWidth = 6;
            this.gia_nhap.Name = "gia_nhap";
            this.gia_nhap.Width = 125;
            // 
            // gia_ban
            // 
            this.gia_ban.HeaderText = "Giá bán";
            this.gia_ban.MinimumWidth = 6;
            this.gia_ban.Name = "gia_ban";
            this.gia_ban.Width = 125;
            // 
            // anh_sp
            // 
            this.anh_sp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.anh_sp.Location = new System.Drawing.Point(17, 12);
            this.anh_sp.Name = "anh_sp";
            this.anh_sp.Size = new System.Drawing.Size(322, 206);
            this.anh_sp.TabIndex = 117;
            this.anh_sp.TabStop = false;
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
            this.txb_gia_ban.Location = new System.Drawing.Point(144, 446);
            this.txb_gia_ban.Name = "txb_gia_ban";
            this.txb_gia_ban.Size = new System.Drawing.Size(192, 22);
            this.txb_gia_ban.TabIndex = 114;
            // 
            // txb_gia_nhap
            // 
            this.txb_gia_nhap.Location = new System.Drawing.Point(144, 406);
            this.txb_gia_nhap.Name = "txb_gia_nhap";
            this.txb_gia_nhap.Size = new System.Drawing.Size(192, 22);
            this.txb_gia_nhap.TabIndex = 113;
            // 
            // txb_so_luong
            // 
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
            this.lb_gia_ban.Location = new System.Drawing.Point(13, 446);
            this.lb_gia_ban.Name = "lb_gia_ban";
            this.lb_gia_ban.Size = new System.Drawing.Size(67, 20);
            this.lb_gia_ban.TabIndex = 107;
            this.lb_gia_ban.Text = "Giá bán";
            // 
            // lb_gia_nhap
            // 
            this.lb_gia_nhap.AutoSize = true;
            this.lb_gia_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gia_nhap.Location = new System.Drawing.Point(13, 406);
            this.lb_gia_nhap.Name = "lb_gia_nhap";
            this.lb_gia_nhap.Size = new System.Drawing.Size(76, 20);
            this.lb_gia_nhap.TabIndex = 106;
            this.lb_gia_nhap.Text = "Giá nhập";
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
            // sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1039, 536);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txb_timkiem);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.dgv_san_pham);
            this.Controls.Add(this.anh_sp);
            this.Controls.Add(this.cbb_don_vi);
            this.Controls.Add(this.cbb_loai);
            this.Controls.Add(this.txb_gia_ban);
            this.Controls.Add(this.txb_gia_nhap);
            this.Controls.Add(this.txb_so_luong);
            this.Controls.Add(this.txb_ten_san_pham);
            this.Controls.Add(this.txb_ma_san_pham);
            this.Controls.Add(this.lb_don_vi);
            this.Controls.Add(this.lb_loai);
            this.Controls.Add(this.lb_gia_ban);
            this.Controls.Add(this.lb_gia_nhap);
            this.Controls.Add(this.lb_so_luong);
            this.Controls.Add(this.lb_ten_san_pham);
            this.Controls.Add(this.lb_ma_san_pham);
            this.Name = "sanpham";
            this.Text = "Sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_san_pham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh_sp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txb_timkiem;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.DataGridView dgv_san_pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn don_vi;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_ban;
        private System.Windows.Forms.PictureBox anh_sp;
        private System.Windows.Forms.ComboBox cbb_don_vi;
        private System.Windows.Forms.ComboBox cbb_loai;
        private System.Windows.Forms.TextBox txb_gia_ban;
        private System.Windows.Forms.TextBox txb_gia_nhap;
        private System.Windows.Forms.TextBox txb_so_luong;
        private System.Windows.Forms.TextBox txb_ten_san_pham;
        private System.Windows.Forms.TextBox txb_ma_san_pham;
        private System.Windows.Forms.Label lb_don_vi;
        private System.Windows.Forms.Label lb_loai;
        private System.Windows.Forms.Label lb_gia_ban;
        private System.Windows.Forms.Label lb_gia_nhap;
        private System.Windows.Forms.Label lb_so_luong;
        private System.Windows.Forms.Label lb_ten_san_pham;
        private System.Windows.Forms.Label lb_ma_san_pham;
    }
}