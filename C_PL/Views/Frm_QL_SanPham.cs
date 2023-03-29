using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;

namespace C_PL.Views
{
	public partial class Frm_QL_SanPham : Form
	{
		private ISanPhamServices _isanPhamSer;
		private ILoaiSpServices _iloaiSpSer;
		private Guid _id;
		private SanPham _sanPham;
		private string linkAnh = "";
		public Frm_QL_SanPham()
		{
			InitializeComponent();
			_sanPham = new SanPham();
			_isanPhamSer = new SanPhamServices();
			_iloaiSpSer = new LoaiSpServices();
			LoadCbbLoaiSP();
			LoadSanPham();
		}
		public void LoadCbbLoaiSP()
		{
			foreach (var item in _iloaiSpSer.GetAllLoaiSp())
			{
				cbb_loaisp.Items.Add(item.TenLoai);
			}
		}
		public void LoadSanPham()
		{
			dtg_view_sanpham.ColumnCount = 7;
			dtg_view_sanpham.Columns[0].Name = "ID";
			dtg_view_sanpham.Columns[0].Visible = false;
			dtg_view_sanpham.Columns[1].Name = "Tên sản phẩm";
			dtg_view_sanpham.Columns[2].Name = "Hình ảnh";
			dtg_view_sanpham.Columns[3].Name = "Mô tả";
			dtg_view_sanpham.Columns[4].Name = "Loại sản phẩm";
			dtg_view_sanpham.Columns[5].Name = "Gía bán";
			dtg_view_sanpham.Columns[6].Name = "Trạng thái";
			dtg_view_sanpham.Rows.Clear();
			foreach (var item in _isanPhamSer.GetAllSanPhamVm())
			{
				dtg_view_sanpham.Rows.Add(item.Id, item.TenSp
					, item.HinhAnh, item.MoTa, item.TenLoaiSp, item.GiaBan, item.TrangThai);
			}
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn thêm sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
				File.Copy(linkAnh, Path.Combine(projectDirectory, "Resources", "Sanpham", Path.GetFileName(linkAnh)), true);
				linkAnh = Path.Combine(projectDirectory, "Resources", "Sanpham", Path.GetFileName(linkAnh));
				var lsp = _iloaiSpSer.GetAllLoaiSp().FirstOrDefault(c => c.TenLoai == cbb_loaisp.Text);
				_sanPham = new SanPham()
				{
					Id = Guid.NewGuid(),
					IdLoai = lsp.Id,
					TenSp = tb_tensp.Text,
					HinhAnh = linkAnh,
					MoTa = tb_mota.Text,
					GiaBan = Convert.ToInt32(tb_giaban.Text),
					TrangThai = Convert.ToInt32(cbb_trangthai.Text),
				};
				_isanPhamSer.AddSanPham(_sanPham);
				MessageBox.Show("Thêm sản phẩm thành công");
				LoadSanPham();
			}
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			//var up = _isanPhamSer.GetAllSanPham().FirstOrDefault(p => p.Id == _id);
			var lsp = _iloaiSpSer.GetAllLoaiSp().FirstOrDefault(c => c.TenLoai == cbb_loaisp.Text);
			DialogResult result = MessageBox.Show("Bạn có muốn câp nhật sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
				File.Copy(linkAnh, Path.Combine(projectDirectory, "Resources", "Sanpham", Path.GetFileName(linkAnh)), true);
				linkAnh = Path.Combine(projectDirectory, "Resources", "Sanpham", Path.GetFileName(linkAnh));

				_sanPham.HinhAnh = linkAnh;
				_sanPham.Id = _id;
				_sanPham.TenSp = tb_tensp.Text;
				_sanPham.MoTa = tb_mota.Text;
				_sanPham.IdLoai = lsp.Id;
				_sanPham.GiaBan = Convert.ToInt32(tb_giaban.Text);
				_sanPham.TrangThai = Convert.ToInt32(cbb_trangthai.Text);
				_isanPhamSer.UpdateSanPham(_sanPham);
				MessageBox.Show("Cập nhật sản phẩm thành công");
				LoadSanPham();
			}
			else
			{
				MessageBox.Show("Cập nhật thất bại");
			}
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn xoá sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				_sanPham.Id = _id;
				_isanPhamSer.DeleteSanPham(_id);
				MessageBox.Show("Xoá thành công");
				LoadSanPham();
			}
			else
			{
				MessageBox.Show("Xoá thất bại");
			}
		}

		private void btn_clear_Click(object sender, EventArgs e)
		{
			tb_tensp.Text = "";
			tb_giaban.Text = "";
			cbb_loaisp.Text = "";
			cbb_trangthai.Text = "";
			tb_mota.Text = "";
			pic_anh.Image = null;

		}

		private void dtg_view_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			//tìm ra id của sản phẩm
			_id = Guid.Parse(dtg_view_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString());
			var sp = _isanPhamSer.GetAllSanPham().FirstOrDefault(c => c.Id == _id);
			//tb_tensp.Text = sp.TenSp;
			//tb_mota.Text = sp.MoTa;
			//tb_giaban.Text = sp.GiaBan.ToString();
			//cbb_loaisp.Text = sp.TenLoaiSp.ToString();
			//cbb_trangthai.Text = sp.TrangThai.ToString();


			tb_tensp.Text = dtg_view_sanpham.Rows[e.RowIndex].Cells[1].Value.ToString();
			tb_mota.Text = dtg_view_sanpham.Rows[e.RowIndex].Cells[3].Value.ToString();
			cbb_loaisp.Text = dtg_view_sanpham.Rows[e.RowIndex].Cells[4].Value.ToString();
			tb_giaban.Text = dtg_view_sanpham.Rows[e.RowIndex].Cells[5].Value.ToString();
			cbb_trangthai.Text = dtg_view_sanpham.Rows[e.RowIndex].Cells[6].Value.ToString();
			linkAnh = sp.HinhAnh;

			if (linkAnh != null && File.Exists(linkAnh))
			{
				pic_anh.Image = Image.FromFile(linkAnh);
				pic_anh.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			else
			{
				pic_anh.Image = null;
			}
		}

		private void pic_anh_Click(object sender, EventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();
			if (op.ShowDialog() == DialogResult.OK)
			{
				linkAnh = op.FileName;
				pic_anh.Image = Image.FromFile(op.FileName);
				pic_anh.SizeMode = PictureBoxSizeMode.StretchImage;
			}
		}

		private void tb_timkiem_TextChanged(object sender, EventArgs e)
		{

			dtg_view_sanpham.Rows.Clear();
			foreach (var item in _isanPhamSer.GetAllSanPhamVm().Where(c => c.TenSp.Contains(tb_timkiem.Text)))
			{
				dtg_view_sanpham.Rows.Add(item.Id, item.TenSp
					, item.HinhAnh, item.MoTa, item.TenLoaiSp, item.GiaBan, item.TrangThai);
			}
		}
	}
}
