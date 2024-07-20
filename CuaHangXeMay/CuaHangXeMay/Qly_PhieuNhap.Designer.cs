namespace CuaHangXeMay
{
    partial class Qly_PhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Qly_PhieuNhap));
            this.dgv_cthoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_themsanpham = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb = new System.Windows.Forms.Label();
            this.txt_somay = new System.Windows.Forms.TextBox();
            this.txt_sokhung = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.cbo_maloaixe = new System.Windows.Forms.ComboBox();
            this.cbo_mapn = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ngaylap = new System.Windows.Forms.TextBox();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.btn_tao = new System.Windows.Forms.Button();
            this.cbo_nhanvien = new System.Windows.Forms.ComboBox();
            this.cbo_nhacc = new System.Windows.Forms.ComboBox();
            this.txt_mapn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthoadon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_cthoadon
            // 
            this.dgv_cthoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cthoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4});
            this.dgv_cthoadon.Location = new System.Drawing.Point(144, 385);
            this.dgv_cthoadon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_cthoadon.Name = "dgv_cthoadon";
            this.dgv_cthoadon.RowTemplate.Height = 28;
            this.dgv_cthoadon.Size = new System.Drawing.Size(667, 133);
            this.dgv_cthoadon.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maphieunhap";
            this.Column1.HeaderText = "Mã Phiếu Nhập";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "maloaixeganmay";
            this.Column3.HeaderText = "Mã Loại Xe Gắn Máy";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sokhungxe";
            this.Column2.HeaderText = "Số Khung Xe";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dongia";
            this.Column4.HeaderText = "Đơn Gía";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // btn_in
            // 
            this.btn_in.Image = ((System.Drawing.Image)(resources.GetObject("btn_in.Image")));
            this.btn_in.Location = new System.Drawing.Point(1, 464);
            this.btn_in.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(108, 53);
            this.btn_in.TabIndex = 10;
            this.btn_in.Text = "In Phiếu Nhập";
            this.btn_in.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_in.UseVisualStyleBackColor = true;
            // 
            // btn_themsanpham
            // 
            this.btn_themsanpham.Image = ((System.Drawing.Image)(resources.GetObject("btn_themsanpham.Image")));
            this.btn_themsanpham.Location = new System.Drawing.Point(1, 385);
            this.btn_themsanpham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_themsanpham.Name = "btn_themsanpham";
            this.btn_themsanpham.Size = new System.Drawing.Size(108, 55);
            this.btn_themsanpham.TabIndex = 9;
            this.btn_themsanpham.Text = "Thêm Sản Phẩm";
            this.btn_themsanpham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_themsanpham.UseVisualStyleBackColor = true;
            this.btn_themsanpham.Click += new System.EventHandler(this.btn_themsanpham_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb);
            this.groupBox2.Controls.Add(this.txt_somay);
            this.groupBox2.Controls.Add(this.txt_sokhung);
            this.groupBox2.Controls.Add(this.txt_dongia);
            this.groupBox2.Controls.Add(this.cbo_maloaixe);
            this.groupBox2.Controls.Add(this.cbo_mapn);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 232);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(807, 140);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Hóa Đơn";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(422, 29);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(53, 13);
            this.lb.TabIndex = 17;
            this.lb.Text = "Số Máy ";
            // 
            // txt_somay
            // 
            this.txt_somay.Location = new System.Drawing.Point(518, 27);
            this.txt_somay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_somay.Name = "txt_somay";
            this.txt_somay.Size = new System.Drawing.Size(238, 20);
            this.txt_somay.TabIndex = 16;
            // 
            // txt_sokhung
            // 
            this.txt_sokhung.Location = new System.Drawing.Point(143, 103);
            this.txt_sokhung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sokhung.Name = "txt_sokhung";
            this.txt_sokhung.Size = new System.Drawing.Size(237, 20);
            this.txt_sokhung.TabIndex = 15;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(518, 66);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(238, 20);
            this.txt_dongia.TabIndex = 13;
            this.txt_dongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbo_maloaixe
            // 
            this.cbo_maloaixe.FormattingEnabled = true;
            this.cbo_maloaixe.Location = new System.Drawing.Point(143, 68);
            this.cbo_maloaixe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_maloaixe.Name = "cbo_maloaixe";
            this.cbo_maloaixe.Size = new System.Drawing.Size(238, 21);
            this.cbo_maloaixe.TabIndex = 11;
            // 
            // cbo_mapn
            // 
            this.cbo_mapn.FormattingEnabled = true;
            this.cbo_mapn.Location = new System.Drawing.Point(143, 27);
            this.cbo_mapn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_mapn.Name = "cbo_mapn";
            this.cbo_mapn.Size = new System.Drawing.Size(238, 21);
            this.cbo_mapn.TabIndex = 9;
            this.cbo_mapn.SelectedIndexChanged += new System.EventHandler(this.cbo_mapn_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(421, 70);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Đơn Gía";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Loại Xe Gắn Máy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 107);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Số Khung Xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Phiếu Nhập ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phiếu Nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ngaylap);
            this.groupBox1.Controls.Add(this.btn_nhaplai);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.txt_tongtien);
            this.groupBox1.Controls.Add(this.btn_tao);
            this.groupBox1.Controls.Add(this.cbo_nhanvien);
            this.groupBox1.Controls.Add(this.cbo_nhacc);
            this.groupBox1.Controls.Add(this.txt_mapn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(807, 190);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Nhập";
            // 
            // txt_ngaylap
            // 
            this.txt_ngaylap.Enabled = false;
            this.txt_ngaylap.Location = new System.Drawing.Point(518, 32);
            this.txt_ngaylap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ngaylap.Name = "txt_ngaylap";
            this.txt_ngaylap.Size = new System.Drawing.Size(238, 20);
            this.txt_ngaylap.TabIndex = 12;
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhaplai.Image")));
            this.btn_nhaplai.Location = new System.Drawing.Point(583, 138);
            this.btn_nhaplai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(160, 42);
            this.btn_nhaplai.TabIndex = 4;
            this.btn_nhaplai.Text = "Nhập Lại";
            this.btn_nhaplai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nhaplai.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.Image")));
            this.btn_luu.Location = new System.Drawing.Point(340, 139);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(162, 42);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu Phiếu Nhập";
            this.btn_luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(519, 69);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(237, 20);
            this.txt_tongtien.TabIndex = 11;
            this.txt_tongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_tao
            // 
            this.btn_tao.Image = ((System.Drawing.Image)(resources.GetObject("btn_tao.Image")));
            this.btn_tao.Location = new System.Drawing.Point(84, 138);
            this.btn_tao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_tao.Name = "btn_tao";
            this.btn_tao.Size = new System.Drawing.Size(160, 43);
            this.btn_tao.TabIndex = 2;
            this.btn_tao.Text = "Tạo Phiếu Nhập";
            this.btn_tao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tao.UseVisualStyleBackColor = true;
            this.btn_tao.Click += new System.EventHandler(this.btn_tao_Click);
            // 
            // cbo_nhanvien
            // 
            this.cbo_nhanvien.FormattingEnabled = true;
            this.cbo_nhanvien.Location = new System.Drawing.Point(143, 105);
            this.cbo_nhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_nhanvien.Name = "cbo_nhanvien";
            this.cbo_nhanvien.Size = new System.Drawing.Size(238, 21);
            this.cbo_nhanvien.TabIndex = 8;
            // 
            // cbo_nhacc
            // 
            this.cbo_nhacc.FormattingEnabled = true;
            this.cbo_nhacc.Location = new System.Drawing.Point(142, 71);
            this.cbo_nhacc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_nhacc.Name = "cbo_nhacc";
            this.cbo_nhacc.Size = new System.Drawing.Size(238, 21);
            this.cbo_nhacc.TabIndex = 7;
            // 
            // txt_mapn
            // 
            this.txt_mapn.Enabled = false;
            this.txt_mapn.Location = new System.Drawing.Point(142, 32);
            this.txt_mapn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_mapn.Name = "txt_mapn";
            this.txt_mapn.Size = new System.Drawing.Size(239, 20);
            this.txt_mapn.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tổng Tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(437, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày Lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(318, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lý Phiếu Nhập ";
            // 
            // Qly_PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 487);
            this.Controls.Add(this.dgv_cthoadon);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_themsanpham);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Qly_PhieuNhap";
            this.Text = "Qly_PhieuNhap";
            this.Load += new System.EventHandler(this.Qly_PhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthoadon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cthoadon;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_themsanpham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.ComboBox cbo_maloaixe;
        private System.Windows.Forms.ComboBox cbo_mapn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ngaylap;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Button btn_tao;
        private System.Windows.Forms.ComboBox cbo_nhanvien;
        private System.Windows.Forms.ComboBox cbo_nhacc;
        private System.Windows.Forms.TextBox txt_mapn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txt_somay;
        private System.Windows.Forms.TextBox txt_sokhung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}