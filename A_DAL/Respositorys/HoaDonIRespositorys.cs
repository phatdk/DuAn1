using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.IRespositorys;

namespace A_DAL.Respositorys
{
	internal class HoaDonIRespositorys : IHoaDonIRespositorys
	{
		CofffeeDbContext _context;
		public HoaDonIRespositorys()
		{
			_context = new CofffeeDbContext();
		}
		public bool AddHoaDon(HoaDon obj)
		{
			try
			{
				_context.hoaDons.Add(obj);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteHoaDon(Guid id)
		{
			try
			{
				var idhd = _context.hoaDons.Find(id);
				_context.hoaDons.Remove(idhd);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public List<HoaDon> GetAllHoaDon()
		{
			return _context.hoaDons.ToList();
		}

		public HoaDon GetHoaDonByid(Guid id)
		{
			return _context.hoaDons.Find(id);
		}

		public bool UpdateHoaDon(HoaDon obj)
		{
			try
			{
				var hd = _context.hoaDons.Find(obj.Id);
				hd.IdNv = obj.IdNv;
				hd.NgayTao = obj.NgayTao;
				hd.NgayThanhToan = obj.NgayThanhToan;
				hd.TongTien = obj.TongTien;
				hd.TrangThai = obj.TrangThai;
				_context.hoaDons.Update(hd);
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
