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
    public partial class Frm_QuanLy : Form
    {
        public Frm_QuanLy()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Frm_QL_NhanVien frm = new Frm_QL_NhanVien();
            LoadFrm(frm);
        }
        void LoadFrm(Form form)
        {
            if (pn_show_ql.Controls.Count > 0)
            {
                pn_show_ql.Controls.Clear();
            }
            form.TopLevel = false;
            pn_show_ql.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void btn_ql_nhanvien_Click(object sender, EventArgs e)
        {
            Frm_QL_NhanVien frm = new Frm_QL_NhanVien();
            LoadFrm(frm);
        }

        private void btn_ql_sanpham_Click(object sender, EventArgs e)
        {
            Frm_QL_SanPham frm = new Frm_QL_SanPham();
            LoadFrm(frm);
        }

        private void btn_ql_loaisp_Click(object sender, EventArgs e)
        {
            Frm_QL_LoaiSp frm = new Frm_QL_LoaiSp();
            LoadFrm(frm);
        }

        private void btn_ql_ban_Click(object sender, EventArgs e)
        {
            Frm_QL_Ban frm = new Frm_QL_Ban();
            LoadFrm(frm);
        }

        private void btn_ql_hoadon_Click(object sender, EventArgs e)
        {
            Frm_QL_HoaDon frm = new Frm_QL_HoaDon();
            LoadFrm(frm);
        }

        private void btn_ql_khuyenmai_Click(object sender, EventArgs e)
        {
            Frm_QL_KhuyenMai frm = new Frm_QL_KhuyenMai();
            LoadFrm(frm);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            Frm_QL_ThongKe frm = new Frm_QL_ThongKe();
            LoadFrm(frm);
        }
    }
}
