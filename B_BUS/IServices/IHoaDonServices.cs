using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
namespace B_BUS.IServices
{
	internal interface IHoaDonServices
	{
		bool AddHoaDon(HoaDon obj);

		bool DeleteHoaDon(Guid id);

		bool UpdateHoaDon(HoaDon obj);

		List<HoaDon> GetAllHoaDon();
		HoaDon GetHoaDonByid(Guid id);
	}
}
