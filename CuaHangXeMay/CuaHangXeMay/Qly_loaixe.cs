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
    public partial class Qly_loaixe : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_loaixe = new DataTable();
        string sql = "select *from LoaiXe";
        public Qly_loaixe()
        {
            InitializeComponent();
        }
        public void loaddatagridview()
        {
             dt_loaixe = db.getDatatable(sql);
            dataGrid_loaixe.DataSource = dt_loaixe;
            Databingding(dt_loaixe);
        }
       public void lamMoi()
        {
            txt_maloai.Clear();
            txt_tenloai.Clear();
            txt_maloai.Focus();
        }
       bool ktra_trungmaloai(string ma)
       {
           string sql = "select count(*) from LoaiXe where MaLoaiXe= '" + ma + "'";
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
       bool ktra_fkmaloai(string ma)
       {
           string sql = "SELECT SUM(total_count) AS total FROM ( SELECT COUNT(*) AS total_count FROM XeGanMay WHERE MaLoai = '" + ma + "' UNION ALL SELECT COUNT(*) AS total_count FROM PhuKien WHERE MaLoai = '" + ma + "' ) AS counts";
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

     
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_maloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maloai.Focus();
                return;
            }
            if (txt_tenloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenloai.Focus();
                return;
            }
            int ketQua = 0;
            if (ktra_trungmaloai(txt_maloai.Text) == false)
            {
                MessageBox.Show(" Mã Loại Này Đã Có ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maloai.Focus();
                return;
            }
              string sql = "insert into loaixe values('" + txt_maloai.Text + "',N'" + txt_tenloai.Text + "')";
                ketQua = db.getnonquery(sql);
                loaddatagridview();
            if (ketQua == 1)
                MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Qly_loaixe_Load(object sender, EventArgs e)
        {
            loaddatagridview();
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
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_maloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maloai.Focus();
                return;
            }
            if (ktra_fkmaloai(txt_maloai.Text) == false)
            {
                MessageBox.Show(" Mã Loại Này Tồn Tại ở bảng khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maloai.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string sqlXoa = "delete LoaiXe where MaLoaiXe = '" + txt_maloai.Text + "'";
                int ketQua = 0;
                ketQua = db.getnonquery(sqlXoa);
                loaddatagridview();
                lamMoi();
                if (ketQua == 1)
                    MessageBox.Show("Xóa thành công", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Xóa thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_maloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maloai.Focus();
                return;
            }
            if (txt_tenloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenloai.Focus();
                return;
            }
            string sqlSua = "update LoaiXe set TenLoaiXe = N'" + txt_tenloai.Text + "' where MaLoaiXe = '" + txt_maloai.Text + "'";
            int ketQua = 0;
            ketQua = db.getnonquery(sqlSua);
            loaddatagridview();
            lamMoi();
            if (ketQua == 1)
                MessageBox.Show("Sửa thành công", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Sửa thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Databingding(DataTable pDT)
        {
            txt_maloai.DataBindings.Clear();
            txt_tenloai.DataBindings.Clear();
            txt_maloai.DataBindings.Add("Text", pDT, "maloaixe");
            txt_tenloai.DataBindings.Add("Text", pDT, "tenloaixe");
          
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            db.ClearAllTextBoxes(this);
            txt_maloai.Focus();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
     
}
