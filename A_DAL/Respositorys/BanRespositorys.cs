using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.IRespositorys;

namespace A_DAL.Respositorys
{
	public class BanRespositorys : IBanRespositorys
	{
		CofffeeDbContext _context;

		public BanRespositorys()
		{
			_context = new CofffeeDbContext();
		}
		public bool AddBan(Ban obj)
		{
			try
			{
				_context.bans.Add(obj);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}

		}

		public bool DeleteBan(Guid id)
		{
			try
			{
				var idban = _context.bans.Find(id);
				_context.bans.Remove(idban);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public List<Ban> GetAllBan()
		{
			return _context.bans.ToList();	
		}

		public Ban GetBanByid(Guid id)
		{
			return _context.bans.Find(id);
		}

		public bool UpdateBan(Ban obj)
		{
			try
			{
				var ban = _context.bans.Find(obj.Id);
				ban.TenBan = obj.TenBan;
				ban.TrangThai = obj.TrangThai;
				_context.Update(ban);
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
