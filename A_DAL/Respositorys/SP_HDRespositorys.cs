﻿using A_DAL.IRespositorys;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositorys
{
	internal class SP_HDRespositorys : ISP_HDRespositorys
	{
		CofffeeDbContext _context;
		public SP_HDRespositorys()
		{
			_context = new CofffeeDbContext();
		}
		public bool AddSP_HD(SP_HD obj)
		{
			try
			{
				_context.sP_HDs.Add(obj);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteSP_HD(Guid id)
		{
			throw new NotImplementedException();
		}

		public List<SP_HD> GetAllSP_HD()
		{
			return _context.sP_HDs.ToList();
		}

		public SP_HD GetSP_HDByid(Guid id)
		{
			return _context.sP_HDs.Find(id);
		}

		public bool UpdateSP_HD(SP_HD obj)
		{
			try
			{
				var sp_hd = _context.sP_HDs.FirstOrDefault(c=>c.IdHd == obj.IdHd);
				sp_hd.DonGia = obj.DonGia;
				sp_hd.SoLuong = obj.SoLuong;
				_context.sP_HDs.Update(obj);
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
