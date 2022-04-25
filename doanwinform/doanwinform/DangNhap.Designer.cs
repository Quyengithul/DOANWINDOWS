
namespace doanwinform
{
    partial class DangNhap
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
            this.lb_dang_ky = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_dang_nhap = new System.Windows.Forms.Button();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_tieu_de = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_dang_ky
            // 
            this.lb_dang_ky.AutoSize = true;
            this.lb_dang_ky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_dang_ky.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dang_ky.ForeColor = System.Drawing.Color.Blue;
            this.lb_dang_ky.Location = new System.Drawing.Point(227, 263);
            this.lb_dang_ky.Name = "lb_dang_ky";
            this.lb_dang_ky.Size = new System.Drawing.Size(69, 18);
            this.lb_dang_ky.TabIndex = 24;
            this.lb_dang_ky.Text = "Đăng ký";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 30);
            this.label4.TabIndex = 23;
            this.label4.Text = "Bạn chưa có tài khoản? ";
            // 
            // btn_dang_nhap
            // 
            this.btn_dang_nhap.Location = new System.Drawing.Point(49, 205);
            this.btn_dang_nhap.Name = "btn_dang_nhap";
            this.btn_dang_nhap.Size = new System.Drawing.Size(255, 38);
            this.btn_dang_nhap.TabIndex = 22;
            this.btn_dang_nhap.Text = "Đăng nhập";
            this.btn_dang_nhap.UseVisualStyleBackColor = true;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(139, 161);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(165, 22);
            this.txb_password.TabIndex = 21;
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(139, 114);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(165, 22);
            this.txb_username.TabIndex = 20;
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.Location = new System.Drawing.Point(46, 162);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(77, 20);
            this.lb_pass.TabIndex = 19;
            this.lb_pass.Text = "Mật khẩu";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(46, 114);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(86, 20);
            this.lb_username.TabIndex = 18;
            this.lb_username.Text = "Username";
            // 
            // lb_tieu_de
            // 
            this.lb_tieu_de.Font = new System.Drawing.Font("TeamViewer15", 23.4F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_tieu_de.Location = new System.Drawing.Point(87, 36);
            this.lb_tieu_de.Name = "lb_tieu_de";
            this.lb_tieu_de.Size = new System.Drawing.Size(213, 69);
            this.lb_tieu_de.TabIndex = 17;
            this.lb_tieu_de.Text = "Đăng nhập";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 331);
            this.Controls.Add(this.lb_dang_ky);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_dang_nhap);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_tieu_de);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_dang_ky;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_dang_nhap;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_tieu_de;
    }
}