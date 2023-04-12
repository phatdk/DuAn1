using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PL.Views
{
    public partial class Frm_ThongTinHD : Form
    {
        IBanServices _banServices;
        ISanPhamServices _sanPhamServices;
        IHoaDonServices _hoaDonServices;
        ISP_HDServices _sP_HDServices;
        IBan_HDServices _ban_HDServices;
        INhanVienServices _nhanVienServices;
        private Guid _Id;
        private PrintDialog printDialog;
        private PrintDocument printDocument;
        public Frm_ThongTinHD(Guid id)
        {
            InitializeComponent();
            _banServices = new BanServices();
            _sanPhamServices = new SanPhamServices();
            _sP_HDServices = new SP_HDServices();
            _ban_HDServices = new Ban_HDServices();
            _hoaDonServices = new HoaDonServices();
            _nhanVienServices = new NhanVienServices();
            LoadHDCT(id);
            this._Id = id;
            this.printDialog = new PrintDialog();
            this.printDocument = new PrintDocument();
            this.printDocument.PrintPage += new PrintPageEventHandler(this.printDocument_PrintPage);
        }



        public void LoadHDCT(Guid id)
        {
            _Id = id;
            dtg_InHoaDon.ColumnCount = 4;
            dtg_InHoaDon.Columns[0].Name = "Id";
            dtg_InHoaDon.Columns[0].Visible = false;
            dtg_InHoaDon.Columns[1].Name = "Tên sản phẩm";
            dtg_InHoaDon.Columns[2].Name = "Số lượng";
            dtg_InHoaDon.Columns[3].Name = "Đơn giá";
            dtg_InHoaDon.Rows.Clear();
            foreach (var item in _sP_HDServices.GetSP_HDByid(id))
            {
                dtg_InHoaDon.Rows.Add(item.IdHd, item.TenSp, item.SoLuong, item.DonGia);
            }
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var hd = _hoaDonServices.GetAllHoaDon().FirstOrDefault(c => c.Id == _Id);
            var nv = _nhanVienServices.GetAllNhanVien().FirstOrDefault(c => c.Id == hd.IdNv);
            //var ban = _banServices.GetAllBan().FirstOrDefault(c => c.Id == _Id);
            e.Graphics.DrawString("Chào mừng bạn đến quán cafe chill", new Font("Arial", 15), Brushes.Black, new Point(300, 100));
            //e.Graphics.DrawString(lbl_dc.Text, new Font("Arial", 10), Brushes.Black, new Point(300, 130));
            e.Graphics.DrawString("Ngày thanh toán :", new Font("Arial", 10), Brushes.Black, new Point(300, 150));
            e.Graphics.DrawString(hd.NgayThanhToan.ToString(), new Font("Arial", 10), Brushes.Black, new Point(420, 150));
            //e.Graphics.DrawString("...................................................................................", new Font("Arial", 10), Brushes.Black, new Point(300, 160));
            e.Graphics.DrawString("Nhân viên thu :", new Font("Arial", 10), Brushes.Black, new Point(300, 180));
            e.Graphics.DrawString(nv.HoTen, new Font("Arial", 10), Brushes.Black, new Point(420, 180));
            //e.Graphics.DrawString("Bàn:", new Font("Arial", 10), Brushes.Black, new Point(300, 180));
            //e.Graphics.DrawString(ban.TenBan, new Font("Arial", 10), Brushes.Black, new Point(420, 180));
            //e.Graphics.DrawString("Tên Khách Hàng", new Font("Arial", 10), Brushes.Black, new Point(300, 200));
            //e.Graphics.DrawString(lbl_kh.Text, new Font("Arial", 10), Brushes.Black, new Point(420, 200));
            e.Graphics.DrawString("......................................................................................", new Font("Arial", 10), Brushes.Black, new Point(300, 220));
            e.Graphics.DrawString("Sản phẩm", new Font("Arial", 10), Brushes.Black, new Point(300, 240));
            e.Graphics.DrawString("Số lượng", new Font("Arial", 10), Brushes.Black, new Point(400, 240));
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 10), Brushes.Black, new Point(500, 240));
            //e.Graphics.DrawString("Thành tiền", new Font("Arial", 10), Brushes.Black, new Point(600, 240));
            int i = 0;
            foreach (var item in _sP_HDServices.GetSP_HDByid(_Id))
            {

                int x = 260;
                int y = 261;
                e.Graphics.DrawString(item.TenSp.ToString(), new Font("Arial", 10), Brushes.Black, new Point(300, x + (i * 45)));
                e.Graphics.DrawString(item.SoLuong.ToString(), new Font("Arial", 10), Brushes.Black, new Point(400, y + (i * 45)));
                e.Graphics.DrawString(item.DonGia.ToString(), new Font("Arial", 10), Brushes.Black, new Point(500, y + (i * 45)));
                //e.Graphics.DrawString(item..ToString(), new Font("Arial", 10), Brushes.Black, new Point(600, y + (i * 45)));
                i++;
            }
            //e.Graphics.DrawString(".....................................................................", new Font("Arial", 10), Brushes.Black, new Point(300, 470));
            int sl = _sP_HDServices.GetSP_HDByid(_Id).Count;
            e.Graphics.DrawString("Tổng Tiền", new Font("Arial", 15), Brushes.Black, new Point(300, 245 + ((sl + 1) * 45)));
            e.Graphics.DrawString(lbTongTien.Text, new Font("Arial", 15), Brushes.Black, new Point(470, 245 + ((sl + 1) * 45)));
            e.Graphics.DrawString("CẢM ƠN QUÝ KHÁCH", new Font("Arial", 10), Brushes.Black, new Point(300, 295 + ((sl + 1) * 45)));
            e.Graphics.DrawString("HẸN GẶP LẠI!", new Font("Arial", 10), Brushes.Black, new Point(300, 315 + ((sl + 1) * 45)));
        }

        private void Frm_ThongTinHD_Load(object sender, EventArgs e)
        {
            var hd = _hoaDonServices.GetAllHoaDon().FirstOrDefault(c => c.Id == _Id);
            var nv = _nhanVienServices.GetAllNhanVien().FirstOrDefault(c => c.Id == hd.IdNv);
            //var ban = _ban_HDServices.GetAllBan_HD().FirstOrDefault(c=>c.IdBan == hd.Ban_HDs);
            lbNgayThanhToan.Text = hd.NgayThanhToan.ToString();
            lbNV.Text = nv.HoTen;
            //lbBan.Text = ban.TenBan;
            lbTongTien.Text = hd.TongTien.ToString();

        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            this.printDialog.Document = this.printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {

                printDocument.Print();
                MessageBox.Show("In thành công");
            }
            else
            {
                MessageBox.Show("In thất bại");
            }
        }
    }
}
