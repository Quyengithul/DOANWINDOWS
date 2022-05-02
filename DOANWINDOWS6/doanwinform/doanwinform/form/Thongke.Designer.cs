
namespace doanwinform.form
{
    partial class Thongke
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
            this.btn_doanh_thu = new System.Windows.Forms.Button();
            this.btn_doanh_thu_thang = new System.Windows.Forms.Button();
            this.btn_doanh_thu_nam = new System.Windows.Forms.Button();
            this.panel_thongke = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_doanh_thu
            // 
            this.btn_doanh_thu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_doanh_thu.Location = new System.Drawing.Point(45, 43);
            this.btn_doanh_thu.Name = "btn_doanh_thu";
            this.btn_doanh_thu.Size = new System.Drawing.Size(192, 35);
            this.btn_doanh_thu.TabIndex = 0;
            this.btn_doanh_thu.Text = "Doanh thu";
            this.btn_doanh_thu.UseVisualStyleBackColor = false;
            // 
            // btn_doanh_thu_thang
            // 
            this.btn_doanh_thu_thang.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_doanh_thu_thang.Location = new System.Drawing.Point(273, 43);
            this.btn_doanh_thu_thang.Name = "btn_doanh_thu_thang";
            this.btn_doanh_thu_thang.Size = new System.Drawing.Size(192, 35);
            this.btn_doanh_thu_thang.TabIndex = 1;
            this.btn_doanh_thu_thang.Text = "Doanh thu theo tháng";
            this.btn_doanh_thu_thang.UseVisualStyleBackColor = false;
            // 
            // btn_doanh_thu_nam
            // 
            this.btn_doanh_thu_nam.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_doanh_thu_nam.Location = new System.Drawing.Point(503, 43);
            this.btn_doanh_thu_nam.Name = "btn_doanh_thu_nam";
            this.btn_doanh_thu_nam.Size = new System.Drawing.Size(192, 35);
            this.btn_doanh_thu_nam.TabIndex = 2;
            this.btn_doanh_thu_nam.Text = "Doanh thu theo năm";
            this.btn_doanh_thu_nam.UseVisualStyleBackColor = false;
            // 
            // panel_thongke
            // 
            this.panel_thongke.BackColor = System.Drawing.Color.SkyBlue;
            this.panel_thongke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_thongke.Location = new System.Drawing.Point(45, 97);
            this.panel_thongke.Name = "panel_thongke";
            this.panel_thongke.Size = new System.Drawing.Size(953, 394);
            this.panel_thongke.TabIndex = 3;
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1039, 536);
            this.Controls.Add(this.panel_thongke);
            this.Controls.Add(this.btn_doanh_thu_nam);
            this.Controls.Add(this.btn_doanh_thu_thang);
            this.Controls.Add(this.btn_doanh_thu);
            this.Name = "Thongke";
            this.Text = "Thống kê";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_doanh_thu;
        private System.Windows.Forms.Button btn_doanh_thu_thang;
        private System.Windows.Forms.Button btn_doanh_thu_nam;
        private System.Windows.Forms.Panel panel_thongke;
    }
}