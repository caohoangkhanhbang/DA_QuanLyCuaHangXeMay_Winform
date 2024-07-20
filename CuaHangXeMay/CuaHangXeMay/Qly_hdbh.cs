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
    public partial class Qly_hdbh : Form
    {
       DBConnect db = new DBConnect();
        DataTable dt_hoadon = new DataTable();
        string sql = "select *from HoaDon";
        DataTable dt_cthd = new DataTable();
        string sqlct = "select *from ChiTietHoaDon";
        public Qly_hdbh()
        {
            dt_hoadon = db.getDatatable(sql);
            dt_cthd = db.getDatatable(sqlct);
            InitializeComponent();
        }

        private void Qly_hdbh_Load(object sender, EventArgs e)
        {
            load_combokhachhang();
            load_combonhanvien();
            load_combohinhthuctt();
            load_combohoadon();
           
            load_comboloaixegm();
            resethd();
            resetcthd();
        }
        public void load_combokhachhang()
        {
            string sql = "select * from  KhachHang ";
            DataTable dt_khachhang = new DataTable();
            dt_khachhang= db.getDatatable(sql);
            cbo_khachhang.DataSource = dt_khachhang;
            cbo_khachhang.ValueMember = "makhachhang";
            cbo_khachhang.DisplayMember = "tenkhachhang";
        }
        public void load_combonhanvien()
        {
            string sql = "select b.MaNhanVien, n.TenNhanVien from NhanVienBanHang as b inner join NhanVien as n on b.MaNhanVien=n.MaNhanVien ";
            DataTable dt_nhanvien = new DataTable();
            dt_nhanvien = db.getDatatable(sql);
            cbo_nhanvien.DataSource = dt_nhanvien;
            cbo_nhanvien.ValueMember = "manhanvien";
            cbo_nhanvien.DisplayMember = "tennhanvien";
        }
        public void load_combohinhthuctt()
        {
            string sql = "select * from  HinhThucThanhToan ";
            DataTable dt_hinhthuc = new DataTable();
            dt_hinhthuc = db.getDatatable(sql);
            cbo_hinhthuc.DataSource = dt_hinhthuc;
            cbo_hinhthuc.ValueMember = "mahinhthuc";
            cbo_hinhthuc.DisplayMember = "tenhinhthuc";
        }
       
        public void load_combohoadon()
        {
            string sql = "select * from  HoaDon ";
            DataTable dt_hoadon = new DataTable();
            dt_hoadon = db.getDatatable(sql);
            cbo_mahd.DataSource = dt_hoadon;
            cbo_mahd.ValueMember = "mahoadon";
            cbo_mahd.DisplayMember = "mahoadon";
        }
        public void load_comboxe()
        {
            string sql = "select * from  Xe where maloaixeganmay='" + cbo_maloaixe.SelectedValue.ToString() + "'and TinhTrang=N'chưa bán'";
            DataTable dt_xe = new DataTable();
            dt_xe = db.getDatatable(sql);
            cbo_sokhungxe.DataSource = dt_xe;
            cbo_sokhungxe.ValueMember = "sokhung";
            cbo_sokhungxe.DisplayMember = "sokhung";
        }
        public void load_comboloaixegm()
        {
            string sql = "select * from LoaiXeGanMay ";
            DataTable dt_loaixeganmay = new DataTable();
            dt_loaixeganmay = db.getDatatable(sql);
            cbo_maloaixe.DataSource = dt_loaixeganmay;
            cbo_maloaixe.ValueMember = "maloaixeganmay";
            cbo_maloaixe.DisplayMember = "tenxe";
        }
        private void btn_tao_Click(object sender, EventArgs e)
        {
            txt_mahd.Text = db.CreateKey("HD");
            txt_ngaylap.Text = DateTime.Now.ToShortDateString();
            txt_tongtien.Text = "0";
        }

        private void cbo_mahd_TextChanged(object sender, EventArgs e)
        {
           
        }
        public void load_dgv_chitiettheohoadon()
        {
            string sql = "select *from ChiTietHoaDon where MaHoaDon='" + cbo_mahd.SelectedValue.ToString() + "'";
            DataTable dt_cthdtheomahd = db.getDatatable(sql);
            dgv_cthoadon.DataSource = dt_cthdtheomahd;
            Databingding(dt_cthdtheomahd);
        }
        private void cbo_sokhungxe_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_mahd.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải tạo mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            if (txt_ngaylap.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải tạo mã hóa đơn để hiện ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            if (cbo_nhanvien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn nhân viên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            if (cbo_khachhang.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn khách hàng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            if (cbo_hinhthuc.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn hình thức thanh toán ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            DataRow newrow = dt_hoadon.NewRow();
            newrow["MaHoaDon"] = txt_mahd.Text;
            newrow["makhachhang"] = cbo_khachhang.SelectedValue.ToString();
            newrow["manhanvien"] = cbo_nhanvien.SelectedValue.ToString();
            newrow["mahinhthuc"] = cbo_hinhthuc.SelectedValue.ToString();
            newrow["ngaylap"] = txt_ngaylap.Text;
            newrow["tongtien"] = txt_tongtien.Text;
            dt_hoadon.Rows.Add(newrow);
            int kq = db.updateDatabase(dt_hoadon, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                load_combohoadon();
                resethd();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        bool ktra_trungmathang(string mahang, string madon)
        {
            string sql = "";
                          sql = "select count(*) from ChiTietHoaDon where SoKhungXe = '" + mahang + "' and MaHoaDon='" + madon + "'";

            int kq = (int)db.getScalar(sql);
            if (kq == 1)// có rồi
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_themsanpham_Click(object sender, EventArgs e)
        {
            double tong = 0,tongmoi=0;
            if (cbo_mahd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã Hóa Đơn Không Được Để Trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_mahd.Focus();
                return;
            }
            if (cbo_sokhungxe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn xe ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_sokhungxe.Focus();
                return;
            }
            if (txt_giamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
              txt_giamgia.Focus();
                return;
            }
            if (ktra_trungmathang(cbo_sokhungxe.SelectedValue.ToString(), cbo_mahd.Text) == false)
            {
                MessageBox.Show("Mặt Hàng này đã có, hãy nhập mã khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRow newrow = dt_cthd.NewRow();
            newrow["MaHoaDon"] = cbo_mahd.Text;
            newrow["Sokhungxe"] = cbo_sokhungxe.SelectedValue.ToString();
            newrow["giamgia"] = txt_giamgia.Text;
            newrow["dongia"] = txt_dongia.Text;
            newrow["thanhtien"] = txt_thanhtien.Text;
            dt_cthd.Rows.Add(newrow);
            int kq = db.updateDatabase(dt_cthd, sqlct);
            if (kq > 0)
            {
                string sql_update = " update Xe Set TinhTrang=N'đã bán' where SoKhung = '" + cbo_sokhungxe.SelectedValue.ToString() + "'";
                db.getnonquery(sql_update);
                tong = Convert.ToDouble(db.GetFieldValues("SELECT TongTien FROM HoaDon WHERE MaHoaDon ='" + cbo_mahd.SelectedValue.ToString()+ "'"));
                tongmoi = tong + Convert.ToDouble(txt_thanhtien.Text);
                 string sqlud = "UPDATE HoaDon SET TongTien =" + tongmoi + " WHERE MaHoaDon ='" + cbo_mahd.SelectedValue.ToString() + "'";
                 db.getnonquery(sqlud);
                txt_tongtien.Text = tongmoi.ToString();
                MessageBox.Show("Thêm thành công");
                load_dgv_chitiettheohoadon();
                resetcthd();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
         
            double dg, gg,tt;
            if (txt_giamgia.Text == "")
            {
                gg = 0;
            }
            else
            {
                gg = Convert.ToDouble(txt_giamgia.Text);
            }
            if (txt_dongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txt_dongia.Text);
            tt = ((dg-gg)+(dg*0.05))+2000000;
            txt_thanhtien.Text = tt.ToString();
        }
      private void resethd()
        {
            txt_mahd.Text = "";
            cbo_khachhang.Text = "";
            cbo_nhanvien.Text = "";
            cbo_hinhthuc.Text = "";
            txt_ngaylap.Text = "";
            txt_tongtien.Text = "";
        }
      private void resetcthd() 
      {
          cbo_mahd.Text = "";
          cbo_sokhungxe.Text = "";
          cbo_maloaixe.Text = "";
      }

      private void cbo_madongxe_SelectedIndexChanged(object sender, EventArgs e)
      {
          load_comboxe();
      }

      private void cbo_mahd_SelectedIndexChanged(object sender, EventArgs e)
      {
          if (cbo_mahd.Text == "")
          {
              txt_mahd.Text = "";
              cbo_khachhang.Text = "";
              cbo_nhanvien.Text = "";
              cbo_hinhthuc.Text = "";
              txt_ngaylap.Text = "";
              txt_tongtien.Text = "";
          }
          else
          {
              string sqlma = "select mahoadon from HoaDon where MaHoaDon ='" + cbo_mahd.SelectedValue.ToString() + "'";
              txt_mahd.Text = db.GetFieldValues(sqlma);
              string sqlkh = "Select tenkhachhang from KhachHang as k inner join hoadon as h on h.MaKhachHang=k.MaKhachHang where h.MaHoaDon='" + cbo_mahd.SelectedValue + "'";
              cbo_khachhang.Text = db.GetFieldValues(sqlkh);
              string sqlnv = "Select tennhanvien from NhanVien as n inner join hoadon as h on h.MaNhanVien=n.MaNhanVien where h.MaHoaDon='" + cbo_mahd.SelectedValue + "'";
              cbo_nhanvien.Text = db.GetFieldValues(sqlnv);
              string sqlht = "Select tenhinhthuc from HinhThucThanhToan as n inner join hoadon as h on h.MaHinhThuc=n.MaHinhThuc where h.MaHoaDon='" + cbo_mahd.SelectedValue + "'";
              cbo_hinhthuc.Text = db.GetFieldValues(sqlht);
              string sqlnl = "Select ngaylap from HoaDon where MaHoaDon='" + cbo_mahd.SelectedValue.ToString() + "'";
              txt_ngaylap.Text = db.GetFieldValues(sqlnl);
              string sqltt = "Select tongtien from HoaDon where MaHoaDon='" + cbo_mahd.SelectedValue.ToString() + "'";
              txt_tongtien.Text = db.GetFieldValues(sqltt);
          }
          load_dgv_chitiettheohoadon();
      }
      private void Databingding(DataTable pDT)
      {
         cbo_mahd.DataBindings.Clear();
          cbo_sokhungxe.DataBindings.Clear();
        txt_giamgia.DataBindings.Clear();
          txt_dongia.DataBindings.Clear();
          txt_thanhtien.DataBindings.Clear();
          cbo_mahd.DataBindings.Add("SelectedValue", pDT, "mahoadon");
          cbo_sokhungxe.DataBindings.Add("SelectedValue", pDT, "sokhungxe");
          txt_giamgia.DataBindings.Add("Text", pDT, "giamgia");
          txt_dongia.DataBindings.Add("Text", pDT, "dongia");
          txt_thanhtien.DataBindings.Add("Text", pDT, "thanhtien");
        
      }

      private void cbo_maloaixe_TextChanged(object sender, EventArgs e)
      {
          if (cbo_maloaixe.Text == "")
          {
              txt_dongia.Text = "";
          }
          else
          {
              string sql = "select giaban from  LoaiXeGanMay where  MaLoaiXeGanMay ='" + cbo_maloaixe.SelectedValue + "'";

              txt_dongia.Text = db.GetFieldValues(sql);
          }
          
      }
    }
}
