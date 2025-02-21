﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangXeMay
{
    public partial class frmDangNhap : Form
    {
        /// Di chuyển form
        private bool drag = false;
        private Point dragCursor, dragForm;
        public static List<TaiKhoan> DStaiKhoan = new List<TaiKhoan>();
        DangNhap dangNhap = new DangNhap();
        DBConnect kn = new DBConnect();
        //Biến truyền tên đăng nhập
        private string tenDangNhapHienThi;

        public string TenDangNhapHienThi
        {
            get { return tenDangNhapHienThi; }
            set { tenDangNhapHienThi = value; }
        }




        public frmDangNhap()
        {
            InitializeComponent();
            
        }

        private void frmDangNhap_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void frmDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }

        private void checkBox_AnHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AnHienMatKhau.Checked)
            {
                txt_matKhau.PasswordChar = false;
            }
            else
            {
                txt_matKhau.PasswordChar = true;
            }
        }

        private void minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txt_tenDangNhap.Texts;
            string matKhau = txt_matKhau.Texts;
            if (tenDangNhap.Trim() == "")
            {
                MessageBox.Show("Bạn quên nhập tên đăng nhập rồi kìa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (matKhau.Trim() == "")
            {
                MessageBox.Show("Bạn quên nhập mật khẩu rồi kìa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string matKhauMaHoa = dangNhap.maHoaHash(matKhau);
                string layTatCaTaiKhoan = "select * from taikhoan where tendangnhap = '" + tenDangNhap + "' and matkhau = '" + matKhauMaHoa + "'";
                DStaiKhoan = dangNhap.layDStaiKhoan(layTatCaTaiKhoan);
                if (DStaiKhoan.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TenDangNhapHienThi = tenDangNhap;
                    Main frmMain = new Main();
                    frmDangNhap dangNhapf = new frmDangNhap();
                    dangNhapf.Close();
                    dangNhapf.Hide();
                    frmMain.ShowDialog();
                }
                else
                {
                    string kiemTraTaiKhoanTonTai = "select * from taikhoan where tendangnhap = '" + tenDangNhap + "'";
                    DStaiKhoan = dangNhap.layDStaiKhoan(kiemTraTaiKhoanTonTai);
                    if (DStaiKhoan.Count > 0)
                    {
                        MessageBox.Show("Mật khẩu của bạn không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập này chưa được đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void link_quenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangNhap dangNhapf = new frmDangNhap();
            frmQuenMatKhau quenMatKhau = new frmQuenMatKhau();
            //dangNhapf.Close();
            //quenMatKhau.ShowDialog();
            dangNhap.dongMoForm(quenMatKhau, dangNhapf);
        }

        private void link_dangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy dangKyMo = new frmDangKy();
            frmDangNhap frmDangNhap = new frmDangNhap();
            dangNhap.dongMoForm(dangKyMo, frmDangNhap);
        }


        private void frmDangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            int wid = SystemInformation.VirtualScreen.Width;
            int hei = SystemInformation.VirtualScreen.Height;
            if (drag)
            {
                // Phải using System.Drawing;
                Point change = Point.Subtract(Cursor.Position, new Size(dragCursor));
                Point newpos = Point.Add(dragForm, new Size(change));
                // QUyết định có cho form chui ra ngoài màn hình không
                if (newpos.X < 0) newpos.X = 0;
                if (newpos.Y < 0) newpos.Y = 0;
                if (newpos.X + this.Width > wid) newpos.X = wid - this.Width;
                if (newpos.Y + this.Height > hei) newpos.Y = hei - this.Height;
                this.Location = newpos;
            }
        }
    }
}
