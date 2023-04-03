using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;

namespace A_DAL.IRespositorys
{
	public interface IHoaDonIRespositorys
	{
		bool AddHoaDon(HoaDon obj);

		bool DeleteHoaDon(Guid id);

		bool UpdateHoaDon(HoaDon obj);

		List<HoaDon> GetAllHoaDon();
		HoaDon GetHoaDonByid(Guid id);
		List<HoaDon> GetHoaDonUnCheck();
	}
}
