using A_DAL.IRespositorys;
using A_DAL.Models;
using A_DAL.Respositorys;
using B_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class BanServices : IBanServices
    {
        CofffeeDbContext _context;
        IBanRespositorys _respositorys;
        public BanServices()
        {
            _context = new CofffeeDbContext();
            _respositorys = new BanRespositorys();
        }
        public bool AddBan(Ban obj)
        {
            _respositorys.AddBan(obj);
            return true;
        }

        public bool DeleteBan(Guid id)
        {
            _respositorys.DeleteBan(id);
            return true;
        }

        public List<Ban> GetAllBan()
        {
            return _respositorys.GetAllBan();
        }

        public Ban GetBanByid(Guid id)
        {
            return _respositorys.GetBanByid(id);
        }

        public bool UpdateBan(Ban obj)
        {
            _respositorys.UpdateBan(obj);
            return true;
        }
    }
}
