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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lậpDanhSáchHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiepNhanHS tnhs = new frmTiepNhanHS();
            tnhs.Show();
        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lop l = new Lop();
            l.Show();
        }

        private void traCứuHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuuHS tchs = new TraCuuHS();
            tchs.Show();
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThayDoiQuyDinh tdqd = new ThayDoiQuyDinh();
            tdqd.Show();
        }

        private void thêmKhốiLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhoiLop kl = new KhoiLop();
            kl.Show();
        }

        private void thêmLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemLop tl = new ThemLop();
            tl.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.Show();
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void họcKìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HOCKI hk = new HOCKI();
            hk.Show();

        }

        private void nhậpBảngĐiểmMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapBangDiemMonHoc nbdmh = new NhapBangDiemMonHoc();

            nbdmh.Show();

        }
    }
}
