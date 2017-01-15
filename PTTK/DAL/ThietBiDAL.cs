using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ThietBiDAL
    {
        public static DataTable DSThietBi ()
        {
            clsKetNoi cn = new clsKetNoi();
            DataTable temp = cn.LoadData("SELECT * FROM ThietBi");
            cn.closeConnect();
            return temp;
        }
        
    }
}
