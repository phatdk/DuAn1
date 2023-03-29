using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.IRespositorys;

namespace A_DAL.Respositorys
{
	public class LoaiSpRespositorys : ILoaiSpRespositorys
	{
		CofffeeDbContext _context;
		public LoaiSpRespositorys()
		{
			_context = new CofffeeDbContext();
		}
		public bool AddLoaiSp(LoaiSp obj)
		{
			try
			{
				_context.loaiSps.Add(obj);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteLoaiSp(Guid id)
		{
			try
			{
				var Lsp = _context.loaiSps.Find(id);
				_context.loaiSps.Remove(Lsp);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public List<LoaiSp> GetAllLoaiSp()
		{
			return _context.loaiSps.ToList();
		}

		public LoaiSp GetLoaiSpByid(Guid id)
		{
			return _context.loaiSps.Find(id);
		}

		public bool UpdateLoaiSp(LoaiSp obj)
		{
			try
			{
				var idlsp = _context.loaiSps.Find(obj.Id);
				idlsp.TenLoai = obj.TenLoai;
				idlsp.MoTa = obj.MoTa;
				_context.loaiSps.Update(idlsp);
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
