using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DAL;

namespace BUS
{
    public class ThietBiBUS
    {
        public ThietBiDAL data = new ThietBiDAL();
        public static void getThietBi ()
        {
            DataTable dt = DAL.ThietBiDAL.DSThietBi();
            List<DTO.ThietBiDTO> listTB = (from x in dt.AsEnumerable()
                                           select new DTO.ThietBiDTO()
                                           {
                                               MaTB = Convert.ToString(x["MaTB"]).Trim(),
                                               Ten = Convert.ToString(x["Ten"]),
                                               SLKho = Convert.ToInt32(x["SLKho"]),
                                               LoaiThietBi = Convert.ToInt32(x["LoaiThietBi"])
                                           }).ToList();
            

        }

        public DataTable getData()
        {
            return DAL.ThietBiDAL.DSThietBi();
        }
        
    }
}
