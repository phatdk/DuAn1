using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using B_BUS.ViewModels;

namespace B_BUS.IServices
{
	public interface ISP_HDServices
	{
		bool AddSP_HD(SP_HD obj);

		bool DeleteSP_HD(SP_HD obj);

		bool UpdateSP_HD(SP_HD obj);

		List<SP_HD> GetAllSP_HD();
		List<HoaDonVm> GetSP_HDByid(Guid id);
	}
}
