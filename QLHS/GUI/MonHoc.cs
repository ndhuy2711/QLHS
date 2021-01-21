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
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }
        QLHS_DTO RowSelected;
        public void LoadData()
        {
            try
            {
                QLHS_BUS bus = new QLHS_BUS();
                DataTable dt = bus.LayTatCaMonHoc();
                dtgv_danhsachmonhoc.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    dtgv_danhsachmonhoc.Rows[0].Selected = true;
                    RowSelected = new QLHS_DTO();
                    RowSelected.MaHocSinh = dtgv_danhsachmonhoc.SelectedRows[0].Cells["MaMonHoc"].Value.ToString();
                    RowSelected.HoTen = dtgv_danhsachmonhoc.SelectedRows[0].Cells["TenMonHoc"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void MonHoc_Load(object sender, EventArgs e)
        {
            LoadData();
            txt_mamonhoc.Enabled = false;
            txt_tenmonhoc.Enabled = false;

        }

        private void btn_themmon_Click(object sender, EventArgs e)
        {
            txt_mamonhoc.Text = "";
            txt_tenmonhoc.Text = "";
            btn_themmon.Visible = false;
            btn_XacNhan.Visible = true;

            txt_mamonhoc.Enabled = true;
            txt_tenmonhoc.Enabled = true;
            btn_capnhatmon.Enabled = false;
            btn_xoa.Enabled = false;
            btn_nhapdiemmonhoc.Enabled = false;

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DR = MessageBox.Show("Bạn có chắc chắn xoá môn học này!", "Thông báo", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == DR)
                {
                    QLHS_DTO hs = new QLHS_DTO();
                    hs.MaMonHoc = txt_mamonhoc.Text;
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.XoaMonHoc(hs);
                    MessageBox.Show("Xoá thành công môn học " + txt_mamonhoc.Text + " !", "Thông báo");
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

        private void btn_capnhatmon_Click(object sender, EventArgs e)
        {
            btn_capnhatmon.Visible = false;
            btn_luu.Visible = true;
            txt_mamonhoc.Enabled = false;
            txt_tenmonhoc.Enabled = true;
            btn_themmon.Enabled = false;
            btn_xoa.Enabled = false;
            btn_nhapdiemmonhoc.Enabled = false;

        }

        private void dtgv_danhsachmonhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv_danhsachmonhoc.CurrentRow.Index;
            txt_mamonhoc.Text = dtgv_danhsachmonhoc.Rows[i].Cells[0].Value.ToString();
            txt_tenmonhoc.Text = dtgv_danhsachmonhoc.Rows[i].Cells[1].Value.ToString();
        }


        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_mamonhoc.Text != "" && txt_tenmonhoc.Text != "")
                {
                    QLHS_DTO hs = new QLHS_DTO();
                    hs.MaMonHoc = txt_mamonhoc.Text;
                    hs.TenMonHoc = txt_tenmonhoc.Text;
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.ThemMonHoc(hs);
                    MessageBox.Show("Thêm thành công môn học " + txt_tenmonhoc.Text + " !", "Thông báo");
                    LoadData();
                    btn_themmon.Visible = true;
                    btn_XacNhan.Visible = false;

                    txt_mamonhoc.Enabled = false;
                    txt_tenmonhoc.Enabled = false;
                    btn_capnhatmon.Enabled = true;
                    btn_xoa.Enabled = true;
                    btn_nhapdiemmonhoc.Enabled = true;
                }    
               else
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin Môn Học!");
                }

            }
            catch
            {
                MessageBox.Show("Mã môn học này đã tồn tại!");
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_mamonhoc.Text != "") && (txt_tenmonhoc.Text != ""))
                {
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.CapNhatMonHoc(txt_mamonhoc.Text, txt_tenmonhoc.Text);
                    MessageBox.Show("Cập nhật thành công môn học " + txt_mamonhoc.Text + " !", "Thông báo");
                    LoadData();
                    btn_capnhatmon.Visible = true;
                    btn_luu.Visible = false;
                    txt_mamonhoc.Enabled = false;
                    txt_tenmonhoc.Enabled = false;
                    btn_themmon.Enabled = true;
                    btn_xoa.Enabled = true;
                    btn_nhapdiemmonhoc.Enabled = true;
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

        private void btn_nhapdiemmonhoc_Click(object sender, EventArgs e)
        {
            NhapBangDiemMonHoc nbdmh = new NhapBangDiemMonHoc();
            this.Hide();
            nbdmh.ShowDialog();
            this.Show();
        }
    }
}
