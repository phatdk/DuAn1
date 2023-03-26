using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
namespace B_BUS.IServices
{
	internal interface ISanPhamServices
	{
		bool AddSanPham(SanPham obj);

		bool DeleteSanPham(Guid id);

		bool UpdateSanPham(SanPham obj);

		List<SanPham> GetAllSanPham();
		SanPham GetSanPhamByid(Guid id);
	}
}
