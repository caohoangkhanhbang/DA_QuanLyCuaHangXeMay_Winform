﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangXeMay
{
    public class TaiKhoan
    {
        private string tenDangNhap;

        public string TenDangNhap
        {
          get { return tenDangNhap; }
          set { tenDangNhap = value; }
        }
        private string tenHienThi;

        public string TenHienThi
        {
            get { return tenHienThi; }
            set { tenHienThi = value; }
        }
        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        private string quyen;

        public string Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        //public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        //public string TenHienThi { get => tenHienThi; set => tenHienThi = value; }
        //public string MatKhau { get => matKhau; set => matKhau = value; }
        //public string Quyen { get => quyen; set => quyen = value; }
        //public string Email { get => email; set => email = value; }
        public TaiKhoan(string tenDangNhap, string tenHienThi, string matKhau, string quyen, string email)
        {
            TenDangNhap = tenDangNhap;
            TenHienThi = tenHienThi;
            MatKhau = matKhau;
            Quyen = quyen;
            Email = email;
            TenDangNhap = tenDangNhap;
            TenHienThi = tenHienThi;
            MatKhau = matKhau;
            Quyen = quyen;
            Email = email;
        }

        public TaiKhoan()
        {

        }    

    }
}
