using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DonDacHangDAL
    {
        public static DataTable getHHD(string MaDDH)
        {
            clsKetNoi cn = new clsKetNoi();
            DataTable temp = cn.LoadData("SELECT * DonDacHang where MaDDH = '" + MaDDH + "'");
            cn.closeConnect();
            return temp;
        }

        public static DataTable getList()
        {
            clsKetNoi cn = new clsKetNoi();
            DataTable temp = cn.LoadData("SELECT * DonDacHang");
            cn.closeConnect();
            return temp;
        }
    }
}
