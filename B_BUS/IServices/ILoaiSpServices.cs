using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
namespace B_BUS.IServices
{
	internal interface ILoaiSpServices
	{
		bool AddLoaiSp(LoaiSp obj);

		bool DeleteLoaiSp(Guid id);

		bool UpdateLoaiSp(LoaiSp obj);

		List<LoaiSp> GetAllLoaiSp();
		LoaiSp GetLoaiSpByid(Guid id);
	}
}
