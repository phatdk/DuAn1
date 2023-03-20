using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class KhuyenMai
    {
        public Guid Id { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayBd { get; set; }
        public DateTime NgayKt { get; set; }
        public string MoTa { get; set; }
        public decimal PhamTramGiam { get; set; }
        public int SoTienGiam { get; set; }
        public string DkGiam { get; set; }
        public int TrangThai { get; set; }
        public virtual List<SanPham> SanPhams { get; set; }
    }
}
