using System;
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
    public partial class frmDangKy : Form
    {
        DangNhap dangNhap = new DangNhap();
        DBConnect kn = new DBConnect();
        /// Di chuyển form
        private bool drag = false;
        private Point dragCursor, dragForm;

        public frmDangKy()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txt_tenDangNhap.Texts;
            string matKhau = txt_matKhau.Texts;
            string xacNhanMatKhau = txt_xacNhanMatKhau.Texts;
            string email = txt_email.Texts;
            string quyen = "nguoiDung";
            string tenHienThi = tenDangNhap;

            string kiemTraTrungTen = "select * from taikhoan where tendangnhap = '" + tenDangNhap + "'";
            string kiemTraTrungEmail = "select * from taikhoan where email = '" + email + "'";

            int soLoi = -1;
            soLoi = kiemTraHopLeDangNhap(tenDangNhap, matKhau, xacNhanMatKhau, email, quyen, tenHienThi, kiemTraTrungTen, kiemTraTrungEmail);

            if (soLoi == 0)
            {
                frmDangKyTaiKhoan dangKy = new frmDangKyTaiKhoan();

                string maHoaMatKhau = dangNhap.maHoaHash(matKhau);
                string taoTaiKhoan = "insert into taikhoan values('" + tenDangNhap + "','" + tenHienThi + "','" + maHoaMatKhau + "','" + quyen + "','" + email + "')";
                kn.getnonquery(taoTaiKhoan);
                MessageBox.Show("Tài khoản đã được đăng ký thành công, mời bạn đăng nhập để sử dụng ứng dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDangNhap fdangNhap = new frmDangNhap();
                fdangNhap.ShowDialog();
                dangKy.Hide();
                dangKy.Close();
            }
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            frmDangKyTaiKhoan fdangKy = new frmDangKyTaiKhoan();
            frmDangNhap fdangNhap = new frmDangNhap();
            dangNhap.dongMoForm(fdangNhap, fdangKy);
        }

        private void frmDangKy_MouseMove(object sender, MouseEventArgs e)
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

        private void frmDangKy_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void frmDangKy_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }

        private void checkBox_AnHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AnHienMatKhau.Checked)
            {
                txt_matKhau.PasswordChar = txt_xacNhanMatKhau.PasswordChar = false;
            }
            else
            {
                txt_matKhau.PasswordChar = txt_xacNhanMatKhau.PasswordChar = true;
            }
        }

        private void link_coTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmDangKyTaiKhoan fdangKy = new frmDangKyTaiKhoan();
            frmDangNhap fdangNhap = new frmDangNhap();
            dangNhap.dongMoForm(fdangNhap, fdangKy);
        }

        public int kiemTraHopLeDangNhap(string tenDangNhap, string matKhau, string xacNhanMatKhau, string email, string quyen, string tenHienThi, string kiemTraTrungTen, string kiemTraTrungEmail)
        {
            int soLoi = 0;
            if (tenDangNhap.Trim() == "" && matKhau.Trim() == "" && xacNhanMatKhau.Trim() == "" && email.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                soLoi++;
            }
            if (!dangNhap.kiemTraTenDangNhap(tenDangNhap))
            {
                if (tenDangNhap == "")
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    soLoi++;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không hợp lệ! độ dài tên từ 6 đến 24 ký tự và không có ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    soLoi++;
                }
            }
            if (!dangNhap.kiemTraTenDangNhap(matKhau))
            {
                if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    soLoi++;
                }
                else
                {
                    soLoi++;
                    MessageBox.Show("Mật khẩu không hợp lệ! độ dài tên từ 6 đến 24 ký tự và không có ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (xacNhanMatKhau != matKhau || !dangNhap.kiemTraTenDangNhap(xacNhanMatKhau))
            {
                if (xacNhanMatKhau.Trim() == "")
                {
                    soLoi++;
                    MessageBox.Show("Vui lòng nhập trường này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận chưa trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    soLoi++;
                }
            }
            if (!dangNhap.kiemTraEmail(email))
            {
                if (email.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập emai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    soLoi++;
                }
                else
                {
                    MessageBox.Show("Email của bạn không hợp lệ vui lòng nhập đúng emai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    soLoi++;
                }
            }
            if (dangNhap.layDStaiKhoan(kiemTraTrungTen).Count > 0)
            {
                MessageBox.Show("Tên người dùng đã được đăng ký, vui lòng nghĩ ra tên khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                soLoi++;
            }
            if (dangNhap.layDStaiKhoan(kiemTraTrungEmail).Count > 0)
            {
                soLoi++;
                MessageBox.Show("Email này đã được đăng ký, vui lòng nhập email khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return soLoi;
        }
    }
}
