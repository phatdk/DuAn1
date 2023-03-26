using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;

namespace A_DAL.IRespositorys
{
	internal interface ISP_HDRespositorys
	{
		bool AddSP_HD(SP_HD obj);

		bool DeleteSP_HD(SP_HD obj);

		bool UpdateSP_HD(SP_HD obj);

		List<SP_HD> GetAllSP_HD();
		SP_HD GetSP_HDByid(Guid id);
	}
}
