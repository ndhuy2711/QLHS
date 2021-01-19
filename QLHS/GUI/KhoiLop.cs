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
    public partial class KhoiLop : Form
    {
        public KhoiLop()
        {
            InitializeComponent();
        }
        QLHS_DTO RowSelected;
        public void LoadData()
        {
            try
            {
                QLHS_BUS bus = new QLHS_BUS();
                DataTable dt = bus.LayTatCaKhoiLop();
                dtgv_khoilop.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    dtgv_khoilop.Rows[0].Selected = true;
                    RowSelected = new QLHS_DTO();
                    RowSelected.MaKhoiLop = dtgv_khoilop.SelectedRows[0].Cells["MaKhoiLop"].Value.ToString();
                    RowSelected.TenKhoiLop = dtgv_khoilop.SelectedRows[0].Cells["TenKhoiLop"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv_khoilop.CurrentRow.Index;
            txt_makhoilop.Text = dtgv_khoilop.Rows[i].Cells[0].Value.ToString();
            txt_tenkhoilop.Text = dtgv_khoilop.Rows[i].Cells[1].Value.ToString();
        }

        private void KhoiLop_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_themkhoilop_Click(object sender, EventArgs e)
        {
            try
            {
                QLHS_DTO hs = new QLHS_DTO();
                hs.MaKhoiLop = txt_makhoilop.Text;
                hs.TenKhoiLop = txt_tenkhoilop.Text;
                QLHS_BUS bus = new QLHS_BUS();
                bus.ThemKhoiLop(hs);
                MessageBox.Show("Thêm thành công khối lớp " + txt_tenkhoilop.Text + " !", "Thông báo");
                LoadData();
            }
            catch
            {
                MessageBox.Show("Đã tồn tại mã Khối!");
            }
        }

        private void btn_xoakhoilop_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DR = MessageBox.Show("Bạn có chắc chắn xoá khối lớp này!", "Thông báo", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == DR)
                {
                    QLHS_DTO hs = new QLHS_DTO();
                    hs.MaKhoiLop = txt_makhoilop.Text;
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.XoaKhoiLop(hs);
                    MessageBox.Show("Xoá thành công khối lớp " + txt_makhoilop.Text + " !", "Thông báo");
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

        private void btn_capnhatkhoilop_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_makhoilop.Text != "") && (txt_tenkhoilop.Text != ""))
                {
                    QLHS_DTO hs = new QLHS_DTO();
                    hs.MaKhoiLop = txt_makhoilop.Text;
                    hs.TenKhoiLop = txt_tenkhoilop.Text;
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.CapNhatKhoiLop(hs);
                    MessageBox.Show("Cập nhật thành công khối lớp " + txt_makhoilop.Text + " !", "Thông báo");
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

        private void btn_themlop_Click(object sender, EventArgs e)
        {
            ThemLop tl = new ThemLop();
            this.Hide();
            tl.ShowDialog();
            this.Show();
        }
    }
}
