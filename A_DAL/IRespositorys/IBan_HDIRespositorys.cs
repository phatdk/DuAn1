﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;

namespace A_DAL.IRespositorys
{
	internal interface IBan_HDIRespositorys
	{
		bool AddBan_HD(Ban_HD obj);

		bool DeleteBan_HD(Ban_HD obj);

		bool UpdateBan_HD(Ban_HD obj);

		List<Ban_HD> GetAllBan_HD();
		Ban_HD GetBan_HDByid(Guid id);
	}
}
