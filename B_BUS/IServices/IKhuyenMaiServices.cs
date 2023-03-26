﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
namespace B_BUS.IServices
{
	internal interface IKhuyenMaiServices
	{
		bool AddKhuyenMai(KhuyenMai obj);

		bool DeleteKhuyenMai(Guid id);

		bool UpdateKhuyenMai(KhuyenMai obj);

		List<KhuyenMai> GetAllKhuyenMai();
		KhuyenMai GetKhuyenMaiByid(Guid id);
	}
}
