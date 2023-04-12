using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PL.Sub_views
{
    public partial class SubFrm_DoiMatKhau : Form
    {
        private INhanVienServices _nhanVienServices;
        public NhanVien _nv = new NhanVien();
        public SubFrm_DoiMatKhau()
        {
            InitializeComponent();
            _nhanVienServices = new NhanVienServices();
            txt_taikhoan.Text = _nv.TaiKhoan;
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = _nhanVienServices.GetNhanVien(_nv.Email);
            if (!txt_matkhaumoi.Text.Equals(""))
            {
                nhanvien.MatKhau = txt_matkhaumoi.Text;
                _nhanVienServices.UpdateNhanVien(nhanvien);
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới");
            }
        }
    }
}
