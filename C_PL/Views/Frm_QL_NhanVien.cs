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
        public Frm_QL_NhanVien()
        {
            InitializeComponent();
        }
        public void Show()
        {
            dtg_view_nv.ColumnCount = 8;
            dtg_view_nv.Columns[0].Name = "Mã nhân viên";
            dtg_view_nv.Columns[1].Name = "Tên nhân viên";
            dtg_view_nv.Columns[2].Name = "Giới tính";
            dtg_view_nv.Columns[3].Name = "Số điện thoại";
            dtg_view_nv.Columns[4].Name = "Chức vụ";
            dtg_view_nv.Columns[5].Name = "Tài khoản";
            dtg_view_nv.Columns[6].Name = "Mật khẩu";
            dtg_view_nv.Columns[7].Name = "Trạng thái";
            int index = 1;
            dtg_view_nv.Rows.Clear();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
