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
    public partial class Qly_PhieuNhap : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_phieunhap = new DataTable();
        string sql = "select *from PhieuNhap";
        DataTable dt_ctpn = new DataTable();
        string sqlct = "select *from ChiTietPhieuNhap";
        DataTable dt_xe = new DataTable();
        string sqlxe = "select * from Xe";
        public Qly_PhieuNhap()
        {
            dt_xe = db.getDatatable(sqlxe);
            dt_phieunhap = db.getDatatable(sql);
            dt_ctpn = db.getDatatable(sqlct);
            InitializeComponent();
        }
        public void load_combonhacc()
        {
            string sql = "select * from  NhaCungCap ";
            DataTable dt_nhacc = new DataTable();
            dt_nhacc = db.getDatatable(sql);
            cbo_nhacc.DataSource = dt_nhacc;
            cbo_nhacc.ValueMember = "manhacungcap";
            cbo_nhacc.DisplayMember = "ten";
        }
        public void load_combophieunhap()
        {
            string sql = "select * from  PhieuNhap ";
            DataTable dt_phieunhap = new DataTable();
            dt_phieunhap = db.getDatatable(sql);
            cbo_mapn.DataSource = dt_phieunhap;
            cbo_mapn.ValueMember = "maphieunhap";
            cbo_mapn.DisplayMember = "tenphieunhap";
        }
        public void load_combonhanvien()
        {
            string sql = "select b.MaNhanVien, n.TenNhanVien from QuanLy as b inner join NhanVien as n on b.MaNhanVien=n.MaNhanVien ";
            DataTable dt_nhanvien = new DataTable();
            dt_nhanvien = db.getDatatable(sql);
            cbo_nhanvien.DataSource = dt_nhanvien;
            cbo_nhanvien.ValueMember = "manhanvien";
            cbo_nhanvien.DisplayMember = "tennhanvien";
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
            txt_mapn.Text = db.CreateKey("PN");
            txt_ngaylap.Text = DateTime.Now.ToShortDateString();
            txt_tongtien.Text = "0";
        }
        public void load_dgv_chitiettheophieunhap()
        {
            string sql = "select *from ChiTietPhieuNhap where MaPhieuNhap='" + cbo_mapn.SelectedValue.ToString() + "'";
            DataTable dt_cthdtheomapn = db.getDatatable(sql);
            dgv_cthoadon.DataSource = dt_cthdtheomapn;
            Databingding(dt_cthdtheomapn);
        }
        private void Qly_PhieuNhap_Load(object sender, EventArgs e)
        {
            load_combonhacc();
            load_combonhanvien();
            load_combophieunhap();
            load_comboloaixegm();
            phanQuyen();
        }
        DangNhap dangNhapQuyen = new DangNhap();

        public void phanQuyen()
        {
            if (dangNhapQuyen.phanQuyenTaiKhoan() == 0)
            {
                btn_tao.Enabled = false;
                btn_themsanpham.Enabled = false;
            }
        }

        private void cbo_mapn_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_grphieunhap();
            load_dgv_chitiettheophieunhap();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_mapn.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải tạo mã phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (cbo_nhacc.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn khách hàng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }
            DataRow newrow = dt_phieunhap.NewRow();
            newrow["MaPhieuNhap"] = txt_mapn.Text;
            newrow["manhacungcap"] = cbo_nhacc.SelectedValue.ToString();
            newrow["manhanvien"] = cbo_nhanvien.SelectedValue.ToString();
            newrow["ngaylap"] = txt_ngaylap.Text;
            newrow["tongtien"] = txt_tongtien.Text;
            dt_phieunhap.Rows.Add(newrow);
            int kq = db.updateDatabase(dt_phieunhap, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                load_combophieunhap();
                resetpn();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        private void resetpn()
        {
            txt_mapn.Text = "";
            cbo_nhacc.Text = "";
            cbo_nhanvien.Text = "";
            txt_ngaylap.Text = "";
            txt_tongtien.Text = "";
        }
        private void resetctpn()
        {
            cbo_mapn.Text = "";
            cbo_maloaixe.Text = "";
            txt_sokhung.Text = "";
            txt_somay.Text = "";
            txt_dongia.Text = "";
          
        }
        private void load_grphieunhap()
        {
            if (cbo_mapn.Text == "")
            {
                txt_mapn.Text = "";
                cbo_nhacc.Text = "";
                cbo_nhanvien.Text = "";
                txt_ngaylap.Text = "";
                txt_tongtien.Text = "";
            }
            else
            {
                string sqlma = "select maphieunhap from PhieuNhap where MaPhieuNhap ='" + cbo_mapn.SelectedValue.ToString() + "'";
                txt_mapn.Text = db.GetFieldValues(sqlma);
                string sqlnhacc = "Select ten from NhaCungCap as N inner join PhieuNhap as h on h.MaNhaCungCap=N.MaNhaCungCap where h.MaPhieuNhap='" + cbo_mapn.SelectedValue + "'";
                cbo_nhacc.Text = db.GetFieldValues(sqlnhacc);
                string sqlnv = "Select tennhanvien from NhanVien as n inner join PhieuNhap as h on h.MaNhanVien=n.MaNhanVien where h.MaPhieuNhap='" + cbo_mapn.SelectedValue + "'";
                cbo_nhanvien.Text = db.GetFieldValues(sqlnv);
                string sqlnl = "Select ngaylap from PhieuNhap where MaPhieuNhap='" + cbo_mapn.SelectedValue.ToString() + "'";
                txt_ngaylap.Text = db.GetFieldValues(sqlnl);
                string sqltt = "Select tongtien from PhieuNhap where MaPhieuNhap='" + cbo_mapn.SelectedValue.ToString() + "'";
                txt_tongtien.Text = db.GetFieldValues(sqltt);
            }
        }
        bool ktra_trungsokhung(string ma)
        {
            string sql = "select count(*) from Xe where SoKhung = '" + ma + "'";
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
        bool ktra_trungsomay(string ma)
        {
            string sql = "select count(*) from Xe where SoMay= '" + ma + "'";
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
        private void Databingding(DataTable pDT)
        {
            cbo_mapn.DataBindings.Clear();
            txt_sokhung.DataBindings.Clear();
            txt_somay.DataBindings.Clear();
            txt_dongia.DataBindings.Clear();
            cbo_maloaixe.DataBindings.Clear();
            cbo_mapn.DataBindings.Add("SelectedValue", pDT, "maphieunhap");
            txt_sokhung.DataBindings.Add("Text", pDT, "sokhungxe");
            txt_somay.DataBindings.Add("Text", pDT, "somay");
            txt_dongia.DataBindings.Add("Text", pDT, "dongia");
            cbo_maloaixe.DataBindings.Add("SelectedValue", pDT, "maloaixeganmay");
           
        }
       
        private void btn_themsanpham_Click(object sender, EventArgs e)
        {
            double tong = 0, tongmoi = 0;
            if (cbo_mapn.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã Phiếu Nhập Không Được Để Trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_mapn.Focus();
                return;
            }
            if (txt_sokhung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số khung ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sokhung.Focus();
                return;
            }
            if (txt_somay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số máy ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_somay.Focus();
                return;
            }
            if (ktra_trungsokhung(txt_sokhung.Text) == false)
            {
                MessageBox.Show(" Số Khung Xe Này Đã Tồn Tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ktra_trungsomay(txt_sokhung.Text) == false)
            {
                MessageBox.Show(" Số Máy Xe Này Đã Tồn Tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_dongia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_dongia.Focus();
                return;
            }

            DataRow newrowxe = dt_xe.NewRow();
            newrowxe["SoKhung"] = txt_sokhung.Text;
            newrowxe["SoMay"] = txt_somay.Text;
            newrowxe["TinhTrang"] = "chưa bán";
            newrowxe["MaLoaiXeGanMay"] = cbo_maloaixe.SelectedValue.ToString();
            dt_xe.Rows.Add(newrowxe);
            int kqxe = db.updateDatabase(dt_xe, sqlxe);

            DataRow newrow = dt_ctpn.NewRow();
            newrow["MaPhieuNhap"] = cbo_mapn.Text;
            newrow["Sokhungxe"] = txt_sokhung.Text;
            newrow["Somay"] = txt_somay.Text;
            newrow["dongia"] = txt_dongia.Text;
            newrow["maloaixeganmay"] = cbo_maloaixe.SelectedValue.ToString();
            dt_ctpn.Rows.Add(newrow);
            int kq = db.updateDatabase(dt_ctpn, sqlct);
            if (kq > 0)
            {
               
                tong = Convert.ToDouble(db.GetFieldValues("SELECT TongTien FROM PhieuNhap WHERE MaPhieuNhap ='" + cbo_mapn.SelectedValue.ToString() + "'"));
                tongmoi = tong + Convert.ToDouble(txt_dongia.Text);
                string sqlud = "UPDATE PhieuNhap SET TongTien =" + tongmoi + " WHERE MaPhieuNhap ='" + cbo_mapn.SelectedValue.ToString() + "'";
                db.getnonquery(sqlud);
                txt_tongtien.Text = tongmoi.ToString();
                MessageBox.Show("Thêm thành công");
                load_dgv_chitiettheophieunhap();
                resetctpn();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
