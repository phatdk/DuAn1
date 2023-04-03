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

namespace C_PL.Views
{
    public partial class Frm_QL_NhanVien : Form
    {
        NhanVien nhanVien;
        List<NhanVien> LstNhanVien;
        INhanVienServices nvServices;
        public Frm_QL_NhanVien()
        {
            InitializeComponent();
            nhanVien = new NhanVien();
            nvServices = new NhanVienServices();
            Show();
        }
        NhanVien GetForm()
        {
            var temptNhanVien = dtg_view_nv.CurrentRow.DataBoundItem as NhanVien;
            NhanVien newNhanVien = temptNhanVien;
            newNhanVien.Id = new Guid();
            newNhanVien.MaNv = txt_manv.Text;
            newNhanVien.HoTen = txt_tennv.Text;
            newNhanVien.Sdt = txt_sdt.Text;
            if (cb_gioitinh.Text == "Nam")
            {
                newNhanVien.GioiTinh = 0;
            }
            else
            {
                newNhanVien.GioiTinh = 1;
            }
            if (cb_chucvu.Text == "ADmin")
            {
                newNhanVien.ChucVu = 0;
            }
            else
            {
                newNhanVien.ChucVu = 1;
            }
            newNhanVien.TaiKhoan = txt_taikhoan.Text;
            newNhanVien.MatKhau = txt_matkhau.Text;
            if (cb_trangthai.Text == "Hoạt động")
            {
                newNhanVien.TrangThai = 0;
            }
            else
            {
                newNhanVien.TrangThai = 1;
            }
            return newNhanVien;
        }
        public void Show()
        {
            LstNhanVien = nvServices.GetAllNhanVien();
            dtg_view_nv.DataSource = LstNhanVien;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                nhanVien = GetForm();
                nvServices.AddNhanVien(nhanVien);
                MessageBox.Show("Thêm thành công", "Thông báo");
                Show();
            }
            else
            {
                return;
            }
        }

        private void dtg_view_nv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var temptNhanVien = dtg_view_nv.CurrentRow.DataBoundItem as NhanVien;
                txt_manv.Text = temptNhanVien.MaNv;
                txt_tennv.Text = temptNhanVien.HoTen;
                cb_gioitinh.SelectedIndex = temptNhanVien.GioiTinh;
                txt_sdt.Text = temptNhanVien.Sdt;
                cb_chucvu.SelectedIndex = temptNhanVien.ChucVu;
                txt_taikhoan.Text = temptNhanVien.TaiKhoan;
                txt_matkhau.Text = temptNhanVien.MatKhau;
                cb_trangthai.SelectedIndex = temptNhanVien.TrangThai;
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temptNhanVien = dtg_view_nv.CurrentRow.DataBoundItem as NhanVien;
            Guid id = temptNhanVien.Id;
            DialogResult dialog = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                nhanVien = GetForm();
                nhanVien.Id = id;
                nvServices.UpdateNhanVien(nhanVien);
                Show();
            }
            else
            {
                return;
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temptNhanVien = dtg_view_nv.CurrentRow.DataBoundItem as NhanVien;
            Guid id = temptNhanVien.Id;
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                nhanVien = GetForm();
                nhanVien.Id = id;
                nvServices.DeleteNhanVien(id);
                MessageBox.Show("Xóa thành công", "Thông báo");
                Show();
            }
            else
            {
                return;
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

            dtg_view_nv.DataSource = (from x in LstNhanVien where x.MaNv.Contains(txt_timkiem.Text) select x).ToList();  
        }
    }
}
