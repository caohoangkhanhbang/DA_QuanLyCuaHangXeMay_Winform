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
    public partial class Main : Form
    {
        DangNhap dangNhap = new DangNhap();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            phanQuyen();
        }

        public void phanQuyen()
        {
            if (dangNhap.phanQuyenTaiKhoan() == 0)
            {
                //Chua co code ------------------------------------//////
            }
        }
        private void xeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qly_Xe qly_xe = new Qly_Xe();
            qly_xe.Show();
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qly_hdbh qly_hdbh = new Qly_hdbh();
            qly_hdbh.ShowDialog();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qly_PhieuNhap qly_phieunhap = new Qly_PhieuNhap();
            qly_phieunhap.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qly_NhanVien qly_nhanvien = new Qly_NhanVien();
            qly_nhanvien.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qly_KhachHang qly_khachhang = new Qly_KhachHang();
            qly_khachhang.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qly_NhaCungCap qly_NhaCungCap = new Qly_NhaCungCap();
            qly_NhaCungCap.Show();
        }

        private void loạiXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qly_loaixe qly_loaixe = new Qly_loaixe();
            qly_loaixe.Show();
        }

        private void hóaĐơnThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phụKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kháchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void xeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void phụKIệnToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnBánHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnThanhToánToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void phiếuNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loạiXeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void bánXeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void hãngXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qly_hangxe ql_hx = new Qly_hangxe();
            ql_hx.ShowDialog();
        }

        private void dòngXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qly_DongXe ql_dx = new Qly_DongXe();
            ql_dx.ShowDialog();
        }

        private void phânKhốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qly_PhanKhoi ql_pk = new Qly_PhanKhoi();
            ql_pk.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Qly_NhanVien qly_nhanvien = new Qly_NhanVien();
            qly_nhanvien.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Qly_Xe qly_xe = new Qly_Xe();
            qly_xe.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Qly_NhaCungCap qly_NhaCungCap = new Qly_NhaCungCap();
            qly_NhaCungCap.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Qly_PhieuNhap qly_phieunhap = new Qly_PhieuNhap();
            qly_phieunhap.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Main frmMain = new Main();
            Qly_KhachHang frmkh = new Qly_KhachHang();
            dangNhap.dongMoForm(frmkh, frmMain);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Main frmMain = new Main();
            Qly_NhanVien frmNha = new Qly_NhanVien();
            dangNhap.dongMoForm(frmNha, frmMain);

        }
    }
}
