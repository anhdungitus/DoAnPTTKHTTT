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
    public partial class inputMaDDH : Form
    {
        String maDDH;
        public inputMaDDH()
        {
            InitializeComponent();
            List<DTO.DonDacHangDTO> listDDH = BUS.DonDacHangBUS.getListDDH();
            for (int i=0; i<listDDH.Count; i++)
            {
                cbbMaDDH.Items.Add(listDDH[i].MaDDH);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbMaDDH.Text == "")
            {
                MessageBox.Show("Khong tin thay ddh");
                return;
            }
            else
            {
                maDDH = cbbMaDDH.Text;
            }
        }
    }
}
