using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.IRespositorys;

namespace A_DAL.Respositorys
{
	internal class Ban_HDIRespositorys : IBan_HDIRespositorys
	{
		CofffeeDbContext _context;
        public Ban_HDIRespositorys()
        {
            _context = new CofffeeDbContext();
        }
        public bool AddBan_HD(Ban_HD obj)
		{
			try
			{
				_context.ban_HDs.Add(obj);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteBan_HD(Ban_HD obj)
		{
			throw new NotImplementedException();
		}

		public List<Ban_HD> GetAllBan_HD()
		{
			return _context.ban_HDs.ToList();
		}

		public Ban_HD GetBan_HDByid(Guid id)
		{
			return _context.ban_HDs.Find(id);
		}

		public bool UpdateBan_HD(Ban_HD obj)
		{
			try
			{
				_context.ban_HDs.Update(obj);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
