using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DOAN
{
    public partial class Form1 : Form
    {
        private ProductBUS products = new ProductBUS();
        public Form1()
        {
            InitializeComponent();
            gridviewProduct.DataSource = products.All(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ProductDTO> p = products.getListProduct();   
        }
    }
}
