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
    public partial class frmTiepNhanHS : Form
    {
        public frmTiepNhanHS()
        {
            InitializeComponent();
        }

        private void dt_ngaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_xeplophocsinh_Click(object sender, EventArgs e)
        {
            Lop l = new Lop();
            l.Show();
        }
    }
}
