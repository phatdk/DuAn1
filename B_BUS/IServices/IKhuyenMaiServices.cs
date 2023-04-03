using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using B_BUS.ViewModels;

namespace B_BUS.IServices
{
	public interface IKhuyenMaiServices
	{
		bool AddKhuyenMai(KhuyenMai obj);

		bool DeleteKhuyenMai(Guid id);

		bool UpdateKhuyenMai(KhuyenMai obj);

		List<KhuyenMai> GetAllKhuyenMai();
		public KhuyenMai GetKhuyenMaiByid(Guid id);
		public KhuyenMai GetKhuyenByName(string name);
	}
}
