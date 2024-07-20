namespace CuaHangXeMay
{
    partial class frmQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuenMatKhau));
            this.exit = new System.Windows.Forms.PictureBox();
            this.minisize = new System.Windows.Forms.PictureBox();
            this.btn_datLaiMatKhau = new CuaHangXeMay.KhanhBangButton();
            this.link_dangKy = new System.Windows.Forms.LinkLabel();
            this.link_quenEmail = new System.Windows.Forms.LinkLabel();
            this.checkBox_AnHienMatKhau = new System.Windows.Forms.CheckBox();
            this.txt_email = new CustomControls.RJControls.RJTextBox();
            this.l = new System.Windows.Forms.Label();
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
            this.exit.Location = new System.Drawing.Point(663, -1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 32);
            this.exit.TabIndex = 17;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // minisize
            // 
            this.minisize.BackColor = System.Drawing.Color.Transparent;
            this.minisize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minisize.BackgroundImage")));
            this.minisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minisize.Location = new System.Drawing.Point(625, -1);
            this.minisize.Name = "minisize";
            this.minisize.Size = new System.Drawing.Size(32, 32);
            this.minisize.TabIndex = 16;
            this.minisize.TabStop = false;
            this.minisize.Click += new System.EventHandler(this.minisize_Click);
            // 
            // btn_datLaiMatKhau
            // 
            this.btn_datLaiMatKhau.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_datLaiMatKhau.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_datLaiMatKhau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_datLaiMatKhau.BorderRadius = 0;
            this.btn_datLaiMatKhau.BorderSize = 0;
            this.btn_datLaiMatKhau.FlatAppearance.BorderSize = 0;
            this.btn_datLaiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datLaiMatKhau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datLaiMatKhau.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_datLaiMatKhau.Location = new System.Drawing.Point(461, 361);
            this.btn_datLaiMatKhau.Name = "btn_datLaiMatKhau";
            this.btn_datLaiMatKhau.Size = new System.Drawing.Size(167, 40);
            this.btn_datLaiMatKhau.TabIndex = 2;
            this.btn_datLaiMatKhau.Text = "ĐẶT LẠI";
            this.btn_datLaiMatKhau.TextColor = System.Drawing.SystemColors.Info;
            this.btn_datLaiMatKhau.UseVisualStyleBackColor = false;
            this.btn_datLaiMatKhau.Click += new System.EventHandler(this.btn_datLaiMatKhau_Click);
            // 
            // link_dangKy
            // 
            this.link_dangKy.AutoSize = true;
            this.link_dangKy.BackColor = System.Drawing.Color.Transparent;
            this.link_dangKy.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_dangKy.LinkColor = System.Drawing.SystemColors.Info;
            this.link_dangKy.Location = new System.Drawing.Point(555, 314);
            this.link_dangKy.Name = "link_dangKy";
            this.link_dangKy.Size = new System.Drawing.Size(118, 20);
            this.link_dangKy.TabIndex = 3;
            this.link_dangKy.TabStop = true;
            this.link_dangKy.Text = "Đến đăng nhập";
            this.link_dangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_dangKy_LinkClicked);
            // 
            // link_quenEmail
            // 
            this.link_quenEmail.AutoSize = true;
            this.link_quenEmail.BackColor = System.Drawing.Color.Transparent;
            this.link_quenEmail.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_quenEmail.LinkColor = System.Drawing.SystemColors.Info;
            this.link_quenEmail.Location = new System.Drawing.Point(415, 314);
            this.link_quenEmail.Name = "link_quenEmail";
            this.link_quenEmail.Size = new System.Drawing.Size(96, 20);
            this.link_quenEmail.TabIndex = 4;
            this.link_quenEmail.TabStop = true;
            this.link_quenEmail.Text = "Quên Email?";
            this.link_quenEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_quenMatKhau_LinkClicked);
            // 
            // checkBox_AnHienMatKhau
            // 
            this.checkBox_AnHienMatKhau.AutoSize = true;
            this.checkBox_AnHienMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_AnHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_AnHienMatKhau.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBox_AnHienMatKhau.Location = new System.Drawing.Point(419, 252);
            this.checkBox_AnHienMatKhau.Name = "checkBox_AnHienMatKhau";
            this.checkBox_AnHienMatKhau.Size = new System.Drawing.Size(190, 24);
            this.checkBox_AnHienMatKhau.TabIndex = 13;
            this.checkBox_AnHienMatKhau.Text = "Tôi không phải là robot";
            this.checkBox_AnHienMatKhau.UseVisualStyleBackColor = false;
            this.checkBox_AnHienMatKhau.CheckedChanged += new System.EventHandler(this.checkBox_AnHienMatKhau_CheckedChanged);
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Info;
            this.txt_email.BorderColor = System.Drawing.Color.Transparent;
            this.txt_email.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_email.BorderSize = 0;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.DimGray;
            this.txt_email.Location = new System.Drawing.Point(419, 205);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Padding = new System.Windows.Forms.Padding(7);
            this.txt_email.PasswordChar = true;
            this.txt_email.Size = new System.Drawing.Size(250, 31);
            this.txt_email.TabIndex = 1;
            this.txt_email.Texts = "";
            this.txt_email.UnderlinedStyle = false;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.BackColor = System.Drawing.Color.Transparent;
            this.l.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.SystemColors.Info;
            this.l.Location = new System.Drawing.Point(415, 172);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(70, 20);
            this.l.TabIndex = 7;
            this.l.Text = "Email (*)";
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.BackColor = System.Drawing.SystemColors.Info;
            this.txt_tenDangNhap.BorderColor = System.Drawing.Color.Transparent;
            this.txt_tenDangNhap.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_tenDangNhap.BorderSize = 0;
            this.txt_tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenDangNhap.ForeColor = System.Drawing.Color.DimGray;
            this.txt_tenDangNhap.Location = new System.Drawing.Point(419, 126);
            this.txt_tenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenDangNhap.Multiline = false;
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Padding = new System.Windows.Forms.Padding(7);
            this.txt_tenDangNhap.PasswordChar = false;
            this.txt_tenDangNhap.Size = new System.Drawing.Size(250, 31);
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
            this.label2.Location = new System.Drawing.Point(415, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(429, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quên mật khẩu";
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.minisize);
            this.Controls.Add(this.btn_datLaiMatKhau);
            this.Controls.Add(this.link_dangKy);
            this.Controls.Add(this.link_quenEmail);
            this.Controls.Add(this.checkBox_AnHienMatKhau);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.l);
            this.Controls.Add(this.txt_tenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuenMatKhau";
            this.TransparencyKey = System.Drawing.Color.White;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmQuenMatKhau_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmQuenMatKhau_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmQuenMatKhau_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minisize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox minisize;
        private KhanhBangButton btn_datLaiMatKhau;
        private System.Windows.Forms.LinkLabel link_dangKy;
        private System.Windows.Forms.LinkLabel link_quenEmail;
        private System.Windows.Forms.CheckBox checkBox_AnHienMatKhau;
        private CustomControls.RJControls.RJTextBox txt_email;
        private System.Windows.Forms.Label l;
        private CustomControls.RJControls.RJTextBox txt_tenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}