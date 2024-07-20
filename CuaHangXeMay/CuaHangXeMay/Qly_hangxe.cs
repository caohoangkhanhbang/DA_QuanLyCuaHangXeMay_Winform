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
    public partial class Qly_hangxe : Form
    {
        DangNhap dangNhapQuyen = new DangNhap();
        DBConnect db = new DBConnect();
        DataTable dt_hangxe = new DataTable();
        string sql = "select *from HangXe";
        public Qly_hangxe()
        {
            dt_hangxe = db.getDatatable(sql);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt_hangxe.Columns[0];
            dt_hangxe.PrimaryKey = key;
            InitializeComponent();
        }
        public void load_datagridview_hangxe()
        {
            string sql = "select *from HangXe";
            DataTable dt_hangxeview = new DataTable();
            dt_hangxeview = db.getDatatable(sql);
            dataGrid_hangxe.DataSource = dt_hangxeview;
         
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void picanh_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Qly_hangxe_Load(object sender, EventArgs e)
        {
            load_datagridview_hangxe();
            phanQuyen();
        }

        public void phanQuyen()
        {
            if (dangNhapQuyen.phanQuyenTaiKhoan() == 0)
            {
                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
            }
            else
            {
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;
            }
        }

    bool ktra_trungmahang(string ma)
    {
        string sql = "select count(*) from HangXe where MaHang= '" + ma + "'";
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
      
            if (txt_tenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hãng xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenhang.Focus();
                return;
            }
            if (txt_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return;
            }
            if (txt_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diachi.Focus();
                return;
            }
           
            if(ktra_trungmahang(txt_mahang.Text)==false)
            {
                MessageBox.Show(" Mã Hãng Này Đã Tồn Tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mahang.Focus();
                return;
            }
            DataRow newrow = dt_hangxe.NewRow();

            newrow["mahang"] = txt_mahang.Text;
            newrow["tenhang"] = txt_tenhang.Text;
            newrow["sodienthoai"] = txt_sdt.Text;
            newrow["diachi"] = txt_diachi.Text;
            newrow["logo"] = txt_logo.Text;

            dt_hangxe.Rows.Add(newrow);
            int kq = db.updateDatabase(dt_hangxe, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                load_datagridview_hangxe();
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
                db.ClearAllTextBoxes(this);
                txt_mahang.Focus();
           
        }
  
    private void btn_upload_Click(object sender, EventArgs e)
    {
        string[] image;
        OpenFileDialog dlgOpen = new OpenFileDialog();
        dlgOpen.Filter = "JPEG Images|*.jpg|PNG Images|*.png| All files|*.*";
        dlgOpen.FilterIndex = 1;
        dlgOpen.Title = "Chọn logo";
        dlgOpen.InitialDirectory = Application.StartupPath;
        if (dlgOpen.ShowDialog() == DialogResult.OK)
        {
            picanh.Image = Image.FromFile(dlgOpen.FileName);
            image = dlgOpen.FileName.ToString().Split('\\');
            txt_logo.Text = image[image.Length-1];      
        }
    }

    private void btn_them_Click_1(object sender, EventArgs e)
    {
        db.ClearAllTextBoxes(this);
        string kytuDau="H";
        string sql= "SELECT TOP 1 MaHang FROM HangXe ORDER BY MaHang DESC";
        txt_mahang.Text = db.taomatudong(kytuDau, sql);
        btn_luu.Enabled = true;
    }
    bool ktra_fkmahang(string ma)
    {
        string sql = "select count(*) from DongXe where MaHang= '" + ma + "'";
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
        if (txt_mahang.Text.Trim().Length == 0)
        {
            MessageBox.Show("Bạn phải nhập mã hãng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_mahang.Focus();
            return;
        }
        if (ktra_fkmahang(txt_mahang.Text) == false)
        {
            MessageBox.Show(" Mã Hãng Này Tồn Tại ở bảng khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_mahang.Focus();
            return;
        }
        DataRow row = dt_hangxe.Rows.Find(txt_mahang.Text);
        if (row != null)
        {
            row.Delete();
        }
        int kq = db.updateDatabase(dt_hangxe, sql);
        if (kq > 0)
        {
            MessageBox.Show("Xóa thành công");
            load_datagridview_hangxe();
        }
        else
        {
            MessageBox.Show("Xóa Không thành công");
        }
    }

    private void btn_sua_Click(object sender, EventArgs e)
    {
        if (txt_mahang.Text.Trim().Length == 0)
        {
            MessageBox.Show("Bạn phải nhập mã hãng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_mahang.Focus();
            return;
        }
        if (txt_tenhang.Text.Trim().Length == 0)
        {
            MessageBox.Show("Bạn phải nhập tên hãng xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_tenhang.Focus();
            return;
        }
        if (txt_sdt.Text.Trim().Length == 0)
        {
            MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_sdt.Focus();
            return;
        }
        if (txt_diachi.Text.Trim().Length == 0)
        {
            MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_diachi.Focus();
            return;
        }
        DataRow row = dt_hangxe.Rows.Find(txt_mahang.Text);
        if (row != null)
        {
            row["tenhang"] = txt_tenhang.Text;
            row["sodienthoai"] = txt_sdt.Text;
            row["diachi"] = txt_diachi.Text;
            row["logo"] = txt_logo.Text;
          
        }
        int kq = db.updateDatabase(dt_hangxe, sql);
        if (kq > 0)
        {
            MessageBox.Show("Sửa thành công");
            load_datagridview_hangxe();
        }
        else
        {
            MessageBox.Show("Sửa Không thành công");
        }
    }

    private void btn_nhaplai_Click(object sender, EventArgs e)
    {
        db.ClearAllTextBoxes(this);
        txt_mahang.Focus();
    }

    private void btn_thoat_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void dataGrid_hangxe_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        txt_mahang.Text = dataGrid_hangxe.CurrentRow.Cells[0].Value.ToString();
        txt_tenhang.Text = dataGrid_hangxe.CurrentRow.Cells[1].Value.ToString();
        txt_sdt.Text = dataGrid_hangxe.CurrentRow.Cells[2].Value.ToString();
        txt_diachi.Text = dataGrid_hangxe.CurrentRow.Cells[3].Value.ToString();
        txt_logo.Text = dataGrid_hangxe.CurrentRow.Cells[4].Value.ToString();
        picanh.Image = Image.FromFile(Application.StartupPath + "\\image\\" + txt_logo.Text);
    }

   
    }
}

