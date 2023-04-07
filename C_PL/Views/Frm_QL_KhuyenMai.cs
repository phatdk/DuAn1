using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
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

namespace C_PL.Views
{
    public partial class Frm_QL_KhuyenMai : Form
    {
        IKhuyenMaiServices _khuyenMaiServices;
        Guid _id;
        public Frm_QL_KhuyenMai()
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
            dtg_view_khuyenmai.Columns[4].Visible = false;
            dtg_view_khuyenmai.Columns[5].Name = "Phần trăm giảm";
            dtg_view_khuyenmai.Columns[6].Name = "Số tiền giảm";
            dtg_view_khuyenmai.Columns[7].Name = "Ngày bắt đầu";
            dtg_view_khuyenmai.Columns[8].Name = "Ngày kết thúc";
            dtg_view_khuyenmai.Columns[9].Name = "Mô tả";
            dtg_view_khuyenmai.Columns[9].Visible = false;
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
                newlist = list.Where(p => p.TrangThai == 0).ToList();
            }
            else if (rd_dangdung.Checked)
            {
                newlist = list.Where(p => p.TrangThai == 1).ToList();
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
        private void ClearFrm()
        {
            _id = Guid.Empty;
            txt_tenkm.Text = "";
            txt_dkgiam.Text = "";
            txt_mota.Text = "";
            txt_phantram.Text = "0.00";
            txt_sotien.Text = "0";
            dtp_ngaybd.Value = DateTime.Now;
            dtp_ngaykt.Value = DateTime.Now;
            cb_sudung.Checked = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }
        public List<KhuyenMai> FindKey()
        {
            return _khuyenMaiServices.GetAllKhuyenMai().Where(p => p.Ten.ToLower().Contains(txt_timkiem.Text.ToLower())).ToList();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            KhuyenMai km = new KhuyenMai();
            km.Id = Guid.NewGuid();
            km.Ten = txt_tenkm.Text;
            km.DkGiam = txt_dkgiam.Text;
            km.NgayTao = DateTime.Now;
            km.NgayBd = dtp_ngaybd.Value;
            km.NgayKt = dtp_ngaykt.Value;
            km.MoTa = txt_mota.Text;
            km.PhamTramGiam = int.Parse(txt_phantram.Text);
            km.SoTienGiam = int.Parse(txt_sotien.Text);
            km.TrangThai = cb_sudung.Checked ? 1 : 0;
            if (_khuyenMaiServices.AddKhuyenMai(km))
            {
                MessageBox.Show("Add done");
                ClearFrm();
                LoadView(_khuyenMaiServices.GetAllKhuyenMai());
            }
            else MessageBox.Show("Add false");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            KhuyenMai km = new KhuyenMai();
            km.Id = _id;
            km.Ten = txt_tenkm.Text;
            km.DkGiam = txt_dkgiam.Text;
            km.NgayTao = DateTime.Now;
            km.NgayBd = dtp_ngaybd.Value;
            km.NgayKt = dtp_ngaykt.Value;
            km.MoTa = txt_mota.Text;
            km.PhamTramGiam = int.Parse(txt_phantram.Text);
            km.SoTienGiam = int.Parse(txt_sotien.Text);
            km.TrangThai = cb_sudung.Checked ? 1 : 0;
            if (_khuyenMaiServices.UpdateKhuyenMai(km))
            {
                MessageBox.Show("Update done");
                ClearFrm();
                LoadView(_khuyenMaiServices.GetAllKhuyenMai());
            }
            else MessageBox.Show("Update false");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa khuyến mại ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (_khuyenMaiServices.DeleteKhuyenMai(_id))
                {
                    MessageBox.Show("Delete done");
                    ClearFrm();
                    LoadView(_khuyenMaiServices.GetAllKhuyenMai());
                }
                else MessageBox.Show("Delete false");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFrm();
        }

        private void dtg_view_khuyenmai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_view_khuyenmai.CurrentRow.Cells[0].Value.ToString());
            txt_tenkm.Text = dtg_view_khuyenmai.CurrentRow.Cells[2].Value.ToString();
            txt_dkgiam.Text = dtg_view_khuyenmai.CurrentRow.Cells[4].Value.ToString();
            txt_phantram.Text = dtg_view_khuyenmai.CurrentRow.Cells[5].Value.ToString();
            txt_sotien.Text = dtg_view_khuyenmai.CurrentRow.Cells[6].Value.ToString();
            dtp_ngaybd.Value = DateTime.Parse(dtg_view_khuyenmai.CurrentRow.Cells[7].Value.ToString());
            dtp_ngaykt.Value = DateTime.Parse(dtg_view_khuyenmai.CurrentRow.Cells[8].Value.ToString());
            txt_mota.Text = dtg_view_khuyenmai.CurrentRow.Cells[9].Value.ToString();
            if (dtg_view_khuyenmai.CurrentRow.Cells[10].Value.ToString().Contains("Đang sử dụng"))
                cb_sudung.Checked = true;
            else cb_sudung.Checked = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
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

        private void txt_phantram_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_sotien_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_phantram_MouseClick(object sender, MouseEventArgs e)
        {
            txt_phantram.Text = "0";
        }

        private void txt_sotien_MouseClick(object sender, MouseEventArgs e)
        {
            txt_sotien.Text = "0";
        }
    }
}
