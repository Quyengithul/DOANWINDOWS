using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace doanwinform.form
{
    public partial class donhang : Form
    {
        public donhang()
        {
            InitializeComponent();
        }

        string strConnectionSrting = "Data Source=.\\SQLEXPRESS;Initial Catalog=DOAN2;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        void TimKiem(string str)
        {
            if (dgv_Infor.Rows.Count > 0)
            {
                dgv_Infor.DataSource = (dgv_Infor.DataSource as DataTable).Clone();
            }
            da = null;
            da = new SqlDataAdapter("Select MaHD, KHACHHANG.MaKh, TenKh, TimeHD, TongTienTT From HOADON join KHACHHANG on HOADON.MaKh = KHACHHANG.MaKh Where MaHD Like '%" + str + "%' or KHACHHANG.MaKh Like '%" + str + "%' or TenKh Like N'%" + @str + "%'", conn);
            dt = new DataTable();
            da.Fill(dt);
            dgv_Infor.DataSource = dt;
            if (dgv_Infor.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Search_Enter(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Nhập mã đơn hàng hoặc thông tin khách hàng (mã khách hàng, họ tên)")
            {
                txt_Search.Text = "";
                txt_Search.ForeColor = Color.Black;
                txt_Search.Font = new Font(txt_Search.Font, FontStyle.Regular);
            }
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
            {
                txt_Search.Text = "Nhập mã đơn hàng hoặc thông tin khách hàng (mã khách hàng, họ tên)";
                txt_Search.ForeColor = Color.Silver;
                txt_Search.Font = new Font(txt_Search.Font, FontStyle.Italic);
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "Nhập mã đơn hàng hoặc thông tin khách hàng (mã khách hàng, họ tên)";
            txt_Search.ForeColor = Color.Silver;
            txt_Search.Font = new Font(txt_Search.Font, FontStyle.Italic);
            dgv_Infor.DataSource = (dgv_Infor.DataSource as DataTable).Clone();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Nhập mã đơn hàng hoặc thông tin khách hàng (mã khách hàng, họ tên)" || txt_Search.Text == "")
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn = new SqlConnection(strConnectionSrting);
                conn.Open();
                TimKiem(txt_Search.Text);
                conn.Close();
            }
        }
    }
}
