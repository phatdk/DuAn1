using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.IRespositorys;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Respositorys
{
	public class NhanVienRespositorys : INhanVienRespositorys
	{
		CofffeeDbContext _context;
		public NhanVienRespositorys()
		{
			_context = new CofffeeDbContext();
		}
		public bool AddNhanVien(NhanVien obj)
		{
            if (obj == null) return false;
            _context.Add(obj);
            _context.SaveChanges();
            return true;
        }

		public bool DeleteNhanVien(Guid id)
		{
			try
			{
				var idnv = _context.nhanViens.Find(id);
				_context.nhanViens.Remove(idnv);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public List<NhanVien> GetAllNhanVien()
		{
			return _context.nhanViens.ToList();
		}

		public NhanVien GetNhanVienByid(Guid id)
		{
			return _context.nhanViens.Find(id);
		}

		public bool UpdateNhanVien(NhanVien obj)
		{
            if (obj == null) return false;
            _context.Update(obj);
            _context.SaveChanges();
            return true;
        }
	}
}
