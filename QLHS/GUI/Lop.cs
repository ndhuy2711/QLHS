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
    public partial class Lop : Form
    {
        public Lop()
        {
            InitializeComponent();
        }
        QLHS_DTO RowSelected;
        public void LoadData()
        {
            try
            {
                QLHS_BUS bus = new QLHS_BUS();
                DataTable dt = bus.DSLop();
                DataTable dt_1 = bus.LayKhoiLop();
                dtgv_danhsachlop.DataSource = dt;
                cb_khoi.DataSource = dt_1;
                cb_khoi.DisplayMember = "MaKhoiLop";
                cb_khoi.ValueMember = "MaKhoiLop";
                if (dt.Rows.Count > 0)
                {
                    dtgv_danhsachlop.Rows[0].Selected = true;
                    RowSelected = new QLHS_DTO();
                    RowSelected.MaHocSinh = dtgv_danhsachlop.SelectedRows[0].Cells["MaHocSinh"].Value.ToString();
                    RowSelected.HoTen = dtgv_danhsachlop.SelectedRows[0].Cells["HoTen"].Value.ToString();
                    RowSelected.TenKhoiLop = dtgv_danhsachlop.SelectedRows[0].Cells["TenKhoiLop"].Value.ToString();
                    RowSelected.TenLop = dtgv_danhsachlop.SelectedRows[0].Cells["TenLop"].Value.ToString();
                    RowSelected.SiSo = dtgv_danhsachlop.SelectedRows[0].Cells["SiSo"].Value.ToString();
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

     

        private void Lop_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
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
                txt_tenhocsinh.Text = dt.Rows[0]["HoTen"].ToString();
                dt_ngaysinh.Format = DateTimePickerFormat.Custom;
                dt_ngaysinh.CustomFormat = "dd/MM/yyyy";
                dt_ngaysinh.Text = dt.Rows[0]["NgaySinh"].ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void txt_namsinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                QLHS_DTO hs = new QLHS_DTO();
               
                hs.MaHocSinh = txt_mahocsinh.Text;
                hs.HoTen = txt_tenhocsinh.Text;
                hs.TenKhoiLop = cb_khoi.Text;
                hs.TenLop = cb_lop.Text;


                QLHS_BUS bus = new QLHS_BUS();

                bus.ThemDSLop(cb_lop.Text, txt_mahocsinh.Text);
                MessageBox.Show("Thêm thành công học sinh vào lớp " + cb_lop.Text + " !", "Thông báo");
                LoadData();
            }
            catch
            {
                MessageBox.Show("Error: Lỗi Database !");
            }
          
        }

        private void cb_khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLHS_BUS bus = new QLHS_BUS();
            DataTable dt = bus.LayLopHoc(cb_khoi.Text);
            cb_lop.DataSource = dt;
            cb_lop.DisplayMember = "TenLop";
            cb_lop.ValueMember = "TenLop";
        }

        private void dtgv_danhsachlop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
