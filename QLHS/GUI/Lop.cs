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
                dtgv_danhsachlop.DataSource = dt;
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
                cb_lop.Items.Add("10A1");
                cb_lop.Items.Add("10A2");
                cb_lop.Items.Add("10A3");
                cb_lop.Items.Add("10A4");
            }
            if (cb_khoi.Text == "Khối 11")
            {
                cb_lop.Items.Clear();
                cb_lop.Items.Add("11A1");
                cb_lop.Items.Add("11A2");
                cb_lop.Items.Add("11A3");
            }
            if (cb_khoi.Text == "Khối 12")
            {
                cb_lop.Items.Clear();
                cb_lop.Items.Add("12A1");
                cb_lop.Items.Add("12A2");
            }
        }

        private void dtgv_danhsachlop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lop_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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

        private void txt_mahocsinh_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_namsinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            QLHS_DTO hs = new QLHS_DTO();
            hs.MaHocSinh = txt_mahocsinh.Text;
            hs.HoTen = txt_tenhocsinh.Text;
            hs.TenKhoiLop = cb_khoi.Text;
            hs.TenLop = cb_lop.Text;

            
            QLHS_BUS bus = new QLHS_BUS();
            
            bus.ThemHSVaoLop(hs.TenLop);
            MessageBox.Show("Thêm thành công học sinh vào lớp " + cb_lop.Text + " !", "Thông báo");
            LoadData();
        }
    }
}
