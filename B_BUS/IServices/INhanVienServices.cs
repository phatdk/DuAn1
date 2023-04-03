using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
namespace B_BUS.IServices
{
	public interface INhanVienServices
	{
		string AddNhanVien(NhanVien obj);

		string DeleteNhanVien(Guid id);

		string UpdateNhanVien(NhanVien obj);

		List<NhanVien> GetAllNhanVien();
		NhanVien GetNhanVienByid(Guid id);
	}
}
