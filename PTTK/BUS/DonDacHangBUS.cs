using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DonDacHangBUS
    {
        public static List<DTO.DonDacHangDTO> getListDDH()
        {
            DataTable dt = DAL.DonDacHangDAL.getList();
            List<DTO.DonDacHangDTO> listDDH = (from x in dt.AsEnumerable()
                                           select new DTO.DonDacHangDTO()
                                           {
                                               MaDDH = Convert.ToString(x["MaDDH"]).Trim(),
                                               MaNCC = Convert.ToString(x["MaNCC"]),
                                               MaTB = Convert.ToString(x["MaTB"]),
                                               SLuong = Convert.ToInt32(x["SLuong"]),
                                               DonGia = Convert.ToInt32(x["DonGia"]),
                                               ThoiGianGiao = Convert.ToInt32(x["ThoiGianGiao"]),
                                               XacNhan = Convert.ToBoolean(x["XacNhan"]),
                                               TinhTrang = Convert.ToBoolean(x["TinhTrang"])
                                           }).ToList();
            return listDDH;
        }

        public static List<DTO.DonDacHangDTO> getHHD(string MaDDH)
        {
            DataTable dt = DAL.DonDacHangDAL.getHHD(MaDDH);
            List<DTO.DonDacHangDTO> listDDH = (from x in dt.AsEnumerable()
                                               select new DTO.DonDacHangDTO()
                                               {
                                                   MaDDH = Convert.ToString(x["MaDDH"]).Trim(),
                                                   MaNCC = Convert.ToString(x["MaNCC"]),
                                                   MaTB = Convert.ToString(x["MaTB"]),
                                                   SLuong = Convert.ToInt32(x["SLuong"]),
                                                   DonGia = Convert.ToInt32(x["DonGia"]),
                                                   ThoiGianGiao = Convert.ToInt32(x["ThoiGianGiao"]),
                                                   XacNhan = Convert.ToBoolean(x["XacNhan"]),
                                                   TinhTrang = Convert.ToBoolean(x["TinhTrang"])
                                               }).ToList();
            return listDDH;
        }
    }
}
