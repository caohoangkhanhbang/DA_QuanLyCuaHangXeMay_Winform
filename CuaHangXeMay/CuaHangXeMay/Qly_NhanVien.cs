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
    public partial class Qly_NhanVien : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_ql = new DataTable();
        DataTable dt_bh = new DataTable();
       
        public Qly_NhanVien()
        { 
            InitializeComponent();
        }
        public int KTtonTaiNhanVien(string kiemTra)
        {
            int ketQua = 0;
            ketQua = (int)db.getScalar(kiemTra);
            return ketQua;
        }
        public void taidl()
        {
            string sql2 = "select nv.MaNhanVien, nv.TenNhanVien,nv.Sodienthoai,nv.DiaChi, bh.Luong,bh.DoanhSo from NhanVien nv inner join NhanVienBanHang bh on nv.MaNhanVien=bh.MaNhanVien";
            string sql = "select nv.MaNhanVien, nv.TenNhanVien,nv.Sodienthoai,nv.DiaChi, ql.Luong,ql.Thuong from NhanVien nv inner join QuanLy ql on nv.MaNhanVien=ql.MaNhanVien";
            dt_ql = db.getDatatable(sql);
            dt_bh = db.getDatatable(sql2);
            dataGridView_nhanVien_banHang.DataSource = dt_bh;
            dataGrid_NhanVien_QuanLy.DataSource = dt_ql;
            Databingding(dt_bh);
            Databingding(dt_ql);
        }
       

        public bool ktRong()
        {
            if (txt_manv.Text == "" || txt_tennv.Text == "" || mtb_sdt.Text == "" || txt_luong.Text == "" || txt_diachi.Text == "")
            {
                if (rdb_nhanVienBanHang.Checked == true && txt_thuong.Text == "")
                    return true;
                if (rdb_quanLy.Checked == true && txt_doanhso.Text == "")
                    return true;
                return true;
            }
            return false;
        }
        public void lamMoi()
        {
            txt_manv.Clear();
            txt_tennv.Clear();
            txt_luong.Clear();
            txt_diachi.Clear();
            mtb_sdt.Clear();
            txt_thuong.Clear();
            txt_doanhso.Clear();
            rdb_quanLy.Checked = false;
            rdb_nhanVienBanHang.Checked = false;
            txt_manv.Focus();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Qly_NhanVien_Load(object sender, EventArgs e)
        {
            taidl();
            phanQuyen();
           
        }
        DangNhap dangNhapQuyen = new DangNhap();
        public void phanQuyen()
        {
            if (dangNhapQuyen.phanQuyenTaiKhoan() == 0)
            {
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        private void txt_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.onlyNumber(e);
        }
        public bool KTkhoaChinh(string khoa)
        {
            string sql = "select count(*) from NhanVien where MaNhanVien = '" + khoa + "'";
            int kq = (int)db.getScalar(sql);
            if (kq == 1)
                return true;
            return false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (ktRong() == false)
            {
                if (KTkhoaChinh(txt_manv.Text) == true)
                {
                    MessageBox.Show("Thêm thất bại do trùng khóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string lenhThem = "insert into NhanVien values('" + txt_manv.Text + "',N'" + txt_tennv.Text + "'," + mtb_sdt.Text + ",N'" + txt_diachi.Text + "')";
                    int kq = db.getnonquery(lenhThem);
                    if (rdb_quanLy.Checked)
                    {
                        string quanLy = "insert into QuanLy values('" + txt_manv.Text + "'," + txt_luong.Text + "," + txt_thuong.Text + ")";
                        db.getnonquery(quanLy);
                    }
                    if (rdb_nhanVienBanHang.Checked)
                    {
                        string banHang = "insert into NhanVienBanHang values('" + txt_manv.Text + "'," + txt_luong.Text + "," + txt_doanhso.Text + ")";
                        db.getnonquery(banHang);
                    }

                    if (kq == 1)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lamMoi();
                        taidl();
                       
                    }

                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void rdb_quanLy_CheckedChanged(object sender, EventArgs e)
        {
            txt_thuong.Enabled = true;
            txt_doanhso.Enabled = false;
        }

        private void rdb_nhanVienBanHang_CheckedChanged(object sender, EventArgs e)
        {
            txt_doanhso.Enabled = true;
            txt_thuong.Enabled = false;
        }
        bool ktra_fkmanhanvienbanhang(string ma)
        {
            string sql = "select count(*) from NhanVien as N  inner join NhanVienBanHang as B on N.MaNhanVien=B.MaNhanVien inner join HoaDon as H on B.MaNhanVien=H.MaNhanVien Where N.MaNhanVien= '"+ma+"' and N.MaNhanVien=B.MaNhanVien";
            int kq = (int)db.getScalar(sql);
            if (kq >= 1)// có rồi
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool ktra_fkmaquanly(string ma)
        {
            string sql = "select count(*) from NhanVien as N  inner join QuanLy as B on N.MaNhanVien=B.MaNhanVien inner join PhieuNhap as H on B.MaNhanVien=H.MaNhanVien Where N.MaNhanVien= '" + ma + "' and N.MaNhanVien=B.MaNhanVien";
            int kq = (int)db.getScalar(sql);
            if (kq >= 1)// có rồi
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_manv.Focus();
                return;
            }
            if (ktra_fkmanhanvienbanhang(txt_manv.Text) == false)
            {
                MessageBox.Show(" Mã Nhân Viên Này Tồn Tại ở bảng Hóa Đơn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_manv.Focus();
                return;
            }
            if (ktra_fkmanhanvienbanhang(txt_manv.Text) == false)
            {
                MessageBox.Show(" Mã Quản Lý Này Tồn Tại ở bảng Phiếu Nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_manv.Focus();
                return;
            }
            int ketQua = 0;
            string nhanVien = "delete NhanVien where MaNhanVien = '" + txt_manv.Text + "'";
            string banHang = "delete NhanVienBanHang where MaNhanVien = '" + txt_manv.Text + "'";
            string quanLy = "delete QuanLy where MaNhanVien = '" + txt_manv.Text + "'";
            ketQua = (int)db.getnonquery(quanLy);
            ketQua = (int)db.getnonquery(banHang);
            ketQua = (int)db.getnonquery(nhanVien);
            if (ketQua == 1)
            {
                MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lamMoi();
                taidl();
               
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int ketQua = 0;
            string uNhanVien = "update NhanVien set TenNhanVien = N'" + txt_tennv.Text + "', Sodienthoai = " + mtb_sdt.Text + ",DiaChi = N'" + txt_diachi.Text + "' where MaNhanVien = '" + txt_manv.Text + "'";
            string uBanHang = "update NhanVienBanHang set Luong = " + txt_luong.Text + ", DoanhSo = " + txt_doanhso.Text + " where MaNhanVien = '" + txt_manv.Text + "'";
            string uQuanLy = "update QuanLy set Luong = " + txt_luong.Text + ", Thuong = " + txt_thuong.Text + " where MaNhanVien = '" + txt_manv.Text + "'";

            ketQua = db.getnonquery(uNhanVien);
            if (rdb_quanLy.Checked)
            {
                db.getnonquery(uBanHang);
            }
            if (rdb_nhanVienBanHang.Checked)
            {
                db.getnonquery(uQuanLy);
            }
          
            if (ketQua == 1)
            {
                MessageBox.Show("Cập nhật thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lamMoi();
                taidl();
            }
            else
            {
                MessageBox.Show("cập nhật thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void txt_thuong_TextChanged(object sender, EventArgs e)
        {
               double thuong,tt;
            if (txt_thuong.Text == "")
                thuong = 0;
            else
                thuong = Convert.ToDouble(txt_thuong.Text);
            tt = 12000000 + thuong; ;
            txt_luong.Text = tt.ToString();
        }

        private void txt_doanhso_TextChanged(object sender, EventArgs e)
        {
            double doanhso, tt;
            if (txt_thuong.Text == "")
                doanhso = 0;
            else
                doanhso = Convert.ToDouble(txt_doanhso.Text);
            tt = 7000000 + (doanhso*500000); ;
            txt_luong.Text = tt.ToString();
        }
        private void Databingding(DataTable pDT)
        {
            txt_manv.DataBindings.Clear();
            txt_tennv.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            mtb_sdt.DataBindings.Clear();
            txt_luong.DataBindings.Clear();
            txt_thuong.DataBindings.Clear();
            txt_manv.DataBindings.Add("Text", pDT, "manhanvien");
            txt_tennv.DataBindings.Add("Text", pDT, "tennhanvien");
            txt_diachi.DataBindings.Add("Text", pDT, "diachi");
            mtb_sdt.DataBindings.Add("Text", pDT, "sodienthoai");
            txt_luong.DataBindings.Add("Text", pDT, "luong");
            //txt_thuong.DataBindings.Add("Text", pDT, "thuong");
           
        }
       

    }
}
