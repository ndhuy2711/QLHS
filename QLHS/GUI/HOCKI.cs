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
    public partial class HOCKI : Form
    {
        public HOCKI()
        {
            InitializeComponent();
        }
        QLHS_DTO RowSelected;
        public void LoadData()
        {
            try
            {
                QLHS_BUS bus = new QLHS_BUS();
                DataTable dt = bus.LayTatCaHocKi();
                dtgv_danhsachhocki.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    dtgv_danhsachhocki.Rows[0].Selected = true;
                    RowSelected = new QLHS_DTO();
                    RowSelected.MaHocKi = dtgv_danhsachhocki.SelectedRows[0].Cells["MaHocKi"].Value.ToString();
                    RowSelected.TenHocKi = dtgv_danhsachhocki.SelectedRows[0].Cells["TenHocKi"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_themhocki_Click(object sender, EventArgs e)
        {
            QLHS_DTO hs = new QLHS_DTO();
            hs.MaHocKi = txt_mahocki.Text;
            hs.TenHocKi = txt_tenhocki.Text;
            QLHS_BUS bus = new QLHS_BUS();
            bus.ThemHocKi(hs);
            MessageBox.Show("Thêm thành công học kì " + txt_tenhocki.Text + " !", "Thông báo");
            LoadData();
        }

        private void HOCKI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_xoahocki_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DR = MessageBox.Show("Bạn có chắc chắn xoá học kì này!", "Thông báo", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == DR)
                {
                    QLHS_DTO hs = new QLHS_DTO();
                    hs.MaHocKi = txt_mahocki.Text;
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.XoaHocKi(hs);
                    MessageBox.Show("Xoá thành công học kì " + txt_mahocki.Text + " !", "Thông báo");
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

        private void dtgv_danhsachhocki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv_danhsachhocki.CurrentRow.Index;
            txt_mahocki.Text = dtgv_danhsachhocki.Rows[i].Cells[0].Value.ToString();
            txt_tenhocki.Text = dtgv_danhsachhocki.Rows[i].Cells[1].Value.ToString();
        }

        private void btn_capnhathocki_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_mahocki.Text != "") && (txt_tenhocki.Text != ""))
                {
                    QLHS_DTO hs = new QLHS_DTO();
                    hs.MaHocKi = txt_mahocki.Text;
                    hs.TenHocKi = txt_tenhocki.Text;
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.CapNhatHocKi(hs);
                    MessageBox.Show("Cập nhật thành công học kì " + txt_mahocki.Text + " !", "Thông báo");
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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
