using A_DAL.Models;
using B_BUS.ViewModels;
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
    public partial class SubFrm_AddSanPham : Form
    {
        public SubFrm_AddSanPham(object sender, List<HoaDonVm> list)
        {
            InitializeComponent();
            List<HoaDonVm> hoaDonVms = list;
            if (sender != null)
            {
                SanPham sp = (SanPham)sender;
                lb_tensp.Text = sp.TenSp;
                lb_dongia.Text = sp.GiaBan.ToString();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            
        }
    }
}
