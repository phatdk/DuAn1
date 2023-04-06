using C_PL.Sub_views;
using Microsoft.Data.SqlClient;
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
    public partial class Frm_Main : Form
    {
        string Id;
        string MaNv = "", HoTen = "", GioiTinh = "", Sdt = "", ChucVu = "", TaiKhoan = "", MatKhau = "", TrangThai = "";
        string ketnoi = @"Data Source=LAPTOP-JRKLACDR\SQLEXPRESS;Initial Catalog=Du_An_1;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        public Frm_Main(string id, string maNv, string hoTen, string gioiTinh, string sdt, string chucVu, string taiKhoan, string matKhau, string trangThai)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Frm_BanHang frm = new Frm_BanHang(Guid.Parse(id));
            LoadFrm(frm);
            Id = id;
            MaNv = maNv;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            Sdt = sdt;
            ChucVu = chucVu;
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            TrangThai = trangThai;
            lb_nhanvien.Text = "Chức vụ : " + (int.Parse(chucVu) == 1 ? "Admin" : "Nhân viên bán hàng");
            lb_chucvu.Text = "Xin chào : " + hoTen;
        }
        public Frm_Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Frm_BanHang frm = new Frm_BanHang();
            LoadFrm(frm);
            //this.TaiKhoan = TaiKhoan;
            //this.MatKhau = MatKhau;
            //this.ChucVu = ChucVu;
        }
        void LoadFrm(Form form)
        {
            if (pn_show.Controls.Count > 0)
            {
                pn_show.Controls.Clear();
            }
            form.TopLevel = false;
            pn_show.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BanHang frm = new Frm_BanHang();
            LoadFrm(frm);
        }
        // mất sự kiện
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // mất sự kiện
        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tms_banhang_Click(object sender, EventArgs e)
        {
            Frm_BanHang frm = new Frm_BanHang();
            LoadFrm(frm);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frm = new FrmLogin();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
        private void aDminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ChucVu.Trim() == "1")
            {
                Frm_QuanLy frm = new Frm_QuanLy();
                LoadFrm(frm);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubFrm_ThongTinNhanVien tt = new SubFrm_ThongTinNhanVien();
            tt.Show();
        }
    }
}
