using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using B_BUS.ViewModels;

namespace B_BUS.IServices
{
	public interface IHoaDonServices
	{
		public bool AddHoaDon(HoaDon? obj);

		public bool DeleteHoaDon(Guid id);

		public bool UpdateHoaDon(HoaDon obj);

		public List<HoaDon> GetAllHoaDon();
		public HoaDon GetHoaDonByid(Guid id);
		public List<HoaDon> GetHoaDonUnCheck();
	}
}
