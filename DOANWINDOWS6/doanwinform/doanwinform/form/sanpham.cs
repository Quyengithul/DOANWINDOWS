using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doanwinform.form
{
    public partial class sanpham : Form
    {
        public sanpham()
        {
            InitializeComponent();
        }

        string strConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=DOAN2;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        SqlCommand cmd = null;
        string filename;
        private void sanpham_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            LoadData();

            txb_ma_san_pham.Enabled = false;
            txb_ten_san_pham.Enabled = false;
            txb_so_luong.Enabled = false;
            txb_gia_ban.Enabled = false;
            cbb_don_vi.Enabled = false;
            cbb_loai.Enabled = false;
            btn_change.Enabled = false;
            btn_delete.Enabled = false;
            btn_save.Enabled = false;
            btn_chon_anh.Hide();
        }
        void LoadData()
        {
            //Load data vào datagirdview
            da = new SqlDataAdapter("Select MaSP,TenSP,SoLuong,Donvi,Loai,Dongia from SANPHAM", conn);
            ds = new DataSet();
            da.Fill(ds, "SANPHAM");
            dgv_san_pham.DataSource = ds.Tables["SANPHAM"];
            dgv_san_pham.AllowUserToAddRows = false;
            //Load data vào combobox loc sp
            da = new SqlDataAdapter("Select distinct Loai from SANPHAM", conn);
            ds = new DataSet();
            da.Fill(ds, "SANPHAM");
            cbb_loc_loai_sp.DataSource = ds.Tables["SANPHAM"];
            cbb_loc_loai_sp.DisplayMember = "Loai";
            cbb_loc_loai_sp.ValueMember = "Loai";
            cbb_loc_loai_sp.Text = "";
            //Load data vào combobox don vi
            da = new SqlDataAdapter("Select distinct Donvi from SANPHAM", conn);
            ds = new DataSet();
            da.Fill(ds, "SANPHAM");
            cbb_don_vi.DataSource = ds.Tables["SANPHAM"];
            cbb_don_vi.DisplayMember = "Donvi";
            cbb_don_vi.ValueMember = "Donvi";
            //Load data vào combobox loai sp
            da = new SqlDataAdapter("Select distinct Loai from SANPHAM", conn);
            ds = new DataSet();
            da.Fill(ds, "SANPHAM");
            cbb_loai.DataSource = ds.Tables["SANPHAM"];
            cbb_loai.DisplayMember = "Loai";

            cbb_loai.ValueMember = "Loai";
            //Tẩy trắng các textbox
            txb_ma_san_pham.Text = "";
            txb_ten_san_pham.Text = "";
            txb_so_luong.Text = "";
            txb_gia_ban.Text = "";
            cbb_don_vi.Text = "";
            cbb_loai.Text = "";
            anh_sp.Image = Properties.Resources.anh_trong;
            btn_change.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void txb_timkiem_Click(object sender, EventArgs e)
        {
            if (txb_timkiem.Text == "Tìm kiếm sản phẩm")
            {
                txb_timkiem.Text = "";
            }
        }

        private void dgv_san_pham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                btn_change.Enabled = true;
                btn_delete.Enabled = true;
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_san_pham.Rows[e.RowIndex];
                txb_ma_san_pham.Text = Convert.ToString(row.Cells["ma_sp"].Value);
                txb_ten_san_pham.Text = Convert.ToString(row.Cells["ten_sp"].Value);
                txb_so_luong.Text = Convert.ToString(row.Cells["so_luong"].Value);
                cbb_don_vi.Text = Convert.ToString(row.Cells["don_vi"].Value);
                cbb_loai.Text = Convert.ToString(row.Cells["loai_sp"].Value);
                txb_gia_ban.Text = Convert.ToString(row.Cells["gia_ban"].Value);

                string sql = @"select linkanh from sanpham where masp='" + txb_ma_san_pham.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string link = dt.Rows[0]["LinkAnh"].ToString();
                Image img = ByteToImg(link);
                anh_sp.Image = img;
                anh_sp.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                txb_ma_san_pham.Text = "";
                txb_ten_san_pham.Text = "";
                txb_so_luong.Text = "";
                txb_gia_ban.Text = "";
                cbb_don_vi.Text = "";
                cbb_loai.Text = "";
                anh_sp.Image = null;
                btn_change.Enabled = false;
                btn_delete.Enabled = false;
            }
        }
      

        private void btn_loc_Click(object sender, EventArgs e)
        {
            txb_ma_san_pham.Text = "";
            txb_ten_san_pham.Text = "";
            txb_so_luong.Text = "";
            txb_gia_ban.Text = "";
            cbb_don_vi.Text = "";
            cbb_loai.Text = "";
            btn_change.Enabled = false;
            btn_delete.Enabled = false;
            btn_save.Enabled = false;
            btn_chon_anh.Hide();
            anh_sp.Image = Properties.Resources.anh_trong;
            //Load data theo bộ lọc
            da = new SqlDataAdapter("Select MaSP,TenSP,SoLuong,Donvi,Loai,Dongia from SANPHAM where loai='" + cbb_loc_loai_sp.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds, "SANPHAM");
            dgv_san_pham.DataSource = ds.Tables["SANPHAM"];
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txb_timkiem.Text == "Tìm kiếm sản phẩm")
            {
                MessageBox.Show("Vui lòng nhập từ khoá tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txb_ma_san_pham.Text = "";
                txb_ten_san_pham.Text = "";
                txb_so_luong.Text = "";
                txb_gia_ban.Text = "";
                cbb_don_vi.Text = "";
                cbb_loai.Text = "";
                btn_change.Enabled = false;
                btn_delete.Enabled = false;
                btn_save.Enabled = false;
                btn_chon_anh.Hide();
                anh_sp.Image = Properties.Resources.anh_trong;

                try
                {
                    da = new SqlDataAdapter("Select MaSP,TenSP,SoLuong,Donvi,Loai,Dongia from SANPHAM where TenSP LIKE N'%" + txb_timkiem.Text + "%' or MaSP LIKE N'%" + txb_timkiem.Text + "%'", conn);
                    ds = new DataSet();
                    da.Fill(ds, "SANPHAM");
                    dgv_san_pham.DataSource = ds.Tables["SANPHAM"];
                }
                catch (Exception)
                {

                }
                if (dgv_san_pham.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (txb_ma_san_pham.Text != "")
            {
                txb_ma_san_pham.Enabled = false;
                txb_ten_san_pham.Enabled = true;
                txb_so_luong.Enabled = true;
                txb_gia_ban.Enabled = true;
                cbb_don_vi.Enabled = true;
                cbb_loai.Enabled = true;
                btn_save.Enabled = true;
                btn_change.Enabled = false;
                btn_chon_anh.Show();//hiện button tải ảnh lên
                txb_ten_san_pham.Focus();//trỏ con trỏ vào vị trí tên
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            txb_ma_san_pham.Enabled = false;
            txb_ten_san_pham.Enabled = false;
            txb_so_luong.Enabled = false;
            txb_gia_ban.Enabled = false;
            cbb_don_vi.Enabled = false;
            cbb_loai.Enabled = false;
            btn_change.Enabled = true;
            btn_save.Enabled = false;
            btn_chon_anh.Hide();
            if (MessageBox.Show("Bạn muốn lưu những thay đổi này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("Sua", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // string maP = (string)dataGridView_PhongBan.CurrentRow.Cells["ma_phong"].Value;
                SqlParameter p = new SqlParameter("@masp", txb_ma_san_pham.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@tensp", txb_ten_san_pham.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@soluong", txb_so_luong.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@donvi", cbb_don_vi.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@dongia", txb_gia_ban.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@loai", cbb_loai.Text);
                cmd.Parameters.Add(p);
                if (filename == null)
                {
                    string sql = @"select linkanh from sanpham where masp='" + txb_ma_san_pham.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    string link = dt.Rows[0]["LinkAnh"].ToString();

                    p = new SqlParameter("@linkanh", link);
                    cmd.Parameters.Add(p);
                }
                else
                {
                    string link = Convert.ToBase64String(converImgToByte());
                    p = new SqlParameter("@linkanh", link);
                    cmd.Parameters.Add(p);
                }    
                int cou = cmd.ExecuteNonQuery();
                if (cou > 0)
                {
                    MessageBox.Show("Cập nhật thành công gòi nhá");
                    LoadData();
                }

                anh_sp.Image = Properties.Resources.anh_trong;
            }
        }
        private void btn_chon_anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //string fileName;
                filename = dlg.FileName;
                anh_sp.Image = Image.FromFile(filename);
                anh_sp.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá sản phẩm này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("Xoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@masp", txb_ma_san_pham.Text);
                cmd.Parameters.Add(p);
                int cou = cmd.ExecuteNonQuery();
                if (cou > 0)
                {
                    MessageBox.Show("Xoá thành công gòi nhá");
                    LoadData();

                }
            }
        }
        //Chuyển Byte từ database trở lại ảnh
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        //Chuyển ảnh thành dạng byte vào database
        private byte[] converImgToByte()
        {
            FileStream fs;
            fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }


    }
}
