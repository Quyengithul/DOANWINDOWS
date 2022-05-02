using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doanwinform.form
{
    public partial class donhang : Form
    {
        public donhang()
        {
            InitializeComponent();
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
            dgv_Infor.Rows.Clear();
        }
    }
}
