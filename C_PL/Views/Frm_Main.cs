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
        public Frm_Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Frm_BanHang frm = new Frm_BanHang();
            LoadFrm(frm);
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
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
            Frm_QuanLy frm = new Frm_QuanLy();
            LoadFrm(frm);
        }
    }
}
