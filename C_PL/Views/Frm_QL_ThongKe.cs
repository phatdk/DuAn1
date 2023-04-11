using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using System.Data;

namespace C_PL.Views
{
    public partial class Frm_QL_ThongKe : Form
    {
        List<HoaDon> hoaDons = new List<HoaDon>();
        IHoaDonServices _hoaDonsService;
        ISP_HDServices _HDServices;
        ISanPhamServices _SPhamServices;

        public Frm_QL_ThongKe()
        {
            InitializeComponent();
            _hoaDonsService = new HoaDonServices();
            _HDServices = new SP_HDServices();
            _SPhamServices = new SanPhamServices();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void date_TheoNgay_ValueChanged(object sender, EventArgs e)
        {
            int tongTien = 0;
            var ds = (from x in _hoaDonsService.GetAllHoaDon() where x.NgayThanhToan.Value.ToString("dd/MM/yyyy") == date_TheoNgay.Value.ToString("dd/MM/yyyy") select x).ToList();

            for (int i = 0; i < ds.Count; i++)
            {
                tongTien = ds[i].TongTien.Value + tongTien;
            }
            lb_DoanhThu.Text = tongTien.ToString() + " VND";
            //MessageBox.Show(date_TheoNgay.Value.ToString("dd/MM/yyyy"));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //MessageBox.Show(cbbThang.Text.Split(' ').ElementAt(1));
            var ds = (from x in _hoaDonsService.GetAllHoaDon()
                     join y in _HDServices.GetAllSP_HD() on x.Id equals y.IdHd
                     //join z in _SPhamServices.GetAllSanPham() on y.IdSp equals z.Id
                     where x.NgayThanhToan.Value.Month == int.Parse(cbbThang.Text.Split(' ').ElementAt(1)) && x.NgayThanhToan.Value.Year == int.Parse(cbbNam.Text)
                     select new { IDSP = y.IdSp,
                     Soluong = y.SoLuong}).ToList();
            //Guid id = ds[0].IDSP.Value;
            int soluong = ds[0].Soluong;
            for (int i = 0;i < ds.Count -1 ; i++)
            {

                for(int j = 1;j<ds.Count;j++)
                {
                    if (ds[i].IDSP == ds[j].IDSP)
                    {
                        soluong = ds[i].Soluong + soluong;
                    }
                }
                
            }
            MessageBox.Show(soluong.ToString());
            dtg.DataSource = ds.ToList();
        }
    }
}
