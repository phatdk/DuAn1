using Microsoft.EntityFrameworkCore;
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
    public partial class SubFrm_ThongTinNhanVien : Form
    {
        public string Id;
        public string MaNv = "", HoTen = "", GioiTinh = "", Sdt = "", ChucVu = "", TaiKhoan = "", MatKhau = "", TrangThai = "";

        public SubFrm_ThongTinNhanVien(string id = null, string maNv = null, string hoTen = null, string gioiTinh = null, string sdt = null, string chucVu = null, string taiKhoan = null, string matKhau = null, string trangThai = null)
        {
            InitializeComponent();
            Id = id;
            MaNv = maNv;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            Sdt = sdt;
            ChucVu = chucVu;
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            TrangThai = trangThai;
            lbMaNV.Text = MaNv;
            lbTenNV.Text = HoTen;
            lbTaiKhoan.Text = TaiKhoan;
            lbMatKhau.Text = "******";
            if (GioiTinh == "0")
            {
                lbGioiTinh.Text = "Nam";
            }
            else
            {
                lbGioiTinh.Text = "Nữ";
            }
            if (chucVu == "1")
            {
                lbChucVu.Text = "ADmin";
            }
            else
            {
                lbChucVu.Text = "Nhân viên bán hàng";
            }

            lbSdt.Text = Sdt;
            lbTrangThai.Text = "Hoạt động";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SubFrm_ThongTinNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
