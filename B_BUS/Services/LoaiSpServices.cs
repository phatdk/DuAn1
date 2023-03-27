using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.ViewModels;
using A_DAL.IRespositorys;
using A_DAL.Respositorys;

namespace B_BUS.Services
{
	public class LoaiSpServices : ILoaiSpServices
	{
		CofffeeDbContext _context;
		private ILoaiSpRespositorys _loaiSpRespositorys;
        public LoaiSpServices()
        {
            _context = new CofffeeDbContext();
			_loaiSpRespositorys = new LoaiSpRespositorys();
        }

        public bool AddLoaiSp(LoaiSp obj)
		{
			_loaiSpRespositorys.AddLoaiSp(obj);
			return true;
		}

		public bool DeleteLoaiSp(Guid id)
		{
			_loaiSpRespositorys.DeleteLoaiSp(id);
			return true;
		}

		public List<LoaiSp> GetAllLoaiSp()
		{
			//var data =(from a in _context.loaiSps
			//		   select new LoaiSp
			//		   {
			//			   Id = a.Id,
			//			   TenLoai = a.TenLoai,
			//			   MoTa = a.MoTa,
			//		   }).ToList();
			//return data;
			return _loaiSpRespositorys.GetAllLoaiSp().ToList();
		}

		public bool UpdateLoaiSp(LoaiSp obj)
		{
			_loaiSpRespositorys.UpdateLoaiSp(obj);
			return true;
		}
	}
}
