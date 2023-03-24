using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;

namespace A_DAL.IRespositorys
{
	internal interface IBanRespositorys
	{
		bool AddBan(Ban obj);

		bool DeleteBan(Ban obj);

		bool UpdateBan(Ban obj);

		List<Ban> GetAllBan();
	}
}
