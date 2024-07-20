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
    public partial class frmQuenMatKhau : Form
    {
        DangNhap dangNhap = new DangNhap();
        DBConnect kn = new DBConnect();
        /// Di chuyển form
        private bool drag = false;
        private Point dragCursor, dragForm;
        public static List<TaiKhoan> DStaiKhoan = new List<TaiKhoan>();


        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void frmQuenMatKhau_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void frmQuenMatKhau_MouseMove(object sender, MouseEventArgs e)
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

        private void frmQuenMatKhau_MouseDown(object sender, MouseEventArgs e)
        {

            drag = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void link_quenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vô phương cứu chữa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void link_dangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMatKhau quen = new frmQuenMatKhau();
            frmDangNhap dk = new frmDangNhap();
            dangNhap.dongMoForm(dk, quen);
        }

        public int kiemTraHopLeDangNhap(string tenDangNhap, string email)
        {
            int soLoi = 0;
            if (tenDangNhap.Trim() == "" && tenDangNhap.Trim() == "" && email.Trim() == "")
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
            return soLoi;
        }

        private void btn_datLaiMatKhau_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txt_tenDangNhap.Texts;
            string emailDangNhap = txt_email.Texts;
            int soLoi = -1;
            soLoi = kiemTraHopLeDangNhap(tenDangNhap, emailDangNhap);
            if (soLoi == 0)
            {
                string layTatCaTaiKhoan = "select * from taikhoan where tendangnhap = '" + tenDangNhap + "' and email = '" + emailDangNhap + "'";
                DStaiKhoan = dangNhap.layDStaiKhoan(layTatCaTaiKhoan);
                if (DStaiKhoan.Count > 0)
                {
                    //MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Main frmMain = new Main();
                    string resetpass = "update TaiKhoan set MatKhau = '1962026656160185351301320480154111117132155' where TenDangNhap = '" + tenDangNhap + "' and Email = '" + emailDangNhap + "'";
                    kn.getnonquery(resetpass);
                    l.Text = "Dùng mật khẩu này để đăng nhập";
                    txt_email.Texts = "1";
                    txt_email.PasswordChar = false;
                }
                else
                {
                    string kiemTraTaiKhoanTonTai = "select * from taikhoan where tendangnhap = '" + tenDangNhap + "'";
                    DStaiKhoan = dangNhap.layDStaiKhoan(kiemTraTaiKhoanTonTai);
                    if (DStaiKhoan.Count > 0)
                    {
                        MessageBox.Show("Email của bạn không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập này chưa được đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void checkBox_AnHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AnHienMatKhau.Checked)
            {
                Random ran = new Random();
                int a = ran.Next(10, 100);
                int b = ran.Next(10, 100);
                MessageBox.Show("" + a + " + " + b + " = ?", "Bạn không phải là robot", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                txt_email.PasswordChar = txt_email.PasswordChar = false;
            }
            else
            {
                txt_email.PasswordChar = txt_email.PasswordChar = true;
            }
        }
    }
}
