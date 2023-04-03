﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class Ban_HD
    {
        public Guid? IdBan { get; set; }
        public Guid? IdHd { get; set; }
        public int TrangThai { get; set; }
        public virtual Ban? Ban { get; set; }
        public virtual HoaDon? HoaDon { get; set; }
    }
}
