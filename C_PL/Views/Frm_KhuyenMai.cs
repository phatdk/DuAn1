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
    public partial class Frm_KhuyenMai : Form
    {
        IKhuyenMaiServices _khuyenMaiServices;
        public Frm_KhuyenMai()
        {
            InitializeComponent();
            _khuyenMaiServices = new KhuyenMaiServices();
            #region load column
            dtg_view_khuyenmai.ColumnCount = 11;
            dtg_view_khuyenmai.Columns[0].Name = "Id";
            dtg_view_khuyenmai.Columns[0].Visible = false;
            dtg_view_khuyenmai.Columns[1].Name = "STT";
            dtg_view_khuyenmai.Columns[2].Name = "Tên khuyến mại";
            dtg_view_khuyenmai.Columns[3].Name = "Ngày tạo";
            dtg_view_khuyenmai.Columns[4].Name = "Điều kiện giảm";
            dtg_view_khuyenmai.Columns[5].Name = "Phần trăm giảm";
            dtg_view_khuyenmai.Columns[6].Name = "Số tiền giảm";
            dtg_view_khuyenmai.Columns[7].Name = "Ngày bắt đầu";
            dtg_view_khuyenmai.Columns[8].Name = "Ngày kết thúc";
            dtg_view_khuyenmai.Columns[9].Name = "Mô tả";
            dtg_view_khuyenmai.Columns[10].Name = "Trạng thái";
            dtg_view_khuyenmai.AllowUserToAddRows = false;
            #endregion
            LoadView(_khuyenMaiServices.GetAllKhuyenMai());
        }
        public void LoadView(List<KhuyenMai> list)
        {
            List<KhuyenMai> newlist = new List<KhuyenMai>();
            if (rd_chuadung.Checked)
            {
                newlist = list.Where(p => p.TrangThai == 0 && p.NgayKt >= DateTime.Now).ToList();
            }
            else if (rd_dangdung.Checked)
            {
                newlist = list.Where(p => p.TrangThai == 1 && p.NgayKt >= DateTime.Now).ToList();
            }
            else if (rd_hethan.Checked)
            {
                newlist = list.Where(p => p.NgayKt < DateTime.Now).ToList();
            }
            else newlist = list;
            int stt = 0;
            dtg_view_khuyenmai.Rows.Clear();
            foreach (KhuyenMai item in newlist)
            {
                dtg_view_khuyenmai.Rows.Add(item.Id, ++stt, item.Ten, item.NgayTao, item.DkGiam, item.PhamTramGiam, item.SoTienGiam, item.NgayBd, item.NgayKt, item.MoTa, item.TrangThai == 1 ? "Đang sử dụng" : "Chưa sử dụng");
            }
        }
        public List<KhuyenMai> FindKey()
        {
            return _khuyenMaiServices.GetAllKhuyenMai().Where(p => p.Ten.ToLower().Contains(txt_timkiem.Text.ToLower())).ToList();
        }


        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadView(FindKey());
        }

        private void rd_tatca_CheckedChanged(object sender, EventArgs e)
        {
            LoadView(FindKey());
        }

        private void rd_chuadung_CheckedChanged(object sender, EventArgs e)
        {
            LoadView(FindKey());
        }

        private void rd_dangdung_CheckedChanged(object sender, EventArgs e)
        {
            LoadView(FindKey());
        }

        private void rd_hethan_CheckedChanged(object sender, EventArgs e)
        {
            LoadView(FindKey());
        }
    }
}
