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
    public class KhuyenMaiServices : IKhuyenMaiServices
    {
        CofffeeDbContext _context;
        private IKhuyenMaiRespositorys _khuyenMaiRespositorys;
        public KhuyenMaiServices()
        {
            _context = new CofffeeDbContext();
            _khuyenMaiRespositorys = new KhuyenMaiRespositorys();
        }
        public bool AddKhuyenMai(KhuyenMai obj)
        {
            _khuyenMaiRespositorys.AddKhuyenMai(obj); return true;
        }

        public bool DeleteKhuyenMai(Guid id)
        {
            _khuyenMaiRespositorys?.DeleteKhuyenMai(id);
            return true;
        }

        public List<KhuyenMai> GetKhuyenMais()
        {
            return _khuyenMaiRespositorys.GetAllKhuyenMai();
        }

        public KhuyenMai GetKhuyenMaiByid(Guid id)
        {
            return _khuyenMaiRespositorys.GetKhuyenMaiByid(id);

        }

        public bool UpdateKhuyenMai(KhuyenMai obj)
        {
            _khuyenMaiRespositorys.UpdateKhuyenMai(obj);
            return true;
        }

        public List<KhuyenMai> GetAllKhuyenMai()
        {
            return _khuyenMaiRespositorys.GetAllKhuyenMai();
        }

        public KhuyenMai GetKhuyenByName(string name)
        {
            return _khuyenMaiRespositorys.GetKhuyenMaiByName(name);
        }
    }
}
