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

namespace DOAN
{
    public partial class ThongKeKho : Form
    {
        ThietBiBUS data = new ThietBiBUS();
        public ThongKeKho()
        {
            InitializeComponent();
        }

        private void ThongKeKho_Load(object sender, EventArgs e)
        {
            grvKho.DataSource = data.getData();
        }

    }
}
