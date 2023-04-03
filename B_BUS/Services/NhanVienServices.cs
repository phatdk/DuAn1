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
        INhanVienRespositorys _INVrepos;
        public NhanVienServices()
        {
            _INVrepos = new NhanVienRespositorys();
        }

        public string AddNhanVien(NhanVien obj)
        {
            _INVrepos.AddNhanVien(obj);
            return "Them thanh cong";
        }

        public string DeleteNhanVien(Guid id)
        {
            _INVrepos.DeleteNhanVien(id);
            return "Xoa thanh cong";
        } 

            public List<NhanVien> GetAllNhanVien()
        {
            return _INVrepos.GetAllNhanVien().ToList();
        }

        public NhanVien GetNhanVienByid(Guid id)
        {
            return _INVrepos.GetNhanVienByid(id);
        }

        public string UpdateNhanVien(NhanVien obj)
        {
            var upd = _INVrepos.GetAllNhanVien().FirstOrDefault(c => c.Id == obj.Id);
            upd.MaNv = obj.MaNv;
            upd.HoTen = obj.HoTen;          
            upd.Sdt = obj.Sdt;
            upd.TaiKhoan = obj.TaiKhoan;
            upd.MatKhau = obj.MatKhau;
            upd.GioiTinh = obj.GioiTinh;
            upd.ChucVu = obj.ChucVu; 
            upd.TrangThai = obj.TrangThai;
            _INVrepos.UpdateNhanVien(upd);
            return "Sửa thành công";
        }
    }
}
