using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using B_BUS.ViewModels;

namespace B_BUS.IServices
{
	public interface ISanPhamServices
	{
		bool AddSanPham(SanPham obj);

		bool DeleteSanPham(Guid id);

		bool UpdateSanPham(SanPham obj);

		List<SanPhamVm> GetAllSanPhamVm();
		List<SanPham> GetAllSanPham();
		SanPham GetSanPhamByid(Guid id);
	}
}
