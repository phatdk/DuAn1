﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
namespace B_BUS.IServices
{
	internal interface ISP_HDServices
	{
		bool AddSP_HD(SP_HD obj);

		bool DeleteSP_HD(Guid id);

		bool UpdateSP_HD(SP_HD obj);

		List<SP_HD> GetAllSP_HD();
		SP_HD GetSP_HDByid(Guid id);
	}
}
