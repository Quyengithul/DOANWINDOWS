using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doanwinform
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent(); 
            random = new Random();
        }
        private Color SelectThemeColor()
        {
            int Index = random.Next(Themecolor.ColorList.Count);
            while (tempIndex == Index)
            {
                random.Next(Themecolor.ColorList.Count);

            }
            tempIndex = Index;
            string color = Themecolor.ColorList[Index];
            return ColorTranslator.FromHtml(color);

        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    panellogo.BackColor = Themecolor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.paneltrangchu.Controls.Add(childForm);
            this.paneltrangchu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.trangchu(), sender);
        }

        private void btn_Donhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.donhang(), sender);
        }

        private void btn_Nhapkho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.Nhapkho(), sender);
        }

        private void btn_tonkho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.Tonkho(), sender);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.Thongke(), sender);
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.donhang(), sender);
        }
    }
}
