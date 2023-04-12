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
using Microsoft.Data.SqlClient;

namespace C_PL.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L9TSC4C\SQLEXPRESS;Initial Catalog=CoffeeLord;Persist Security Info=True;User ID=phatdk;Password=123456");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM nhanViens WHERE TaiKhoan = N'" + txt_TaiKhoan.Text + "' and MatKhau = N'" + txt_MatKhau.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Hide();
                Frm_Main Main = new Frm_Main(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(),
                    dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString());
                //Main.Show();
                //Main.FormClosed += MainClosed;
                this.Hide();
                Main.Closed += (s, args) => this.Close();
                Main.Show();
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //this.Hide();
            //Frm_Main main = new Frm_Main();
            ////Frm_Main main = new Frm_Main(nguoiDungView);
            ////main.ID = _check.CheckAccount(txt_taikhoan.Text, txt_matkhau.Text).Id;
            //main.Closed += (s, args) => this.Close();
            //main.Show();           
        }
        private void MainClosed(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
