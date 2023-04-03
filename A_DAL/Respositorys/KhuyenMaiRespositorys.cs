using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.IRespositorys;

namespace A_DAL.Respositorys
{
	public class KhuyenMaiRespositorys : IKhuyenMaiRespositorys
	{
		CofffeeDbContext _context;
        public KhuyenMaiRespositorys()
        {
            _context = new CofffeeDbContext();
        }
        public bool AddKhuyenMai(KhuyenMai obj)
		{
			try
			{
				_context.khuyenMais.Add(obj);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteKhuyenMai(Guid id)
		{
			try
			{
				var idkm = _context.khuyenMais.Find(id);
				_context.khuyenMais.Remove(idkm);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public List<KhuyenMai> GetAllKhuyenMai()
		{
			return _context.khuyenMais.ToList();
		}

		public KhuyenMai GetKhuyenMaiByid(Guid id)
		{
			return _context.khuyenMais.Find(id);
		}

        public KhuyenMai GetKhuyenMaiByName(string name)
        {
			return _context.khuyenMais.FirstOrDefault(p => p.Ten.Contains(name));
        }

        public bool UpdateKhuyenMai(KhuyenMai obj)
		{
			try
			{
				var idkm = _context.khuyenMais.Find(obj.Id);
				idkm.Ten = obj.Ten;
				idkm.NgayTao = obj.NgayTao;
				idkm.NgayBd = obj.NgayBd;
				idkm.NgayKt = obj.NgayKt;
				idkm.MoTa = obj.MoTa;
				idkm.PhamTramGiam = obj.PhamTramGiam;
				idkm.DkGiam = obj.DkGiam;
				idkm.SoTienGiam = obj.SoTienGiam;
				idkm.TrangThai = obj.TrangThai;
				_context.khuyenMais.Update(idkm);
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
