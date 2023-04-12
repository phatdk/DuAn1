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
        INhanVienServices _nhanVienServices;
        Guid _id;
        public Frm_QL_NhanVien()
        {
            InitializeComponent();
            _nhanVienServices = new NhanVienServices();
            #region load column
            dtg_view_nv.ColumnCount = 11;
            dtg_view_nv.Columns[0].Name = "Id";
            dtg_view_nv.Columns[0].Visible = false;
            dtg_view_nv.Columns[1].Name = "STT";
            dtg_view_nv.Columns[2].Name = "Mã nhân viên";
            dtg_view_nv.Columns[3].Name = "Tên nhân viên";
            dtg_view_nv.Columns[4].Name = "Giới tính";
            dtg_view_nv.Columns[5].Name = "Số điện thoại";
            dtg_view_nv.Columns[6].Name = "Email";
            dtg_view_nv.Columns[7].Name = "Chức vụ";
            dtg_view_nv.Columns[8].Name = "Tài khoản";
            dtg_view_nv.Columns[9].Name = "Mật khẩu";
            dtg_view_nv.Columns[10].Name = "Trạng thái";
            dtg_view_nv.AllowUserToAddRows = false;
            #endregion
            LoadView(_nhanVienServices.GetAllNhanVien());
        }
        public void LoadView(List<NhanVien> list)
        {
            List<NhanVien> newlist = new List<NhanVien>();
            if (rd_hoatdong.Checked)
            {
                newlist = list.Where(p => p.TrangThai == 0).ToList();
            }
            else if (rd_khonghoatdong.Checked)
            {
                newlist = list.Where(p => p.TrangThai == 1).ToList();
            }
            else newlist = list;
            int stt = 0;
            dtg_view_nv.Rows.Clear();
            foreach (NhanVien item in newlist)
            {
                dtg_view_nv.Rows.Add(item.Id, ++stt, item.MaNv, item.HoTen, item.GioiTinh == 1 ? "Nam" : "Nữ", item.Sdt, item.Email, item.ChucVu == 1 ? "Admin" : "Staff", item.TaiKhoan, item.MatKhau, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        public void ClearFrm()
        {
            _id = Guid.Empty;
            txt_manv.Text = "";
            txt_tennv.Text = "";
            cb_gioitinh.Text = "";
            cb_chucvu.Text = "";
            txt_sdt.Text = "";
            txt_taikhoan.Text = "";
            txt_matkhau.Text = "";
            txt_email.Text = "";
        }
        public List<NhanVien> FindKey()
        {
            return _nhanVienServices.GetAllNhanVien().Where(p => p.HoTen.ToLower().Contains(txt_timkiem.Text.ToLower()) 
            || p.MaNv.ToLower().Contains(txt_timkiem.Text.ToLower())).ToList();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Id = Guid.NewGuid();
            nv.MaNv = txt_manv.Text;
            nv.HoTen = txt_tennv.Text;
            nv.GioiTinh = cb_gioitinh.Text.Contains("Nam") ? 1 : 0;
            nv.ChucVu = cb_chucvu.Text.Contains("ADmin") ? 1 : 0;
            nv.Sdt = txt_sdt.Text;
            nv.Email = txt_email.Text;
            nv.TaiKhoan = txt_taikhoan.Text;
            nv.MatKhau = txt_matkhau.Text;
            nv.TrangThai = cb_trangthai.Text.Contains("Hoạt động") ? 1 : 0;
            if (_nhanVienServices.AddNhanVien(nv))
            {
                MessageBox.Show("Add done");
                ClearFrm();
                LoadView(_nhanVienServices.GetAllNhanVien());
            }
            else MessageBox.Show("Add false");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Id = _id;
            nv.MaNv = txt_manv.Text;
            nv.HoTen = txt_tennv.Text;
            nv.GioiTinh = cb_gioitinh.Text.Contains("Nam") ? 1 : 0;
            nv.ChucVu = cb_chucvu.Text.Contains("ADmin") ? 1 : 0;
            nv.Sdt = txt_sdt.Text;
            nv.Email = txt_email.Text;
            nv.TaiKhoan = txt_taikhoan.Text;
            nv.MatKhau = txt_matkhau.Text;
            nv.TrangThai = cb_trangthai.Text.Contains("Hoạt động") ? 1 : 0;
            if (_nhanVienServices.UpdateNhanVien(nv))
            {
                MessageBox.Show("Update done");
                ClearFrm();
                LoadView(_nhanVienServices.GetAllNhanVien());
            }
            else MessageBox.Show("Update false");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (_nhanVienServices.DeleteNhanVien(_id))
                {
                    MessageBox.Show("Delete done");
                    ClearFrm();
                    LoadView(_nhanVienServices.GetAllNhanVien());
                }
                else MessageBox.Show("Delete false");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFrm();
        }

        private void dtg_view_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_view_nv.CurrentRow.Cells[0].Value.ToString());
            txt_manv.Text = dtg_view_nv.CurrentRow.Cells[2].Value.ToString();
            txt_tennv.Text = dtg_view_nv.CurrentRow.Cells[3].Value.ToString();
            cb_gioitinh.Text = dtg_view_nv.CurrentRow.Cells[4].Value.ToString();
            txt_sdt.Text = dtg_view_nv.CurrentRow.Cells[5].Value.ToString();
            txt_email.Text = dtg_view_nv.CurrentRow.Cells[6].Value.ToString();
            cb_chucvu.Text = dtg_view_nv.CurrentRow.Cells[7].Value.ToString();
            txt_taikhoan.Text = dtg_view_nv.CurrentRow.Cells[8].Value.ToString();
            txt_matkhau.Text = dtg_view_nv.CurrentRow.Cells[9].Value.ToString();
            cb_trangthai.Text = dtg_view_nv.CurrentRow.Cells[10].Value.ToString();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadView(FindKey());
        }
    }
}
