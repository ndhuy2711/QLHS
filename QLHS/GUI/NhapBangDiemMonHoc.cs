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
    public partial class NhapBangDiemMonHoc : Form
    {
        public NhapBangDiemMonHoc()
        {
            InitializeComponent();
        }
        QLHS_DTO RowSelected;
        public void LoadData()
        {
            try
            {
                QLHS_BUS bus = new QLHS_BUS();
                DataTable dt = bus.LayTatCaBangDiem();
                DataTable dt_1 = bus.LayDSMonHoc();
                cb_tenmh.DataSource = dt_1;
                cb_tenmh.DisplayMember = "TenMonHoc";
                cb_tenmh.ValueMember = "TenMonHoc";
                dtgv_danhsachbangdiem.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    dtgv_danhsachbangdiem.Rows[0].Selected = true;
                    RowSelected = new QLHS_DTO();
                    RowSelected.MaBangDiem = dtgv_danhsachbangdiem.SelectedRows[0].Cells["MaBangDiem"].Value.ToString();
                    RowSelected.MaHocSinh = dtgv_danhsachbangdiem.SelectedRows[0].Cells["MaHocSinh"].Value.ToString();
                    RowSelected.MaMonHoc = dtgv_danhsachbangdiem.SelectedRows[0].Cells["MaMonHoc"].Value.ToString();
                    RowSelected.Diem15phut = dtgv_danhsachbangdiem.SelectedRows[0].Cells["Diem15phut"].Value.ToString();
                    RowSelected.Diem1tiet = dtgv_danhsachbangdiem.SelectedRows[0].Cells["Diem1tiet"].Value.ToString();
                    RowSelected.DiemCuoiKi = dtgv_danhsachbangdiem.SelectedRows[0].Cells["DiemCuoiKi"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void dtgv_danhsachbangdiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv_danhsachbangdiem.CurrentRow.Index;
            txt_mahocsinh.Text = dtgv_danhsachbangdiem.Rows[i].Cells[0].Value.ToString();
            txt_tenhs.Text = dtgv_danhsachbangdiem.Rows[i].Cells[1].Value.ToString();
            cb_tenmh.Text = dtgv_danhsachbangdiem.Rows[i].Cells[2].Value.ToString();
            txt_diem15phut.Text = dtgv_danhsachbangdiem.Rows[i].Cells[3].Value.ToString();
            txt_diem1tiet.Text = dtgv_danhsachbangdiem.Rows[i].Cells[4].Value.ToString();
            txt_diemck.Text = dtgv_danhsachbangdiem.Rows[i].Cells[5].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NhapBangDiemMonHoc_Load(object sender, EventArgs e)
        {
            LoadData();        
        }

        private void txt_mahocsinh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                QLHS_BUS bus = new QLHS_BUS();
                QLHS_DTO hs = new QLHS_DTO();
                hs.MaHocSinh = txt_mahocsinh.Text;
                DataTable dt = bus.TIMHSBANGMA(hs.MaHocSinh);
                txt_tenhs.Text = dt.Rows[0]["HoTen"].ToString();
            }
            catch (Exception ex)
            {
                txt_tenhs.Text = "";
            }
        }

        private void cb_tenmh_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLHS_BUS bus = new QLHS_BUS();
            DataTable dt = bus.LayMaMH(cb_tenmh.Text);
            if(dt.Rows.Count > 0)
            {
                lb_mamonhoc.Text = dt.Rows[0]["MaMonHoc"].ToString();
            }   
            
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_diem15phut.Text != "") && (txt_diem1tiet.Text != "") && (txt_diemck.Text != "") && (txt_mahocsinh.Text != "") && (txt_tenhs.Text != ""))
                {
                    QLHS_DTO hs = new QLHS_DTO();

                    hs.MaHocSinh = txt_mahocsinh.Text;
                    hs.MaMonHoc = lb_mamonhoc.Text;
                    hs.Diem15phut = txt_diem15phut.Text;
                    hs.Diem1tiet = txt_diem1tiet.Text;
                    hs.DiemCuoiKi = txt_diemck.Text;
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.ThemBangDiem(hs);
                    MessageBox.Show("Thêm thành công bảng điểm cho học sinh " + txt_mahocsinh.Text + " !", "Thông báo");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công! Mời bạn xem lại dữ liệu nhập! ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
