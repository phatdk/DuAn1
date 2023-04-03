﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.IRespositorys;

namespace A_DAL.Respositorys
{
	public class Ban_HDIRespositorys : IBan_HDIRespositorys
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
			try
			{
				var ban_hd = _context.ban_HDs.FirstOrDefault(c => c.IdHd == obj.IdHd);
				_context.ban_HDs.Remove(ban_hd);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public List<Ban_HD> GetAllBan_HD()
		{
			return _context.ban_HDs.ToList();
		}

		public List<Ban_HD> GetBan_HDByid(Guid id)
		{
			return _context.ban_HDs.Where(p => p.IdBan == id).ToList(); ;
		}

        public Ban_HD GetBan_HDUnCheck(Guid id)
        {
			return _context.ban_HDs.FirstOrDefault(p => p.IdBan == id && p.TrangThai == 0);
        }

        public bool UpdateBan_HD(Ban_HD obj)
		{
			try
			{
				var ban_hd = _context.ban_HDs.FirstOrDefault(c => c.IdBan == obj.IdBan && c.IdHd == obj.IdHd);
				//var idban = _context.ban_HDs.FirstOrDefault(c => c.IdBan == obj.IdBan); 
				_context.ban_HDs.Update(ban_hd);
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
