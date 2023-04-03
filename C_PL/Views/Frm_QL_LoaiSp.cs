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
	public partial class Frm_QL_LoaiSp : Form
	{
		private ILoaiSpServices _ilspService;
		private LoaiSp _loaisp;
		Guid _id;
		public Frm_QL_LoaiSp()
		{
			InitializeComponent();
			_loaisp = new LoaiSp();
			_ilspService = new LoaiSpServices();
			LoadData();
		}
		public void LoadData()
		{
			dtg_view_loaisp.ColumnCount = 7;
			dtg_view_loaisp.Columns[0].Name = "ID";
			dtg_view_loaisp.Columns[0].Visible = false;
			dtg_view_loaisp.Columns[1].Name = "Tên loại sản phẩm";
			dtg_view_loaisp.Columns[2].Name = "Mô tả";
			dtg_view_loaisp.Rows.Clear();
			foreach (var item in _ilspService.GetAllLoaiSp())
			{
				dtg_view_loaisp.Rows.Add(item.Id, item.TenLoai, item.MoTa);
			}
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn thêm loại sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				_loaisp = new LoaiSp()
				{
					Id = Guid.NewGuid(),
					TenLoai = tb_tenloaisp.Text,
					MoTa = tb_mota.Text,
				};
				if (_ilspService.AddLoaiSp(_loaisp))
				{
                    MessageBox.Show("Thêm thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }

            }
			
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn cập nhật loại sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				//var id = _ilspService.GetAllLoaiSp().FirstOrDefault(c => c.Id == _loaisp.Id) ;
				_loaisp.Id = _id;
				_loaisp.TenLoai = tb_tenloaisp.Text;
				_loaisp.MoTa = tb_mota.Text;
				if (_ilspService.UpdateLoaiSp(_loaisp))
				{
                    MessageBox.Show("Cập nhật thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
                
			}
			
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn xoá loại sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				_loaisp.Id = _id;
				_ilspService.DeleteLoaiSp(_id);
				MessageBox.Show("Xoá thành công");
				LoadData();
			}
		}

		private void dtg_view_loaisp_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			_id = Guid.Parse(dtg_view_loaisp.Rows[e.RowIndex].Cells[0].Value.ToString());
			tb_tenloaisp.Text = dtg_view_loaisp.Rows[e.RowIndex].Cells[1].Value.ToString();
			tb_mota.Text = dtg_view_loaisp.Rows[e.RowIndex].Cells[2].Value.ToString();
		}

		private void btn_clear_Click(object sender, EventArgs e)
		{
			tb_tenloaisp.Text = "";
			tb_mota.Text = "";
		}

		private void txt_timkiem_TextChanged(object sender, EventArgs e)
		{
			dtg_view_loaisp.Rows.Clear();
			//var stt = 0;
			//dtg_view_loaisp.ColumnCount = 4;
			//dtg_view_loaisp.Columns[0].Name = "STT";		
			//dtg_view_loaisp.Columns[1].Name = "Id";
			//dtg_view_loaisp.Columns[1].Visible = false;
			//dtg_view_loaisp.Columns[2].Name = "Tên loại sản phẩm";
			//dtg_view_loaisp.Columns[3].Name = "Mô tả";
			
			foreach (var item in _ilspService.GetAllLoaiSp().Where(c=>c.TenLoai.Contains(txt_timkiem.Text)))
			{
				dtg_view_loaisp.Rows.Add(item.TenLoai, item.MoTa);
			}
			
		}
	}
}
