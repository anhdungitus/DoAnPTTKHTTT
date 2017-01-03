using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ProductDAL : clsKetNoi
    {
        public DataTable ListProduct()
        {
            return LoadData("Select * from Product");
        }   
    }
}
