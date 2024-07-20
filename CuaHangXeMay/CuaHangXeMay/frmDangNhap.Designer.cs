namespace CuaHangXeMay
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.checkBox_AnHienMatKhau = new System.Windows.Forms.CheckBox();
            this.link_quenMatKhau = new System.Windows.Forms.LinkLabel();
            this.link_dangKy = new System.Windows.Forms.LinkLabel();
            this.minisize = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.btn_dangNhap = new CuaHangXeMay.KhanhBangButton();
            this.txt_matKhau = new CustomControls.RJControls.RJTextBox();
            this.txt_tenDangNhap = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.minisize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(635, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(579, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.BackColor = System.Drawing.Color.Transparent;
            this.l.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.SystemColors.Info;
            this.l.Location = new System.Drawing.Point(579, 177);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(75, 20);
            this.l.TabIndex = 0;
            this.l.Text = "Mật khẩu";
            // 
            // checkBox_AnHienMatKhau
            // 
            this.checkBox_AnHienMatKhau.AutoSize = true;
            this.checkBox_AnHienMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_AnHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_AnHienMatKhau.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBox_AnHienMatKhau.Location = new System.Drawing.Point(583, 257);
            this.checkBox_AnHienMatKhau.Name = "checkBox_AnHienMatKhau";
            this.checkBox_AnHienMatKhau.Size = new System.Drawing.Size(130, 24);
            this.checkBox_AnHienMatKhau.TabIndex = 2;
            this.checkBox_AnHienMatKhau.Text = "Hiện mật khẩu";
            this.checkBox_AnHienMatKhau.UseVisualStyleBackColor = false;
            this.checkBox_AnHienMatKhau.CheckedChanged += new System.EventHandler(this.checkBox_AnHienMatKhau_CheckedChanged);
            // 
            // link_quenMatKhau
            // 
            this.link_quenMatKhau.AutoSize = true;
            this.link_quenMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.link_quenMatKhau.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_quenMatKhau.LinkColor = System.Drawing.SystemColors.Info;
            this.link_quenMatKhau.Location = new System.Drawing.Point(579, 319);
            this.link_quenMatKhau.Name = "link_quenMatKhau";
            this.link_quenMatKhau.Size = new System.Drawing.Size(123, 20);
            this.link_quenMatKhau.TabIndex = 3;
            this.link_quenMatKhau.TabStop = true;
            this.link_quenMatKhau.Text = "Quên mật khẩu?";
            this.link_quenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_quenMatKhau_LinkClicked);
            // 
            // link_dangKy
            // 
            this.link_dangKy.AutoSize = true;
            this.link_dangKy.BackColor = System.Drawing.Color.Transparent;
            this.link_dangKy.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_dangKy.LinkColor = System.Drawing.SystemColors.Info;
            this.link_dangKy.Location = new System.Drawing.Point(764, 319);
            this.link_dangKy.Name = "link_dangKy";
            this.link_dangKy.Size = new System.Drawing.Size(69, 20);
            this.link_dangKy.TabIndex = 4;
            this.link_dangKy.TabStop = true;
            this.link_dangKy.Text = "Đăng ký";
            this.link_dangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_dangKy_LinkClicked);
            // 
            // minisize
            // 
            this.minisize.BackColor = System.Drawing.Color.Transparent;
            this.minisize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minisize.BackgroundImage")));
            this.minisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minisize.Location = new System.Drawing.Point(786, 12);
            this.minisize.Name = "minisize";
            this.minisize.Size = new System.Drawing.Size(32, 32);
            this.minisize.TabIndex = 5;
            this.minisize.TabStop = false;
            this.minisize.Click += new System.EventHandler(this.minisize_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(824, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 32);
            this.exit.TabIndex = 6;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_dangNhap.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_dangNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_dangNhap.BorderRadius = 0;
            this.btn_dangNhap.BorderSize = 0;
            this.btn_dangNhap.FlatAppearance.BorderSize = 0;
            this.btn_dangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangNhap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_dangNhap.Location = new System.Drawing.Point(625, 366);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(167, 40);
            this.btn_dangNhap.TabIndex = 2;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.TextColor = System.Drawing.SystemColors.Info;
            this.btn_dangNhap.UseVisualStyleBackColor = false;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.BackColor = System.Drawing.SystemColors.Info;
            this.txt_matKhau.BorderColor = System.Drawing.Color.Transparent;
            this.txt_matKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_matKhau.BorderSize = 0;
            this.txt_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matKhau.ForeColor = System.Drawing.Color.DimGray;
            this.txt_matKhau.Location = new System.Drawing.Point(583, 210);
            this.txt_matKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matKhau.Multiline = false;
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Padding = new System.Windows.Forms.Padding(7);
            this.txt_matKhau.PasswordChar = true;
            this.txt_matKhau.Size = new System.Drawing.Size(250, 31);
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
            this.txt_tenDangNhap.Location = new System.Drawing.Point(583, 131);
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
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.minisize);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.link_dangKy);
            this.Controls.Add(this.link_quenMatKhau);
            this.Controls.Add(this.checkBox_AnHienMatKhau);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.l);
            this.Controls.Add(this.txt_tenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangNhap";
            this.TransparencyKey = System.Drawing.Color.White;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDangNhap_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDangNhap_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmDangNhap_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.minisize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox txt_tenDangNhap;
        private System.Windows.Forms.Label l;
        private CustomControls.RJControls.RJTextBox txt_matKhau;
        private System.Windows.Forms.CheckBox checkBox_AnHienMatKhau;
        private System.Windows.Forms.LinkLabel link_quenMatKhau;
        private System.Windows.Forms.LinkLabel link_dangKy;
        private KhanhBangButton btn_dangNhap;
        private System.Windows.Forms.PictureBox minisize;
        private System.Windows.Forms.PictureBox exit;
    }
}