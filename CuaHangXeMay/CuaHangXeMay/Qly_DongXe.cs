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
    public partial class Qly_DongXe : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_dongxe = new DataTable();
        DangNhap dangNhapQuyen = new DangNhap();

        string sql = "select *from DongXe";
        public Qly_DongXe()
        {
            dt_dongxe = db.getDatatable(sql);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt_dongxe.Columns[0];
            dt_dongxe.PrimaryKey = key;
            InitializeComponent();
        }
        public void load_comboLoai()
        {
            string sql = "select * from  LoaiXe ";
            DataTable dt_loai = new DataTable();
            dt_loai = db.getDatatable(sql);
            cbo_loai.DataSource = dt_loai;
            cbo_loai.ValueMember = "maloaixe";
            cbo_loai.DisplayMember = "tenloaixe";
        }
        public void load_comboHang()
        {
            string sql = "select * from  HangXe ";
            DataTable dt_hang = new DataTable();
            dt_hang = db.getDatatable(sql);
            cbo_hang.DataSource = dt_hang;
            cbo_hang.ValueMember = "mahang";
            cbo_hang.DisplayMember = "tenhang";
        }
        public void load_combophankhoi()
        {
            string sql = "select * from  PhanKhoi ";
            DataTable dt_phankhoi = new DataTable();
            dt_phankhoi = db.getDatatable(sql);
            cbo_phankhoi.DataSource = dt_phankhoi;
            cbo_phankhoi.ValueMember = "maphankhoi";
            cbo_phankhoi.DisplayMember = "tenphankhoi";
        }
        public void load_datagridview_dongxe()
        {
            string sql = "select *from DongXe where MaLoai='" + cbo_loai.SelectedValue.ToString() + "'";
            DataTable dt_dongtheomaloai = db.getDatatable(sql);
            dgv_dongxe.DataSource = dt_dongtheomaloai;
            Databingding(dt_dongtheomaloai);

        }
        public void load_dgv_dongxetheohang()
        {
            string sql = "select *from DongXe where MaHang='" + cbo_hang.SelectedValue.ToString() + "'";
            DataTable dt_dongtheomahang = db.getDatatable(sql);
            dgv_dongxe.DataSource = dt_dongtheomahang;
        }
        public void load_dgv_dongxetheophankhoi()
        {
            string sql = "select *from DongXe where PhanKhoi='" + cbo_phankhoi.SelectedValue.ToString() + "'";
            DataTable dt_dongtheophankhoi = db.getDatatable(sql);
            dgv_dongxe.DataSource = dt_dongtheophankhoi;

        }
        private void Qly_DongXe_Load(object sender, EventArgs e)
        {
            load_comboHang();
            load_comboLoai();
            load_combophankhoi();
            phanQuyen();
            reset();
        }

        private void cbo_loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_datagridview_dongxe();
        }

        private void cbo_hang_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_dgv_dongxetheohang();
        }

        private void cbo_phankhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_dgv_dongxetheophankhoi();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            db.ClearAllTextBoxes(this);
            string kytuDau = "DX";
            string sql = "SELECT TOP 1 MaDongXe FROM DongXe ORDER BY MaDongXe DESC";
            txt_ma.Text = db.taomatudong(kytuDau, sql);
            btn_luu.Enabled = true;
        }
        bool ktra_trungma(string ma)
        {
            string sql = "select count(*) from DongXe where MaDongXe= '" + ma + "'";
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
            if (cbo_loai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn loại xe ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_loai.Focus();
                return;
            }
            if (cbo_hang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn hãng sản xuất ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_hang.Focus();
                return;
            }
            if (cbo_phankhoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn phân khối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_phankhoi.Focus();
                return;
            }
            if (txt_ma.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải tạo mã dòng xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ma.Focus();
                return;
            }

            if (ktra_trungma(txt_ma.Text) == false)
            {
                MessageBox.Show(" Mã Dòng Xe Này Đã Tồn Tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ma.Focus();
                return;
            }
            DataRow newrow = dt_dongxe.NewRow();

            newrow["madongxe"] = txt_ma.Text;
            newrow["tendongxe"] = txt_ten.Text;
            newrow["tinhnang"] = txt_tinhnang.Text;
            newrow["maloai"] = cbo_loai.SelectedValue.ToString();
            newrow["phankhoi"] = cbo_phankhoi.SelectedValue.ToString();
            newrow["mahang"] = cbo_hang.SelectedValue.ToString();
            dt_dongxe.Rows.Add(newrow);
            int kq = db.updateDatabase(dt_dongxe, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                load_datagridview_dongxe();

            }
            else
            {
                MessageBox.Show("Không thành công");
            }

            reset();
            txt_ma.Focus();
        }
        bool ktra_fkma(string ma)
        {
            string sql = "select count(*) from XeGanMay where MaDongXe= '" + ma + "'";
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

        public void phanQuyen()
        {
            if (dangNhapQuyen.phanQuyenTaiKhoan() == 0)
            {
                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
            }
            //else
            //{
            //    btn_xoa.Enabled = true;
            //    btn_sua.Enabled = true;
            //}
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ///////
            if (dangNhapQuyen.phanQuyenTaiKhoan() == 1 || dangNhapQuyen.phanQuyenTaiKhoan() == 10)
            {
                if (txt_ma.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã để xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ma.Focus();
                    return;
                }
                if (ktra_fkma(txt_ma.Text) == false)
                {
                    MessageBox.Show(" Mã Dòng Xe Này Tồn Tại ở bảng khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ma.Focus();
                    return;
                }
                DataRow row = dt_dongxe.Rows.Find(txt_ma.Text);
                if (row != null)
                {
                    row.Delete();
                }
                int kq = db.updateDatabase(dt_dongxe, sql);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    load_datagridview_dongxe();
                }
                else
                {
                    MessageBox.Show("Xóa Không thành công");
                }
            }
            else
            {
                btn_xoa.Enabled = false;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (cbo_loai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn loại xe ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_loai.Focus();
                return;
            }
            if (cbo_hang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn hãng sản xuất ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_hang.Focus();
                return;
            }
            if (cbo_phankhoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn phân khối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_phankhoi.Focus();
                return;
            }
            if (txt_ma.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã để sữa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ma.Focus();
                return;
            }
            DataRow row = dt_dongxe.Rows.Find(txt_ma.Text);
            if (row != null)
            {
                row["tendongxe"] = txt_ten.Text;
                row["tinhnang"] = txt_tinhnang.Text;
                row["phankhoi"] = cbo_phankhoi.SelectedValue.ToString();
                row["maloai"] = cbo_loai.SelectedValue.ToString();
                row["mahang"] = cbo_hang.SelectedValue.ToString();
            }
            int kq = db.updateDatabase(dt_dongxe, sql);
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công");
                load_datagridview_dongxe();
            }
            else
            {
                MessageBox.Show("Sửa Không thành công");
            }
        }
        public void reset()
        {
            cbo_phankhoi.Text = "";
            cbo_loai.Text = "";
            cbo_hang.Text = "";
            db.ClearAllTextBoxes(this);
        }
        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Databingding(DataTable pDT)
        {
            txt_ma.DataBindings.Clear();
            txt_ten.DataBindings.Clear();
            cbo_loai.DataBindings.Clear();
            cbo_hang.DataBindings.Clear();
            cbo_phankhoi.DataBindings.Clear();
            txt_tinhnang.DataBindings.Clear();
            txt_ma.DataBindings.Add("Text", pDT, "madongxe");
            txt_ten.DataBindings.Add("Text", pDT, "tendongxe");
            txt_tinhnang.DataBindings.Add("Text", pDT, "tinhnang");
            cbo_phankhoi.DataBindings.Add("SelectedValue", pDT, "phankhoi");
            cbo_loai.DataBindings.Add("SelectedValue", pDT, "maloai");
            cbo_hang.DataBindings.Add("SelectedValue", pDT, "mahang");
        }
    }
}