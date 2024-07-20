using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dùng thư viện này để mã hóa 
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CuaHangXeMay
{
    public class DangNhap
    {
        DBConnect kn = new DBConnect();
        frmDangNhap dn = new frmDangNhap();

        private static string tenTaiKhoan;
        
        public static string TenTaiKhoan
        {
            get { return DangNhap.tenTaiKhoan; }
            set { DangNhap.tenTaiKhoan = value; }
        }


        public DangNhap()
        {
        }

        private static List<TaiKhoan> danhSachTaiKhoan = new List<TaiKhoan>();


        public List<TaiKhoan> layDStaiKhoan(string sql)
        {
            List<TaiKhoan> DStaiKhoan = new List<TaiKhoan>();
            kn.open();
            SqlDataReader doc = kn.getexcuteReader(sql);
            while (doc.Read())
            {
                TaiKhoan tk = new TaiKhoan();
                tk.TenDangNhap = doc["tendangnhap"].ToString();
                tk.TenHienThi = doc["TenHienThi"].ToString();
                tk.MatKhau = doc["MatKhau"].ToString();
                tk.Quyen = doc["Quyen"].ToString();
                tk.Email = doc["email"].ToString();

                danhSachTaiKhoan.Add(tk);
            }
            kn.close();
            return danhSachTaiKhoan;
        }


        public int phanQuyenTaiKhoan()
        {
            int t = 0;
            frmDangNhap frm = new frmDangNhap();
            tenTaiKhoan = frm.TenDangNhapHienThi;

            string quyen = danhSachTaiKhoan.Find(tim => tim.TenDangNhap.Contains(tenTaiKhoan)).Quyen.ToString();
            if (quyen == "nguoiDung")
            {
                t = 0;
            }
            if (quyen == "QuanLy")
            {
                t = 1;
            }
            if (quyen == "Admin")
            {
                t = 10;
            }
            return t;
        }

        public void dongMoForm(Form frmMo, Form frmDong)
        {
            frmMo.ShowDialog();
            frmDong.Hide();
            frmDong.Close();
        }


        //Mã hóa mật khẩu
        public string maHoaHash(string chuoiCanMaHoa)
        {
            byte[] tam = ASCIIEncoding.ASCII.GetBytes(chuoiCanMaHoa);
            byte[] duLieuDaBam = new MD5CryptoServiceProvider().ComputeHash(tam);
            string chuoiDaMaHoa = "";
            foreach(byte pt in duLieuDaBam)
            {
                chuoiDaMaHoa += pt;
            }    
            return chuoiDaMaHoa;
        }

        //Hàm dùng chung kiểm tra hợp lệ
        #region
        public bool kiemTraTenDangNhap(string tenDangNhap)
        {
            return Regex.IsMatch(tenDangNhap, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool kiemTraEmail(string email)
        {
            return Regex.IsMatch(email, "^[a-zA-Z0-9_.]{2,100}@gmail.com(.vn|)$");
        }
        #endregion


        //Đặt lại mật khẩu
        public void datLaiMatKhau()
        {

        }

    }
}
