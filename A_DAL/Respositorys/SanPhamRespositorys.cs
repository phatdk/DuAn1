using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.IRespositorys;

namespace A_DAL.Respositorys
{
	internal class SanPhamRespositorys : ISanPhamRespositorys
	{
		CofffeeDbContext _context;
		public SanPhamRespositorys()
		{
			_context = new CofffeeDbContext();
		}
		public bool AddSanPham(SanPham obj)
		{
			try
			{
				_context.sanPhams.Add(obj);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteSanPham(Guid id)
		{
			try
			{
				var idsp = _context.sanPhams.Find(id);
				_context.sanPhams.Remove(idsp);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public List<SanPham> GetAllSanPham()
		{
			return _context.sanPhams.ToList();
		}

		public SanPham GetSanPhamByid(Guid id)
		{
			return _context.sanPhams.Find(id);
		}

		public bool UpdateSanPham(SanPham obj)
		{
			try
			{
				var idsp = _context.sanPhams.Find(obj.Id);
				idsp.IdLoai = obj.IdLoai;
				idsp.IdKm = obj.IdKm;
				idsp.TenSp = obj.TenSp;
				idsp.HinhAnh = obj.HinhAnh;
				idsp.MoTa = obj.MoTa;
				idsp.GiaBan = obj.GiaBan;
				idsp.TrangThai = obj.TrangThai;
				_context.sanPhams.Update(idsp);
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
