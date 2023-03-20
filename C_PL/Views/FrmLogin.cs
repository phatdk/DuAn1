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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Main main = new Frm_Main();
            //Frm_Main main = new Frm_Main(nguoiDungView);
            //main.ID = _check.CheckAccount(txt_taikhoan.Text, txt_matkhau.Text).Id;
            main.Closed += (s, args) => this.Close();
            main.Show();
        }
    }
}
