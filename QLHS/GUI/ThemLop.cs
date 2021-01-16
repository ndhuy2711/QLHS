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
namespace GUI
{
    public partial class ThemLop : Form
    {
        public ThemLop()
        {
            InitializeComponent();
        }
        QLHS_DTO RowSelected;
        public void LoadData()
        {
            try
            {
                QLHS_BUS bus = new QLHS_BUS();
                DataTable dt = bus.LayTatCaLop();
                dtgv_themlop.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    dtgv_themlop.Rows[0].Selected = true;
                    RowSelected = new QLHS_DTO();
                    RowSelected.MaLop = dtgv_themlop.SelectedRows[0].Cells["MaLop"].Value.ToString();
                    RowSelected.TenLop = dtgv_themlop.SelectedRows[0].Cells["TenLop"].Value.ToString();
                    RowSelected.SiSo = dtgv_themlop.SelectedRows[0].Cells["SiSo"].Value.ToString();
                    RowSelected.MaKhoiLop = dtgv_themlop.SelectedRows[0].Cells["MaKhoiLop"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ThemLop_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgv_themlop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv_themlop.CurrentRow.Index;
            txt_malop.Text = dtgv_themlop.Rows[i].Cells[0].Value.ToString();
            txt_tenlop.Text = dtgv_themlop.Rows[i].Cells[1].Value.ToString();
            txt_siso.Text = dtgv_themlop.Rows[i].Cells[2].Value.ToString();
            txt_makhoilop.Text = dtgv_themlop.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            QLHS_DTO hs = new QLHS_DTO();
            hs.MaLop = txt_malop.Text;
            hs.TenLop = txt_tenlop.Text;
            hs.SiSo = txt_siso.Text;
            hs.MaKhoiLop = txt_makhoilop.Text;
            QLHS_BUS bus = new QLHS_BUS();
            bus.ThemLop(hs);
            MessageBox.Show("Thêm thành công lớp " + txt_malop.Text + " !", "Thông báo");
            LoadData();
        }

        private void btn_capnhatlop_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_malop.Text != "") &&  (txt_tenlop.Text != "") && (txt_siso.Text != "") && (txt_makhoilop.Text != ""))
                {
                    QLHS_DTO hs = new QLHS_DTO();
                    hs.MaLop = txt_malop.Text;
                    hs.TenLop = txt_tenlop.Text;
                    hs.SiSo = txt_siso.Text;
                    hs.MaKhoiLop = txt_makhoilop.Text;
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.CapNhatLop(hs);
                    MessageBox.Show("Cập nhật thành công lớp " + txt_malop.Text + " !", "Thông báo");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công! Mời bạn xem lại dữ liệu nhập! ", "Thông báo");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_xoalop_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DR = MessageBox.Show("Bạn có chắc chắn xoá lớp này!", "Thông báo", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == DR)
                {
                    QLHS_DTO hs = new QLHS_DTO();
                    hs.MaLop = txt_malop.Text;
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.XoaLop(hs);
                    MessageBox.Show("Xoá thành công lớp " + txt_malop.Text + " !", "Thông báo");
                    LoadData();
                }
                else
                {
                    LoadData();
                }
            }

            catch (Exception ex)
            {

            }
        }

        private void btn_xeplop_Click(object sender, EventArgs e)
        {
            Lop l = new Lop();
            l.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
