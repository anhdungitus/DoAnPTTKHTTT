using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class ProductBUS
    {
        private ProductDTO info = new ProductDTO();
        private ProductDAL data = new ProductDAL();

        public DataTable All()
        {
            return data.ListProduct();
        }

        public List<ProductDTO> getListProduct()
        {
            List<ProductDTO> dsProduct = (from x in All().AsEnumerable()
                            select new ProductDTO()
                            {
                                ProductId = Convert.ToInt32(x["ProductId"]),
                                ProductName = Convert.ToString(x["ProductName"]),
                                Category = Convert.ToInt32(x["Category"]),
                                Description = Convert.ToString(x["Description"])
                            }).ToList();
            return dsProduct;
        }
    }
}
