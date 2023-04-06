using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using Microsoft.VisualBasic;
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
    public partial class Frm_BanHang : Form
    {
        ILoaiSpServices _loaiSpServices;
        IKhuyenMaiServices _khuyenMaiServices;
        IBanServices _banServices;
        ISanPhamServices _sanPhamServices;
        IHoaDonServices _hoaDonServices;
        ISP_HDServices _sP_HDServices;
        IBan_HDServices _ban_HDServices;
        List<HoaDonVm> hd;
        Guid _idHd;
        Guid _idNv;
        Guid _idBan;
        bool _checkOut = true;
        public Frm_BanHang()
        {
            _loaiSpServices = new LoaiSpServices();
            _khuyenMaiServices = new KhuyenMaiServices();
            _banServices = new BanServices();
            _sanPhamServices = new SanPhamServices();
            _sP_HDServices = new SP_HDServices();
            _ban_HDServices = new Ban_HDServices();
            _hoaDonServices = new HoaDonServices();
            InitializeComponent();
            #region loadview
            dtg_view_hd.ColumnCount = 8;
            dtg_view_hd.Columns[0].Name = "Id";
            dtg_view_hd.Columns[0].Visible = false;
            dtg_view_hd.Columns[1].Name = "STT";
            dtg_view_hd.Columns[1].Width = 60;
            dtg_view_hd.Columns[2].Name = "Tên sản phẩm";
            dtg_view_hd.Columns[3].Name = "Đơn giá";
            dtg_view_hd.Columns[4].Name = "Số lượng";
            dtg_view_hd.Columns[5].Name = "Thành tiền";
            dtg_view_hd.Columns[6].Name = "Mô tả";
            dtg_view_hd.AllowUserToAddRows = false;
            LoadCbb();
            List<Ban> SortListBan = _banServices.GetAllBan().OrderBy(p => p.TenBan).ToList();
            LoadBan(SortListBan);
            List<SanPham> SortListSanPham = _sanPhamServices.GetAllSanPham().OrderBy(p => p.IdLoai).ToList();
            LoadSp(SortListSanPham);
            #endregion
        }
        public Frm_BanHang(Guid idNv)
        {
            _idNv = idNv;
            _loaiSpServices = new LoaiSpServices();
            _khuyenMaiServices = new KhuyenMaiServices();
            _banServices = new BanServices();
            _sanPhamServices = new SanPhamServices();
            _sP_HDServices = new SP_HDServices();
            _ban_HDServices = new Ban_HDServices();
            _hoaDonServices = new HoaDonServices();
            InitializeComponent();
            #region loadview
            dtg_view_hd.ColumnCount = 8;
            dtg_view_hd.Columns[0].Name = "Idsp";
            dtg_view_hd.Columns[0].Visible = false;
            dtg_view_hd.Columns[1].Name = "STT";
            dtg_view_hd.Columns[2].Name = "Tên sản phẩm";
            dtg_view_hd.Columns[3].Name = "Đơn giá";
            dtg_view_hd.Columns[4].Name = "Số lượng";
            dtg_view_hd.Columns[5].Name = "Thành tiền";
            dtg_view_hd.Columns[6].Name = "Mô tả";
            dtg_view_hd.Columns[7].Name = "Ghi chú";
            dtg_view_hd.AllowUserToAddRows = false;
            LoadCbb();
            List<Ban> SortList = _banServices.GetAllBan().OrderBy(p => p.TenBan).ToList();
            LoadBan(SortList);
            List<SanPham> SortListSanPham = _sanPhamServices.GetAllSanPham().OrderBy(p => p.IdLoai).ToList();
            LoadSp(SortListSanPham);
            #endregion
        }

        public void LoadView(List<HoaDonVm> list)
        {
            int stt = 0;
            int thanhtien = 0;
            int tongtien = 0;
            dtg_view_hd.Rows.Clear();
            var SortList = list.OrderBy(p => p.TenSp);
            foreach (HoaDonVm item in SortList)
            {
                thanhtien = item.DonGia * item.SoLuong;
                tongtien += thanhtien;
                dtg_view_hd.Rows.Add(item.IdSp, ++stt, item.TenSp, item.DonGia, item.SoLuong, thanhtien, item.MoTa);
            }
            //Guid _idKm = (Guid)_hoaDonServices.GetHoaDonByid(_idHd).IdKm;
            //cb_khuyenmai.Text = _idKm == Guid.Empty ? "" : _khuyenMaiServices.GetKhuyenMaiByid(_idKm).Ten;
            lb_tongtien.Text = tongtien.ToString();
            lb_tongtienconlai.Text = tongtien.ToString();
            txt_tientra.Text = "0";
            if (!txt_tientra.Text.Contains(""))
            {
                lb_tienthua.Text = (int.Parse(txt_tientra.Text) - int.Parse(lb_tongtienconlai.Text)).ToString();
            }
            else lb_tienthua.Text = "-" + lb_tongtienconlai.Text;

        }
        public void LoadBan(List<Ban> list)
        {
            fl_ban.Controls.Clear();
            foreach (Ban b in list)
            {
                Button btn = new Button()
                {
                    Width = 130,
                    Height = 100,
                    FlatStyle = FlatStyle.Standard,
                    Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    Tag = b,
                    Text = "Bàn" + " " + b.TenBan,
                };
                btn.Click += Btn_Click;
                if (b.TrangThai == 1) btn.BackColor = Color.Cyan;
                else btn.BackColor = Color.HotPink;
                fl_ban.Controls.Add(btn);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            // _idBan = Guid.Empty;
            if (_checkOut == true)
            {
                Ban ban = (Ban)((Button)sender).Tag;
                _idBan = ban.Id;
                lb_banchon.Text = "Bàn" + " " + ban.TenBan;
                ShowHd(ban);
                btn_luu.Enabled = true;
                btn_gopban.Enabled = true;
                btn_chuyenban.Enabled = true;
                btn_thanhtoan.Enabled = true;
                cb_khuyenmai.Enabled = true;
                txt_tientra.Enabled = true;
            }
            else
            {
                DialogResult result = MessageBox.Show("Thay đổi chưa được lưu, Bạn có muốn lưu lại ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    LuuHoaDon();
                }
                else
                {
                    _checkOut = true;
                    Btn_Click(sender, e);
                }
            }
        }
        public void ShowHd(Ban ban)
        {
            dtg_view_hd.Rows.Clear();
            if (ban.TrangThai == 0)
            {
                Ban_HD ban_HD = _ban_HDServices.GetBan_HDUnCheck(ban.Id);
                _idHd = (Guid)ban_HD.IdHd;
                hd = new List<HoaDonVm>();
                hd = _sP_HDServices.GetSP_HDByid(_idHd);
                LoadView(hd);
            }
            else
            {
                _idHd = Guid.Empty;
                hd = new List<HoaDonVm>();
                LoadView(hd);
            }
        }
        public void LoadSp(List<SanPham> list)
        {
            fl_sanpham.Controls.Clear();
            foreach (SanPham sp in list)
            {
                Panel pn = new Panel()
                {
                    Width = 150,
                    Height = 160,
                    BackColor = Color.Tan,
                };
                PictureBox pictureBox = new PictureBox()
                {
                    Image = Image.FromFile(sp.HinhAnh),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill,
                    Tag = sp,
                };
                pictureBox.Click += PictureBox_Click;
                pn.Controls.Add(pictureBox);
                Label lb = new Label()
                {
                    AutoSize = false,
                    Height = 30,
                    Dock = DockStyle.Bottom,
                    Text = sp.TenSp,
                    Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White,
                };
                pn.Controls.Add(lb);

                fl_sanpham.Controls.Add(pn);
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            //Sub_views.SubFrm_AddSanPham addsp = new Sub_views.SubFrm_AddSanPham((SanPham)((PictureBox)sender).Tag, hd);
            //addsp.Show();
            _checkOut = false;
            if (_idBan != Guid.Empty)
            {
                SanPham sp = (SanPham)((PictureBox)sender).Tag;
                string input = Interaction.InputBox("Số lượng sản phẩm", sp.TenSp, "1", 500, 300);
                HoaDonVm hoaDonVm = hd.FirstOrDefault(p => p.IdSp == sp.Id);
                if (!input.Equals("") && !input.Equals("0"))
                {
                    if (hoaDonVm != null)
                    {
                        hd.Remove(hoaDonVm);
                        HoaDonVm temp = new HoaDonVm();
                        temp.IdSp = sp.Id;
                        temp.TenSp = sp.TenSp;
                        temp.DonGia = sp.GiaBan;
                        temp.SoLuong = int.Parse(input);
                        temp.MoTa = sp.MoTa;
                        hd.Add(temp);
                        LoadView(hd);
                    }
                    else
                    {
                        HoaDonVm temp = new HoaDonVm();
                        temp.IdSp = sp.Id;
                        temp.TenSp = sp.TenSp;
                        temp.DonGia = sp.GiaBan;
                        temp.SoLuong = int.Parse(input);
                        temp.MoTa = sp.MoTa;
                        hd.Add(temp);
                        LoadView(hd);
                    }
                }
                else if (input.Equals("0"))
                {
                    if (hoaDonVm != null)
                    {
                        hd.Remove(hoaDonVm);
                        LoadView(hd);
                    }
                }
            }
        }

        public void LoadCbb()
        {
            cb_loaisp.Items.Add("Tất cả");
            cb_loaisp.SelectedIndex = 0;
            foreach (var item in _loaiSpServices.GetAllLoaiSp())
            {
                cb_loaisp.Items.Add(item.TenLoai);
            }
            var listkm = _khuyenMaiServices.GetAllKhuyenMai().Where(p => p.TrangThai == 1 && p.NgayKt >= DateTime.Now);
            cb_khuyenmai.Items.Add("Không");
            cb_khuyenmai.SelectedIndex = 0;
            foreach (var item in listkm)
            {
                cb_khuyenmai.Items.Add(item.Ten);
            }
        }

        public void LuuHoaDon()
        {
            _checkOut = true;
            if (_idHd == Guid.Empty)
            {
                var hoaDon = new HoaDon();
                hoaDon.Id = Guid.NewGuid();
                hoaDon.IdNv = _idNv;
                hoaDon.IdKm = cb_khuyenmai.SelectedIndex == 0 ? null : _khuyenMaiServices.GetKhuyenByName(cb_khuyenmai.Text).Id;
                hoaDon.NgayTao = DateTime.Now;
                hoaDon.TrangThai = 0;
                if (_hoaDonServices.AddHoaDon(hoaDon))
                { // add hoa don moi
                    SP_HD sP_HD;
                    _idHd = hoaDon.Id;
                    foreach (var item in hd)
                    {
                        sP_HD = new SP_HD();
                        sP_HD.IdHd = hoaDon.Id;
                        sP_HD.IdSp = item.IdSp;
                        sP_HD.DonGia = item.DonGia;
                        sP_HD.SoLuong = item.SoLuong;
                        _sP_HDServices.AddSP_HD(sP_HD);
                    }
                    if (_idBan != Guid.Empty)
                    {
                        Ban_HD ban_HD = new Ban_HD(); // luu ban_hd
                        ban_HD.IdBan = _idBan;
                        ban_HD.IdHd = _idHd;
                        ban_HD.TrangThai = 0;
                        _ban_HDServices.AddBan_HD(ban_HD);
                        Ban ban = new Ban();// doi trang thai ban
                        ban.Id = _idBan;
                        ban.TenBan = _banServices.GetBanByid(_idBan).TenBan;
                        ban.TrangThai = 0;
                        _banServices.UpdateBan(ban);
                        List<Ban> SortList = _banServices.GetAllBan().OrderBy(p => p.TenBan).ToList();
                        LoadBan(SortList);
                    }
                }
            }
            else
            {
                List<HoaDonVm> listHd = _sP_HDServices.GetSP_HDByid(_idHd);
                SP_HD sP_HD;
                foreach (var item in hd) // thêm sp mới
                {
                    if (listHd.FirstOrDefault(p => p.IdSp == item.IdSp) == null)
                    {
                        sP_HD = new SP_HD();
                        sP_HD.IdHd = _idHd;
                        sP_HD.IdSp = item.IdSp;
                        sP_HD.DonGia = item.DonGia;
                        sP_HD.SoLuong = item.SoLuong;
                        _sP_HDServices.AddSP_HD(sP_HD);
                    }
                    else
                    {
                        sP_HD = new SP_HD();
                        sP_HD.IdHd = _idHd;
                        sP_HD.IdSp = item.IdSp;
                        sP_HD.DonGia = item.DonGia;
                        sP_HD.SoLuong = item.SoLuong;
                        _sP_HDServices.UpdateSP_HD(sP_HD);
                    }
                }
                foreach (var item in listHd) // bo sp cũ
                {
                    if (hd.FirstOrDefault(p => p.IdSp == item.IdSp) == null)
                    {
                        sP_HD = _sP_HDServices.GetAllSP_HD().FirstOrDefault(p => p.IdHd == _idHd && p.IdSp == item.IdSp);
                        _sP_HDServices.DeleteSP_HD(sP_HD);
                    }
                }
            }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            LuuHoaDon();
        }
        public void ThanhToan()
        {
            if (int.Parse(lb_tienthua.Text) >= 0)
            {
                if (_checkOut == true)
                {
                    HoaDon hdthanhtoan = _hoaDonServices.GetHoaDonByid(_idHd);
                    var hoaDon = new HoaDon();
                    hoaDon.Id = hdthanhtoan.Id;
                    hoaDon.IdNv = hdthanhtoan.IdNv;
                    hoaDon.IdKm = cb_khuyenmai.SelectedIndex == 0 ? null : _khuyenMaiServices.GetKhuyenByName(cb_khuyenmai.Text).Id;
                    hoaDon.NgayTao = hdthanhtoan.NgayTao;
                    hoaDon.NgayThanhToan = DateTime.Now;
                    hoaDon.TongTien = int.Parse(lb_tongtienconlai.Text);
                    hoaDon.TrangThai = 1;
                    if (_hoaDonServices.UpdateHoaDon(hoaDon))
                    {
                        if (_idBan != Guid.Empty)
                        {
                            foreach (var item in _ban_HDServices.GetBan_HDByid(_idHd))
                            {
                                Ban_HD ban_HD = new Ban_HD(); // luu ban_hd
                                ban_HD.IdBan = _idBan;
                                ban_HD.IdHd = _idHd;
                                ban_HD.TrangThai = 1;
                                _ban_HDServices.UpdateBan_HD(ban_HD);
                            }
                            Ban ban = new Ban();// doi trang thai ban
                            ban.Id = _idBan;
                            ban.TenBan = _banServices.GetBanByid(_idBan).TenBan;
                            ban.TrangThai = 1;
                            _banServices.UpdateBan(ban);
                            List<Ban> SortList = _banServices.GetAllBan().OrderBy(p => p.TenBan).ToList();
                            LoadBan(SortList);
                        }
                    }
                }
                MessageBox.Show("Thanh toán thành công");
            }
            else MessageBox.Show("Số tiền thành toán chưa đủ");
        }
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            ThanhToan();
        }

        private void cb_loaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_loaisp.SelectedIndex == 0)
            {
                List<SanPham> SortListSanPham = FindKey().OrderBy(p => p.IdLoai).ToList();
                LoadSp(SortListSanPham);
            }
            else
            {
                Guid idLoai = _loaiSpServices.GetAllLoaiSp().FirstOrDefault(p => p.TenLoai.Contains(cb_loaisp.Text)).Id;
                List<SanPham> sanPhams = FindKey().Where(p => p.IdLoai == idLoai).ToList();
                LoadSp(sanPhams);
            }

        }

        private void cb_khuyenmai_SelectedIndexChanged(object sender, EventArgs e)
        {
            KhuyenMai km = _khuyenMaiServices.GetKhuyenByName(cb_khuyenmai.Text);
            if (!(cb_khuyenmai.SelectedIndex == 0))
            {
                if (!(km.SoTienGiam == 0))
                {
                    lb_tongtienconlai.Text = (int.Parse(lb_tongtien.Text) - km.SoTienGiam).ToString();
                }
                else
                {
                    int tong = int.Parse(lb_tongtien.Text);
                    lb_tongtienconlai.Text = (tong / 100 * (100 - km.PhamTramGiam)).ToString();
                }
            }
        }

        private void txt_tientra_TextChanged(object sender, EventArgs e)
        {
            if (!(txt_tientra.Text == ""))
            {
                lb_tienthua.Text = (int.Parse(txt_tientra.Text) - int.Parse(lb_tongtienconlai.Text)).ToString();
            }
            else
            {
                lb_tienthua.Text = (0 - int.Parse(lb_tongtienconlai.Text)).ToString();
            }
        }

        private void txt_tientra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public List<SanPham> FindKey()
        {
            return _sanPhamServices.GetAllSanPham().Where(p => p.TenSp.ToLower().Contains(txt_timkiemsp.Text)).ToList();
        }
        private void txt_timkiemsp_TextChanged(object sender, EventArgs e)
        {
            LoadSp(FindKey());
        }

        private void dtg_view_hd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _checkOut = false;
            if (_idBan != Guid.Empty)
            {
                SanPham sp = _sanPhamServices.GetSanPhamByid(Guid.Parse(dtg_view_hd.CurrentRow.Cells[0].Value.ToString()));
                string input = Interaction.InputBox("Số lượng sản phẩm", sp.TenSp, "1", 500, 300);
                HoaDonVm hoaDonVm = hd.FirstOrDefault(p => p.IdSp == sp.Id);
                if (!input.Equals("") && !input.Equals("0"))
                {
                    if (hoaDonVm != null)
                    {
                        hd.Remove(hoaDonVm);
                        HoaDonVm temp = new HoaDonVm();
                        temp.IdSp = sp.Id;
                        temp.TenSp = sp.TenSp;
                        temp.DonGia = sp.GiaBan;
                        temp.SoLuong = int.Parse(input);
                        temp.MoTa = sp.MoTa;
                        hd.Add(temp);
                        LoadView(hd);
                    }
                    else
                    {
                        HoaDonVm temp = new HoaDonVm();
                        temp.IdSp = sp.Id;
                        temp.TenSp = sp.TenSp;
                        temp.DonGia = sp.GiaBan;
                        temp.SoLuong = int.Parse(input);
                        temp.MoTa = sp.MoTa;
                        hd.Add(temp);
                        LoadView(hd);
                    }
                }
                else if (input.Equals("0"))
                {
                    if (hoaDonVm != null)
                    {
                        hd.Remove(hoaDonVm);
                        LoadView(hd);
                    }
                }
            }
        }
    }
}
