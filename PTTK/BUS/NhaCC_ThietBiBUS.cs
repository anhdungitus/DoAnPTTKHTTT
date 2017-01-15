using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DAL;
using DTO;

namespace BUS
{
    public class NhaCC_ThietBiBUS
    {
        NhaCC_ThietBiDAL data = new NhaCC_ThietBiDAL();
        public DataTable All()
        {
            return data.ListNCC_TB();
        }
        public DataTable getListNhaCungCap(string mathietbi)
        {
            return data.ListNhaCungCap(mathietbi);
        }
    }
}
