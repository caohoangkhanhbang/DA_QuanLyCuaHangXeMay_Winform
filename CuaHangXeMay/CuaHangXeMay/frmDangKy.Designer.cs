namespace CuaHangXeMay
{
    partial class frmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKy));
            this.exit = new System.Windows.Forms.PictureBox();
            this.minisize = new System.Windows.Forms.PictureBox();
            this.btn_dangKy = new CuaHangXeMay.KhanhBangButton();
            this.link_coTaiKhoan = new System.Windows.Forms.LinkLabel();
            this.checkBox_AnHienMatKhau = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new CustomControls.RJControls.RJTextBox();
            this.txt_xacNhanMatKhau = new CustomControls.RJControls.RJTextBox();
            this.txt_matKhau = new CustomControls.RJControls.RJTextBox();
            this.txt_tenDangNhap = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minisize)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(800, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 32);
            this.exit.TabIndex = 31;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // minisize
            // 
            this.minisize.BackColor = System.Drawing.Color.Transparent;
            this.minisize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minisize.BackgroundImage")));
            this.minisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minisize.Location = new System.Drawing.Point(762, 2);
            this.minisize.Name = "minisize";
            this.minisize.Size = new System.Drawing.Size(32, 32);
            this.minisize.TabIndex = 30;
            this.minisize.TabStop = false;
            this.minisize.Click += new System.EventHandler(this.minisize_Click);
            // 
            // btn_dangKy
            // 
            this.btn_dangKy.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_dangKy.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_dangKy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_dangKy.BorderRadius = 0;
            this.btn_dangKy.BorderSize = 0;
            this.btn_dangKy.FlatAppearance.BorderSize = 0;
            this.btn_dangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangKy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangKy.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_dangKy.Location = new System.Drawing.Point(611, 387);
            this.btn_dangKy.Name = "btn_dangKy";
            this.btn_dangKy.Size = new System.Drawing.Size(167, 40);
            this.btn_dangKy.TabIndex = 4;
            this.btn_dangKy.Text = "Đăng ký";
            this.btn_dangKy.TextColor = System.Drawing.SystemColors.Info;
            this.btn_dangKy.UseVisualStyleBackColor = false;
            this.btn_dangKy.Click += new System.EventHandler(this.btn_dangKy_Click);
            // 
            // link_coTaiKhoan
            // 
            this.link_coTaiKhoan.AutoSize = true;
            this.link_coTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.link_coTaiKhoan.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_coTaiKhoan.LinkColor = System.Drawing.SystemColors.Info;
            this.link_coTaiKhoan.Location = new System.Drawing.Point(629, 358);
            this.link_coTaiKhoan.Name = "link_coTaiKhoan";
            this.link_coTaiKhoan.Size = new System.Drawing.Size(127, 20);
            this.link_coTaiKhoan.TabIndex = 5;
            this.link_coTaiKhoan.TabStop = true;
            this.link_coTaiKhoan.Text = "Đã có tài khoản?";
            this.link_coTaiKhoan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_coTaiKhoan_LinkClicked);
            // 
            // checkBox_AnHienMatKhau
            // 
            this.checkBox_AnHienMatKhau.AutoSize = true;
            this.checkBox_AnHienMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_AnHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_AnHienMatKhau.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBox_AnHienMatKhau.Location = new System.Drawing.Point(708, 162);
            this.checkBox_AnHienMatKhau.Name = "checkBox_AnHienMatKhau";
            this.checkBox_AnHienMatKhau.Size = new System.Drawing.Size(130, 24);
            this.checkBox_AnHienMatKhau.TabIndex = 28;
            this.checkBox_AnHienMatKhau.Text = "Hiện mật khẩu";
            this.checkBox_AnHienMatKhau.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(565, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(565, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(565, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mật khẩu";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Info;
            this.txt_email.BorderColor = System.Drawing.Color.Transparent;
            this.txt_email.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_email.BorderSize = 0;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.DimGray;
            this.txt_email.Location = new System.Drawing.Point(569, 309);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Padding = new System.Windows.Forms.Padding(7);
            this.txt_email.PasswordChar = false;
            this.txt_email.Size = new System.Drawing.Size(263, 31);
            this.txt_email.TabIndex = 3;
            this.txt_email.Texts = "";
            this.txt_email.UnderlinedStyle = false;
            // 
            // txt_xacNhanMatKhau
            // 
            this.txt_xacNhanMatKhau.BackColor = System.Drawing.SystemColors.Info;
            this.txt_xacNhanMatKhau.BorderColor = System.Drawing.Color.Transparent;
            this.txt_xacNhanMatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_xacNhanMatKhau.BorderSize = 0;
            this.txt_xacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xacNhanMatKhau.ForeColor = System.Drawing.Color.DimGray;
            this.txt_xacNhanMatKhau.Location = new System.Drawing.Point(569, 249);
            this.txt_xacNhanMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_xacNhanMatKhau.Multiline = false;
            this.txt_xacNhanMatKhau.Name = "txt_xacNhanMatKhau";
            this.txt_xacNhanMatKhau.Padding = new System.Windows.Forms.Padding(7);
            this.txt_xacNhanMatKhau.PasswordChar = false;
            this.txt_xacNhanMatKhau.Size = new System.Drawing.Size(263, 31);
            this.txt_xacNhanMatKhau.TabIndex = 2;
            this.txt_xacNhanMatKhau.Texts = "";
            this.txt_xacNhanMatKhau.UnderlinedStyle = false;
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.BackColor = System.Drawing.SystemColors.Info;
            this.txt_matKhau.BorderColor = System.Drawing.Color.Transparent;
            this.txt_matKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_matKhau.BorderSize = 0;
            this.txt_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matKhau.ForeColor = System.Drawing.Color.DimGray;
            this.txt_matKhau.Location = new System.Drawing.Point(569, 186);
            this.txt_matKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matKhau.Multiline = false;
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Padding = new System.Windows.Forms.Padding(7);
            this.txt_matKhau.PasswordChar = false;
            this.txt_matKhau.Size = new System.Drawing.Size(263, 31);
            this.txt_matKhau.TabIndex = 1;
            this.txt_matKhau.Texts = "";
            this.txt_matKhau.UnderlinedStyle = false;
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.BackColor = System.Drawing.SystemColors.Info;
            this.txt_tenDangNhap.BorderColor = System.Drawing.Color.Transparent;
            this.txt_tenDangNhap.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_tenDangNhap.BorderSize = 0;
            this.txt_tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenDangNhap.ForeColor = System.Drawing.Color.DimGray;
            this.txt_tenDangNhap.Location = new System.Drawing.Point(569, 122);
            this.txt_tenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenDangNhap.Multiline = false;
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Padding = new System.Windows.Forms.Padding(7);
            this.txt_tenDangNhap.PasswordChar = false;
            this.txt_tenDangNhap.Size = new System.Drawing.Size(263, 31);
            this.txt_tenDangNhap.TabIndex = 0;
            this.txt_tenDangNhap.Texts = "";
            this.txt_tenDangNhap.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(565, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(637, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "Đăng ký";
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.minisize);
            this.Controls.Add(this.btn_dangKy);
            this.Controls.Add(this.link_coTaiKhoan);
            this.Controls.Add(this.checkBox_AnHienMatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_xacNhanMatKhau);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.txt_tenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangKy";
            this.TransparencyKey = System.Drawing.Color.White;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDangKy_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDangKy_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmDangKy_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minisize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox minisize;
        private KhanhBangButton btn_dangKy;
        private System.Windows.Forms.LinkLabel link_coTaiKhoan;
        private System.Windows.Forms.CheckBox checkBox_AnHienMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txt_email;
        private CustomControls.RJControls.RJTextBox txt_xacNhanMatKhau;
        private CustomControls.RJControls.RJTextBox txt_matKhau;
        private CustomControls.RJControls.RJTextBox txt_tenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}