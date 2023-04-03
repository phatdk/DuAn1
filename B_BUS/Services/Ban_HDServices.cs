﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRespositorys;
using A_DAL.Models;
using A_DAL.Respositorys;
using B_BUS.IServices;

namespace B_BUS.Services
{
    public class Ban_HDServices : IBan_HDServices
    {
        IBan_HDIRespositorys _HDIRespositorys;
        public Ban_HDServices()
        {
            _HDIRespositorys = new Ban_HDIRespositorys();
        }
        public bool AddBan_HD(Ban_HD obj)
        {
            return _HDIRespositorys.AddBan_HD(obj);
        }

        public bool DeleteBan_HD(Ban_HD obj)
        {
            throw new NotImplementedException();
        }

        public List<Ban_HD> GetAllBan_HD()
        {
            return _HDIRespositorys.GetAllBan_HD();
        }

        public List<Ban_HD> GetBan_HDByid(Guid id)
        {
            return _HDIRespositorys.GetBan_HDByid(id);
        }

        public Ban_HD GetBan_HDUnCheck(Guid id)
        {
            return _HDIRespositorys.GetBan_HDUnCheck(id);
        }

        public bool UpdateBan_HD(Ban_HD obj)
        {
            return _HDIRespositorys.UpdateBan_HD(obj);
        }
    }
}
