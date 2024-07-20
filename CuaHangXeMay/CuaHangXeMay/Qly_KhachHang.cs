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
    public partial class Qly_KhachHang : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_kh = new DataTable();
        string sql = "select *from KhachHang";
        public Qly_KhachHang()
        {
            dt_kh = db.getDatatable(sql);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt_kh.Columns[0];
            dt_kh.PrimaryKey = key;
            InitializeComponent();
        }
        public void load_datagridview_kh()
        {
            dataGrid_khachhang.DataSource = dt_kh;
            Databingding(dt_kh);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGrid_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_makhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_khachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtb_diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtb_sdt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            db.ClearAllTextBoxes(this);
            mtb_sdt.Clear();
            txt_makhachhang.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dt_kh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
             if (txt_makhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_makhachhang.Focus();
                return;
            }
            if (txt_tenkhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenkhachhang.Focus();
                return;
            }
            if (mtb_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtb_sdt.Focus();
                return;
            }
            if (txt_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diachi.Focus();
                return;
            }
            DataRow row = dt_kh.Rows.Find(txt_makhachhang.Text);
            if (row != null)
            {
                row["makhachhang"] = txt_makhachhang.Text;
                row["tenkhachhang"] = txt_tenkhachhang.Text;
                row["diachi"] = txt_diachi.Text;
                row["sodienthoai"] = mtb_sdt.Text;
              
            }
            int kq = db.updateDatabase(dt_kh, sql);
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công");
                load_datagridview_kh();
            }
            else
            {
                MessageBox.Show("Sửa Không thành công");
            }
            db.ClearAllTextBoxes(this);
            mtb_sdt.Clear();
            txt_makhachhang.Focus();
        }
        
        bool ktra_fkmakhachhang(string ma)
        {
            string sql = "Select count (*) from HoaDon where MaKhachHang= '" + ma + "'";
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
        bool ktra_trungmakhachhang(string ma)
        {
            string sql = "select count(*) from KhachHang where MaKhachHang= '" + ma + "'";
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
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dt_kh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_makhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_makhachhang.Focus();
                return;
            }
            if (ktra_fkmakhachhang(txt_makhachhang.Text) == false)
            {
                MessageBox.Show(" Mã Khách Này Tồn Tại ở bảng khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_makhachhang.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataRow row = dt_kh.Rows.Find(txt_makhachhang.Text);
                if (row != null)
                {
                    row.Delete();
                }
                int kq = db.updateDatabase(dt_kh, sql);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    load_datagridview_kh();
                }
                else
                {
                    MessageBox.Show("Xóa Không thành công");
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_makhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_makhachhang.Focus();
                return;
            }
            if (txt_tenkhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenkhachhang.Focus();
                return;
            }
            if (mtb_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtb_sdt.Focus();
                return;
            }
            if (txt_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diachi.Focus();
                return;
            }
            if (ktra_trungmakhachhang(txt_makhachhang.Text) == false)
            {
                MessageBox.Show(" Mã Khách Hàng Này Đã Tồn Tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_makhachhang.Focus();
                return;
            }
            DataRow newrow = dt_kh.NewRow();
            newrow["makhachhang"] = txt_makhachhang.Text;
            newrow["tenkhachhang"] = txt_tenkhachhang.Text;
            newrow["diachi"] = txt_diachi.Text;
            newrow["sodienthoai"] = mtb_sdt.Text;
           dt_kh.Rows.Add(newrow);
            int kq = db.updateDatabase(dt_kh, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                load_datagridview_kh();
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
            db.ClearAllTextBoxes(this);
            mtb_sdt.Clear();
            txt_makhachhang.Focus();
        }

        private void txt_makhachhang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void Qly_KhachHang_Load(object sender, EventArgs e)
        {
            load_datagridview_kh();
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
        private void Databingding(DataTable pDT)
        {
            txt_makhachhang.DataBindings.Clear();
            txt_tenkhachhang.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            mtb_sdt.DataBindings.Clear();
            txt_makhachhang.DataBindings.Add("Text", pDT, "makhachhang");
            txt_tenkhachhang.DataBindings.Add("Text", pDT, "tenkhachhang");
            txt_diachi.DataBindings.Add("Text", pDT, "diachi");
            mtb_sdt.DataBindings.Add("Text", pDT, "sodienthoai");
        }
    }
}
