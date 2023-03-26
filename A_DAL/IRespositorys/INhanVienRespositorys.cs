﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;

namespace A_DAL.IRespositorys
{
	internal interface INhanVienRespositorys
	{
		bool AddNhanVien(NhanVien obj);

		bool DeleteNhanVien(Guid id);

		bool UpdateNhanVien(NhanVien obj);

		List<NhanVien> GetAllNhanVien();
		NhanVien GetNhanVienByid(Guid id);
	}
}
