using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CuaHangXeMay
{
    public partial class Qly_Xe : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_xe = new DataTable();
        string sql = "select *from LoaiXeGanMay";
        public Qly_Xe()
        {
            dt_xe = db.getDatatable(sql);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt_xe.Columns[0];
            dt_xe.PrimaryKey = key;
            InitializeComponent();
        }
        public void load_combodongxe()
        {
            string sql = "select * from  DongXe ";
            DataTable dt_dongxe = new DataTable();
            dt_dongxe = db.getDatatable(sql);
            cbo_madongxe.DataSource = dt_dongxe;
            cbo_madongxe.ValueMember = "madongxe";
            cbo_madongxe.DisplayMember = "tendongxe";
        }
        public void load_datagridview_xe()
        {
            string sql = "select *from LoaiXeGanMay where MaDongXe='" + cbo_madongxe.SelectedValue.ToString() + "'";
            DataTable dt_xetheodongxe = db.getDatatable(sql);
            dgv_xemay.DataSource = dt_xetheodongxe;
            Databingding(dt_xetheodongxe);

        }


        private void Qly_Xe_Load(object sender, EventArgs e)
        {
            load_combodongxe();
            load_datagridview_xe();
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

            if (txt_ma.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã để xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ma.Focus();
                return;
            }

            if (ktra_fkmaxe(txt_ma.Text) == false)
            {
                MessageBox.Show(" Số Khung Xe Này Tồn Tại ở bảng khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ma.Focus();
                return;
            }
            DataRow row = dt_xe.Rows.Find(txt_ma.Text);
            if (row != null)
            {
                row.Delete();
            }
            int kq = db.updateDatabase(dt_xe, sql);
            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công");
                load_datagridview_xe();
            }
            else
            {
                MessageBox.Show("Xóa Không thành công");
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            db.ClearAllTextBoxes(this);
            txt_ma.Focus();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_ma.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại xe để sữa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ma.Focus();
                return;
            }
            if (txt_tenxe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenxe.Focus();
                return;
            }
           
            if (txt_namsx.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập năm sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_namsx.Focus();
                return;
            }
            if (txt_mausac.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập màu sắc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mausac.Focus();
                return;
            }
            if (txt_giaban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_giaban.Focus();
                return;
            }
           
            if (cbo_madongxe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã dòng xe ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_madongxe.Focus();
                return;
            }
            if (txt_anh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_anh.Focus();
                return;
            }
            DataRow row = dt_xe.Rows.Find(txt_ma.Text);
            if (row != null)
            {
                row["tenxe"] = txt_tenxe.Text;
                row["madongxe"] = cbo_madongxe.SelectedValue.ToString();
                row["tenhang"] = txt_tenhang.Text;
                row["tenloai"] = txt_tenloai.Text;
                row["namsanxuat"] = txt_namsx.Text;
                row["mausac"] = txt_mausacc.Text;
                row["giaban"] = txt_giaban.Text;
                row["anh"] = txt_anh.Text;
          
            }
            int kq = db.updateDatabase(dt_xe, sql);
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công");
                load_datagridview_xe();
            }
            else
            {
                MessageBox.Show("Sửa Không thành công");
            }

        }
      
       
        bool ktra_fkmaxe(string ma)
        {
            string sql = "SELECT SUM(total_count) AS total FROM ( SELECT COUNT(*) AS total_count FROM ChiTietPhieuNhap WHERE SoKhungXe = '" + ma + "' UNION ALL SELECT COUNT(*) AS total_count FROM ChiTietHoaDon WHERE SoKhungXe = '" + ma + "' ) AS counts";
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

        private void txt_maxe_Leave(object sender, EventArgs e)
        {
            //Control ctr = (Control)sender;
            //if (ctr.Text.Trim().Length == 0)
            //{
            //    this.error_chuanhap.SetError(ctr, "Bạn phải nhập vào ô " + ctr.Text + "");
            //}
            //else
            //{
            //    this.error_chuanhap.Clear();
            //}
        }

        private void txt_giaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbo_maloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_datagridview_xe();
        }

        private void Databingding(DataTable pDT)
        {
            txt_ma.DataBindings.Clear();
            txt_tenxe.DataBindings.Clear();
            txt_namsx.DataBindings.Clear();
            txt_mausacc.DataBindings.Clear();
            txt_giaban.DataBindings.Clear();
            txt_tenhang.DataBindings.Clear();
            txt_tenloai.DataBindings.Clear();
            cbo_madongxe.DataBindings.Clear();
            txt_anh.DataBindings.Clear();
            txt_ma.DataBindings.Add("Text", pDT, "maloaixeganmay");
            txt_tenxe.DataBindings.Add("Text", pDT, "tenxe");
            txt_tenhang.DataBindings.Add("Text", pDT, "tenhang");
            txt_namsx.DataBindings.Add("Text", pDT, "namsanxuat");
            txt_mausacc.DataBindings.Add("Text", pDT, "mausac");
            txt_giaban.DataBindings.Add("Text", pDT, "giaban");
            cbo_madongxe.DataBindings.Add("SelectedValue", pDT, "madongxe");
            txt_tenloai.DataBindings.Add("Text", pDT, "tenloai");
            txt_anh.DataBindings.Add("Text", pDT, "anh");
          
        }

        private void dataGridview_Xe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string[] image;
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "JPEG Images|*.jpg|PNG Images|*.png| All files|*.*";
            dlgOpen.FilterIndex = 1;
            dlgOpen.Title = "Chọn ảnh minh họa chon sản phẩm";
            dlgOpen.InitialDirectory = Application.StartupPath;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picanh.Image = Image.FromFile(dlgOpen.FileName);
                image = dlgOpen.FileName.ToString().Split('\\');
                txt_anh.Text = image[image.Length - 1];
            }
        }

        private void txt_namsx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbo_madongxe_TextChanged(object sender, EventArgs e)
        {
            string strmaloai,strmahang;
            if (cbo_madongxe.Text == "")
            {
               txt_tenloai.Text="";
               txt_tenhang.Text = "";
            }
            else
            {
                strmaloai = "select l.TenLoaiXe from LoaiXe as l inner join DongXe as D on l.MaLoaiXe=d.maloai where d.madongxe= '"+cbo_madongxe.SelectedValue+"'";
                txt_tenloai.Text = db.GetFieldValues(strmaloai);
                strmahang = "select h.TenHang from HangXe as h inner join DongXe as D on h.MaHang=d.mahang where d.madongxe= '"+cbo_madongxe.SelectedValue+"'";
                txt_tenhang.Text = db.GetFieldValues(strmahang);
            }
        }

        private void txt_sokhung_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_somay_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_ma.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại xe ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txt_ma.Focus();
                return;
            }
            if (txt_tenxe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên xe ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenxe.Focus();
                return;
            }
            if (txt_mausac.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập màu sắc ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mausac.Focus();
                return;
            }
            if (txt_giaban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bán ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_giaban.Focus();
                return;
            }
            if (txt_namsx.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập năm sản xuất ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_namsx.Focus();
                return;
            }
           
            DataRow newrow = dt_xe.NewRow();

            newrow["maloaixeganmay"] = txt_ma.Text;
            newrow["tenxe"] = txt_tenxe.Text;
            newrow["madongxe"] = cbo_madongxe.SelectedValue.ToString();
            newrow["tenhang"] = txt_tenhang.Text;
            newrow["tenloai"] = txt_tenloai.Text;
            newrow["namsanxuat"] = txt_namsx.Text;
            newrow["mausac"] = txt_mausacc.Text;
            newrow["giaban"] = txt_giaban.Text;
            newrow["anh"] = txt_anh.Text;
            dt_xe.Rows.Add(newrow);
            int kq = db.updateDatabase(dt_xe, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                load_datagridview_xe();
                reset();
            }
            else
            {
                MessageBox.Show("Không thành công");
            }

        }

        private void dgv_xemay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_xemay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            picanh.Image = Image.FromFile(Application.StartupPath + "\\image\\" + txt_anh.Text);
        }

        private void cbo_madongxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_datagridview_xe();
        }
        private void reset ()
        {
            txt_ma.Clear();
            txt_tenxe.Clear();
            txt_namsx.Clear();
            txt_mausacc.Clear();
            txt_giaban.Clear();
            txt_anh.Clear();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            reset();
            string kytuDau = "LX";
            string sql = "SELECT TOP 1 MaLoaiXeGanMay FROM LoaiXeGanMay ORDER BY MaLoaiXeGanMay DESC";
            txt_ma.Text = db.taomatudong(kytuDau, sql);
            btn_luu.Enabled = true;
        }



    }
}
  

