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
    public partial class Qly_PhanKhoi : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_phankhoi = new DataTable();
        string sql = "select *from PhanKhoi";
        public Qly_PhanKhoi()
        {
            dt_phankhoi = db.getDatatable(sql);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt_phankhoi.Columns[0];
            dt_phankhoi.PrimaryKey = key;
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            db.ClearAllTextBoxes(this);
            string kytuDau = "PK";
            string sql = "SELECT TOP 1 Maphankhoi FROM PhanKhoi ORDER BY MaPhanKhoi DESC";
            txt_ma.Text = db.taomatudong(kytuDau, sql);
            btn_luu.Enabled = true;
        }
        bool ktra_trungmaphankhoi(string ma)
        {
            string sql = "select count(*) from PhanKhoi where MaPhanKhoi= '" + ma + "'";
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
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_ma.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải tạo mã phân khối trước khi lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ktra_trungmaphankhoi(txt_ma.Text) == false)
            {
                MessageBox.Show(" Mã Phân Khối Này Đã Tồn Tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ma.Focus();
                return;
            }
            DataRow newrow = dt_phankhoi.NewRow();

            newrow["maphankhoi"] = txt_ma.Text;
            newrow["tenphankhoi"] = txt_ten.Text;
           
            dt_phankhoi.Rows.Add(newrow);
            int kq = db.updateDatabase(dt_phankhoi, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
              
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
            db.ClearAllTextBoxes(this);
            txt_ma.Focus();
        }
        bool ktra_fkmaphankhoi(string ma)
        {
            string sql = "select count(*) from DongXe where PhanKhoi= '" + ma + "'";
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
            if (txt_ma.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phân khối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ma.Focus();
                return;
            }
            if (ktra_fkmaphankhoi(txt_ma.Text) == false)
            {
                MessageBox.Show(" Mã Hãng Này Tồn Tại ở bảng khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ma.Focus();
                return;
            }
            DataRow row = dt_phankhoi.Rows.Find(txt_ma.Text);
            if (row != null)
            {
                row.Delete();
            }
            int kq = db.updateDatabase(dt_phankhoi, sql);
            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa Không thành công");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_ma.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phân khối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ma.Focus();
                return;
            }
            if (txt_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ten.Focus();
                return;
            }
            DataRow row = dt_phankhoi.Rows.Find(txt_ma.Text);
            if (row != null)
            {
                row["ten"] = txt_ten.Text;
              

            }
            int kq = db.updateDatabase(dt_phankhoi, sql);
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa Không thành công");
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            db.ClearAllTextBoxes(this);


        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Qly_PhanKhoi_Load(object sender, EventArgs e)
        {
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
    }
}
