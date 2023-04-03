﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
namespace B_BUS.IServices
{
	public interface IBanServices
	{
		bool AddBan(Ban obj);

		bool DeleteBan(Guid id);

		bool UpdateBan(Ban obj);

		List<Ban> GetAllBan();
		Ban GetBanByid(Guid id);
	}
}
