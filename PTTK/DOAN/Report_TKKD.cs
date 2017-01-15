using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class Report_TKKD : Form
    {
        public Report_TKKD()
        {
            InitializeComponent();
        }

        private void Report_TKDT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThongKeKinhDoanh.DataTableTKKD' table. You can move, or remove it, as needed.
            this.DataTableTKKDTableAdapter.Fill(this.ThongKeKinhDoanh.DataTableTKKD);

            this.reportViewer1.RefreshReport();
        }
    }
}
