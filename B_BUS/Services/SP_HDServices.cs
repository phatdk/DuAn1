using A_DAL.IRespositorys;
using A_DAL.Models;
using A_DAL.Respositorys;
using B_BUS.IServices;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class SP_HDServices : ISP_HDServices
    {
        ISP_HDRespositorys _sP_HDRespositorys;
        IHoaDonIRespositorys _hoaDonIRespositorys;
        ISanPhamServices _sanPhamServices;
        public SP_HDServices()
        {
            _sP_HDRespositorys = new SP_HDRespositorys();
            _sanPhamServices = new SanPhamServices();
            _hoaDonIRespositorys = new HoaDonIRespositorys();
        }
        public bool AddSP_HD(SP_HD obj)
        {
            return _sP_HDRespositorys.AddSP_HD(obj);
        }

        public bool DeleteSP_HD(SP_HD obj)
        {
            return _sP_HDRespositorys.DeleteSP_HD(obj);
        }

        public List<SP_HD> GetAllSP_HD()
        {
            return _sP_HDRespositorys.GetAllSP_HD();
        }

        public List<HoaDonVm> GetSP_HDByid(Guid id)
        {
            var hd = (from a in _hoaDonIRespositorys.GetAllHoaDon()
                      join b in _sP_HDRespositorys.GetAllSP_HD() on a.Id equals b.IdHd
                      join c in _sanPhamServices.GetAllSanPhamVm() on b.IdSp equals c.Id
                      select new HoaDonVm
                      {
                          IdHd = a.Id,
                          IdSp = c.Id,
                          TenSp = c.TenSp,
                          DonGia = c.GiaBan,
                          SoLuong = b.SoLuong,
                          MoTa = c.MoTa,
                      }).ToList();
            List<HoaDonVm> reHoaDonVm = hd.Where(p => p.IdHd == id).ToList();
            return reHoaDonVm;
        }

        public bool UpdateSP_HD(SP_HD obj)
        {
            return _sP_HDRespositorys.UpdateSP_HD(obj);
        }
    }
}
