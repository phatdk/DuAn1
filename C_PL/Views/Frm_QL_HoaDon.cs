﻿using A_DAL.Models;
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
    public partial class Frm_QL_HoaDon : Form
    {
        private IHoaDonServices _IHoaDon;
        private List<HoaDon> _lst;
        private ISP_HDServices _SpHD;

        Guid _Id;
        public Frm_QL_HoaDon()
        {
            InitializeComponent();
            _IHoaDon = new HoaDonServices();
            _lst = _IHoaDon.GetAllHoaDon();
            _SpHD = new SP_HDServices();
            LoadHoaDon();
        }
        public void LoadHoaDon()
        {
            dtg_view_hoadon.Rows.Clear();
            dtg_view_hoadon.ColumnCount = 6;
            dtg_view_hoadon.Columns[0].Name = "ID";
            dtg_view_hoadon.Columns[0].Visible = false;
            dtg_view_hoadon.Columns[1].Name = "Ngày tạo";
            dtg_view_hoadon.Columns[2].Name = "Ngày thanh toán";
            dtg_view_hoadon.Columns[3].Name = "Id NV";
            //dtg_view_hoadon.Columns[4].Name = "Tên KM";
            dtg_view_hoadon.Columns[4].Name = "Tổng tiền";
            dtg_view_hoadon.Columns[5].Name = "Trạng thái";
            dtg_view_hoadon.AllowUserToAddRows = false;
            var hd = _IHoaDon.GetAllHoaDon();
            foreach (var item in hd)
            {
                dtg_view_hoadon.Rows.Add(item.Id, item.NgayTao, item.NgayThanhToan, item.IdNv, item.TongTien, item.TrangThai);
                //dtg_view_hoadon.Rows.Add(item.Id, item.NgayTao, item.NgayThanhToan, item.TenNV, item.TenKm, item.TongTien, item.TrangThai);
            }
        }
        public void LoadHoaDonCT(Guid id)
        {
            _Id = id;
            dtg_view_chitiethoadon.Rows.Clear();
            dtg_view_chitiethoadon.ColumnCount = 6;
            dtg_view_chitiethoadon.Columns[0].Name = "IDHd";
            dtg_view_chitiethoadon.Columns[0].Visible = false;
            dtg_view_chitiethoadon.Columns[1].Name = "IDSp";
            dtg_view_chitiethoadon.Columns[1].Visible = false;
            dtg_view_chitiethoadon.Columns[2].Name = "Tên sản phẩm";
            dtg_view_chitiethoadon.Columns[3].Name = "Số lượng";
            dtg_view_chitiethoadon.Columns[4].Name = "Đơn giá";
            dtg_view_chitiethoadon.Columns[5].Name = "Mô tả";
            foreach (var item in _SpHD.GetSP_HDByid(id))
            {
                dtg_view_chitiethoadon.Rows.Add(item.IdHd, item.IdSp, item.TenSp, item.SoLuong, item.DonGia, item.MoTa);
            }
        }
        private void dtg_view_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_view_hoadon.Rows[e.RowIndex];
                LoadHoaDonCT(Guid.Parse(r.Cells[0].Value.ToString()));
            }
        }

        private void btn_inhd_Click(object sender, EventArgs e)
        {
            var hd = _IHoaDon.GetHoaDonByid(_Id).Id;
            Frm_ThongTinHD fm = new Frm_ThongTinHD(hd);
            fm.ShowDialog();
        }

        private void dtp_Ngay_ValueChanged(object sender, EventArgs e)
        {
            dtg_view_hoadon.Rows.Clear();

            var hd = _IHoaDon.GetAllHoaDon().Where(c => c.NgayTao.ToString("dd-MM-yyyy") == dtp_Ngay.Value.ToString("dd-MM-yyyy")).ToList();

            foreach (var h in hd)
            {
                dtg_view_hoadon.Rows.Add(h.Id, h.NgayTao, h.NgayThanhToan, h.IdNv, h.TongTien, h.TrangThai);
            }

        }
    }
}
