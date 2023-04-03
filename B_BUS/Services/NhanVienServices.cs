using A_DAL.IRespositorys;
using A_DAL.Models;
using A_DAL.Respositorys;
using B_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
	public class NhanVienServices : INhanVienServices
	{
        INhanVienRespositorys respositorys;
        public NhanVienServices() 
        { 
            respositorys = new NhanVienRespositorys();
        }

        public bool AddNhanVien(NhanVien obj)
        {
            return respositorys.AddNhanVien(obj);
        }

        public bool DeleteNhanVien(Guid id)
        {
            return respositorys.DeleteNhanVien(id);
        }

        public List<NhanVien> GetAllNhanVien()
        {
            return respositorys.GetAllNhanVien();
        }

        public NhanVien GetNhanVienByid(Guid id)
        {
            return respositorys.GetNhanVienByid(id);
        }

        public bool UpdateNhanVien(NhanVien obj)
        {
            return respositorys.UpdateNhanVien(obj);
        }
    }
}
