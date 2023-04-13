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
    public partial class Frm_QL_Ban : Form
    {
        IBanServices _ibanser;
        Ban _ban;
        Guid _id;
        public Frm_QL_Ban()
        {
            InitializeComponent();

            _ban = new Ban();
            _ibanser = new BanServices();
            LoadData();

        }
        public void LoadData()
        {
            dtg_view_ban.ColumnCount = 3;
            dtg_view_ban.Columns[0].Name = "ID";
            dtg_view_ban.Columns[0].Visible = false;
            dtg_view_ban.Columns[1].Name = "Tên bàn";
            dtg_view_ban.Columns[2].Name = "Trạng thái";
            dtg_view_ban.AllowUserToAddRows = false;
            dtg_view_ban.Rows.Clear();
            foreach (var item in _ibanser.GetAllBan())
            {
                dtg_view_ban.Rows.Add(item.Id, item.TenBan, item.TrangThai);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            _ban = new Ban()
            {
                Id = Guid.NewGuid(),
                TenBan = txt_tenban.Text,
                TrangThai = Convert.ToInt32(cb_trangthai.Text)
            };
            if (_ibanser.AddBan(_ban))
            {
                MessageBox.Show("Thêm bàn thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại");
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            _ban.Id = _id;
            _ban.TenBan = txt_tenban.Text;
            _ban.TrangThai = Convert.ToInt32(cb_trangthai.Text);
            if (_ibanser.UpdateBan(_ban))
            {
                MessageBox.Show("Sửa bàn thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa bàn  thất bại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xoá bàn này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (_ibanser.DeleteBan(_id))
                {
                    MessageBox.Show("Xoá thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("xoá thất bại");
                }

            }
        }

        private void dtg_view_ban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_view_ban.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_tenban.Text = dtg_view_ban.Rows[e.RowIndex].Cells[1].Value.ToString();
            cb_trangthai.Text = dtg_view_ban.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_tenban.Text = "";
            cb_trangthai.Text = "";
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            dtg_view_ban.Rows.Clear();
            foreach (var item in _ibanser.GetAllBan().Where(c => c.TenBan.Contains(tb_TimKiem.Text)))
            {
                dtg_view_ban.Rows.Add(item.TenBan, item.TrangThai);
            }
        }
    }
}
