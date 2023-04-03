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
    public class HoaDonServices : IHoaDonServices
    {
        IHoaDonIRespositorys _hoaDonIRespositorys;
        public HoaDonServices()
        {
            _hoaDonIRespositorys = new HoaDonIRespositorys();
        }
        public bool AddHoaDon(HoaDon? obj)
        {
            return _hoaDonIRespositorys.AddHoaDon(obj);
        }

        public bool DeleteHoaDon(Guid id)
        {
            return _hoaDonIRespositorys.DeleteHoaDon(id);
        }

        public List<HoaDon> GetAllHoaDon()
        {
            return _hoaDonIRespositorys.GetAllHoaDon();
        }

        public HoaDon GetHoaDonByid(Guid id)
        {
            return _hoaDonIRespositorys.GetHoaDonByid(id);
        }

        public List<HoaDon> GetHoaDonUnCheck()
        {
            return _hoaDonIRespositorys.GetHoaDonUnCheck().ToList();
        }

        public bool UpdateHoaDon(HoaDon obj)
        {
            return _hoaDonIRespositorys.UpdateHoaDon(obj);
        }
    }
}
