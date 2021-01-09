using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Lop : Form
    {
        public Lop()
        {
            InitializeComponent();
        }


        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_lop_MouseClick(object sender, MouseEventArgs e)
        {
            
            
            
        }

        private void cb_lop_DropDown(object sender, EventArgs e)
        {
            if (cb_khoi.Text == "Khối 10")
            {
                cb_lop.Items.Clear();
                cb_lop.Items.Add("A1");
                cb_lop.Items.Add("A2");
                cb_lop.Items.Add("A3");
                cb_lop.Items.Add("A4");
            }
            if (cb_khoi.Text == "Khối 11")
            {
                cb_lop.Items.Clear();
                cb_lop.Items.Add("A1");
                cb_lop.Items.Add("A2");
                cb_lop.Items.Add("A3");
            }
            if (cb_khoi.Text == "Khối 12")
            {
                cb_lop.Items.Clear();
                cb_lop.Items.Add("A1");
                cb_lop.Items.Add("A2");
            }
        }
    }
}
