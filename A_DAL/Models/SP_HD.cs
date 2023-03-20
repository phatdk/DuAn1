using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class SP_HD
    {
        public Guid IdHd { get; set; }
        public Guid IdSp { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}
