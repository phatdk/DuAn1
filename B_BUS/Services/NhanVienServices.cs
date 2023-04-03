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
            throw new NotImplementedException();
        }

        public bool DeleteNhanVien(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<NhanVien> GetAllNhanVien()
        {
            throw new NotImplementedException();
        }

        public NhanVien GetNhanVienByid(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNhanVien(NhanVien obj)
        {
            throw new NotImplementedException();
        }
    }
}
