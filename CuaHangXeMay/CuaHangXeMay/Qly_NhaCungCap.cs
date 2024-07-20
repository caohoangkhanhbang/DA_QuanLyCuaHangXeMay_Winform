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
    public partial class Qly_NhaCungCap : Form
    {
        DBConnect kn = new DBConnect();

        public Qly_NhaCungCap()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int ketQua = 0;
            if (ktRong() == false)
            {
                string sqlThem = "insert into NhaCungCap values('" + txt_manhacc.Text + "',N'" + txt_tennhacc.Text + "',N'" + txt_diachi.Text + "',N'" + txt_dienThoai.Text + "')";
                ketQua = kn.getnonquery(sqlThem);
                taiDuLieu();
                lamMoi();
            }
            else
            {
                MessageBox.Show("Không được để trống các trường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (ketQua == 1)
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int ketQua = 0;
            if (ktKhoaNgoai(txt_manhacc.Text) == false)
            {
                string sqlXoa = "delete NhaCungCap where MaNhaCungCap = '" + txt_manhacc.Text + "'";
                ketQua = kn.getnonquery(sqlXoa);
                taiDuLieu();
                lamMoi();
            }
            else
            {
                MessageBox.Show("Khóa đang được tham chiếu, hãy xóa bảng phiếu nhập trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (ketQua == 1)
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int ketQua = 0;
            if (ktRong() == false)
            {
                string sqlCapNhat = "update NhaCungCap set Ten = N'" + txt_tennhacc.Text + "', DiaChi = N'" + txt_diachi.Text + "', SoDienThoai = N'" + txt_dienThoai.Text + "' where MaNhaCungCap = '" + txt_manhacc.Text + "'";
                ketQua = kn.getnonquery(sqlCapNhat);
                taiDuLieu();
                lamMoi();
            }
            else
            {
                MessageBox.Show("Các trường không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (ketQua == 1)
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
                MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //Hàm dùng chung
        #region
        public void taiDuLieu()
        {
            dataGrid_nhaCungCap.DataSource = null;
            string sql = "select * from NhaCungCap";
            DataTable ncc = kn.getDatatable(sql);
            dataGrid_nhaCungCap.DataSource = ncc;
        }

        public void lamMoi()
        {
            txt_manhacc.Clear();
            txt_dienThoai.Clear();
            txt_tennhacc.Clear();
            txt_diachi.Clear();
            txt_manhacc.Focus();
        }

        public bool ktKhoaNgoai(string khoa)
        {
            string sqlKhoa = "select count(*) from PhieuNhap where MaNhaCungCap = '" + khoa + "'";
            int ketQua = (int)kn.getScalar(sqlKhoa);
            if (ketQua >= 1)
                return true;
            return false;
        }

        public bool ktRong()
        {
            if (txt_manhacc.Text == "" || txt_tennhacc.Text == "" || txt_dienThoai.Text == "" || txt_diachi.Text == "")
                return true;
            return false;
        }


        #endregion

        private void Qly_NhaCungCap_Load(object sender, EventArgs e)
        {
            taiDuLieu();
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

        private void txt_dienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            kn.onlyNumber(e);
        }
    }
}
