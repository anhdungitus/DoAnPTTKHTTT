using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DAL;
using DTO;

namespace BUS
{
    public class DonDacHangBUS
    {
        public DonDacHangDAL data = new DonDacHangDAL();

        public DataTable getListDDH()
        {
            return data.LisDonDatHang();
        }
        public void insert(DonDacHangDTO p)
        {
            data.insert(p);
        }
    }
}
