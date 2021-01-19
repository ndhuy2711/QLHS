using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAL;
namespace GUI
{
    public partial class TraCuuHS : Form
    {
        public TraCuuHS()
        {
            InitializeComponent();
        }
        QLHS_DTO RowSelected;
        public void LoadData()
        {
            try
            {
                QLHS_BUS bus = new QLHS_BUS();
                DataTable dt = bus.TIMKIEMDSHS();
                dtgv_Timkiem.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    dtgv_Timkiem.Rows[0].Selected = true;
                    RowSelected = new QLHS_DTO();
                    RowSelected.MaHocSinh = dtgv_Timkiem.SelectedRows[0].Cells["MaHocSinh"].Value.ToString();
                    RowSelected.HoTen = dtgv_Timkiem.SelectedRows[0].Cells["HoTen"].Value.ToString();
                    RowSelected.TenLop = dtgv_Timkiem.SelectedRows[0].Cells["TenLop"].Value.ToString();
                    RowSelected.GioiTinh = dtgv_Timkiem.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                    RowSelected.NgaySinh = dtgv_Timkiem.SelectedRows[0].Cells["NgaySinh"].Value.ToString();
                    RowSelected.Email = dtgv_Timkiem.SelectedRows[0].Cells["Email"].Value.ToString();
                    RowSelected.DiaChi = dtgv_Timkiem.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TraCuuHS_Load(object sender, EventArgs e)
        {
            LoadData();
            txt_mahocsinh.DataBindings.Clear();
            txt_mahocsinh.DataBindings.Add("Text", dtgv_Timkiem.DataSource, "MaHocSinh");
            txt_hoten.DataBindings.Clear();
            txt_hoten.DataBindings.Add("Text", dtgv_Timkiem.DataSource, "HoTen");
            txt_gioitinh.DataBindings.Clear();
            txt_gioitinh.DataBindings.Add("Text", dtgv_Timkiem.DataSource, "GioiTinh");
            txt_NgaySinh.DataBindings.Clear();
            txt_NgaySinh.DataBindings.Add("Text", dtgv_Timkiem.DataSource, "NgaySinh");
            txt_tenlop.DataBindings.Clear();
            txt_tenlop.DataBindings.Add("Text", dtgv_Timkiem.DataSource, "TenLop");
            txt_email.DataBindings.Clear();
            txt_email.DataBindings.Add("Text", dtgv_Timkiem.DataSource, "Email");
            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", dtgv_Timkiem.DataSource, "DiaChi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            QLHS_BUS bus = new QLHS_BUS();
            DataTable dt = bus.TIMKIEMTHEOHOTEN(txt_timkiemtheoten.Text);
            if(dt.Rows.Count > 0)
            {
                dtgv_Timkiem.DataSource = dt;
                txt_mahocsinh.DataBindings.Clear();
                txt_mahocsinh.DataBindings.Add("Text", dtgv_Timkiem.DataSource, "MaHocSinh");
                txt_hoten.DataBindings.Clear();
                txt_hoten.DataBindings.Add("Text", dtgv_Timkiem.DataSource, "HoTen");
                txt_gioitinh.DataBindings.Clear();
                txt_gioitinh.DataBindings.Add("Text", dtgv_Timkiem.DataSource, "GioiTinh");
                txt_NgaySinh.DataBindings.Clear();
                txt_NgaySinh.DataBindings.Add("Text", dtgv_Timkiem.DataSource, "NgaySinh");
                txt_tenlop.DataBindings.Clear();
                txt_tenlop.DataBindings.Add("Text", dtgv_Timkiem.DataSource, "TenLop");
                txt_email.DataBindings.Clear();
                txt_email.DataBindings.Add("Text", dtgv_Timkiem.DataSource, "Email");
                txt_diachi.DataBindings.Clear();
                txt_diachi.DataBindings.Add("Text", dtgv_Timkiem.DataSource, "DiaChi");
            }
        }    
            
    }
}
