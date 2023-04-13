using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.ViewModels;
using A_DAL.IRespositorys;
using A_DAL.Respositorys;

namespace B_BUS.Services
{
    public class SanPhamServices : ISanPhamServices
    {
        CofffeeDbContext _context;
        private ISanPhamRespositorys _isanphamRP;
        private ILoaiSpRespositorys _ilspRP;
        public SanPhamServices()
        {
            _context = new CofffeeDbContext();
            _isanphamRP = new SanPhamRespositorys();
            _ilspRP = new LoaiSpRespositorys();
        }
        public bool AddSanPham(SanPham obj)
        {
            _isanphamRP.AddSanPham(obj); return true;
        }

        public bool DeleteSanPham(Guid id)
        {
            _isanphamRP?.DeleteSanPham(id);
            return true;
        }

        public List<SanPham> GetAllSanPham()
        {
            return _isanphamRP.GetAllSanPham().ToList();
        }

        public SanPham GetSanPhamByid(Guid id)
        {
            return _isanphamRP.GetSanPhamByid(id);

        }

        public bool UpdateSanPham(SanPham obj)
        {
            _isanphamRP.UpdateSanPham(obj);
            return true;
        }

        public List<SanPhamVm> GetAllSanPhamVm()
        {
            var sp = (from a in _context.sanPhams
                      join b in _context.loaiSps on a.IdLoai equals b.Id
                      select new SanPhamVm
                      {
                          Id = a.Id,
                          TenSp = a.TenSp,
                          HinhAnh = a.HinhAnh,
                          MoTa = a.MoTa,
                          GiaBan = a.GiaBan,
                          TrangThai = a.TrangThai,
                          TenLoaiSp = b.TenLoai

                      }).ToList();
            return sp;
        }
    }
}
