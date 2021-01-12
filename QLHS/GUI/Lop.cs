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
                cb_lop.Items.Add("A1");
                cb_lop.Items.Add("A2");
                cb_lop.Items.Add("A3");
                cb_lop.Items.Add("A4");
            }
            if (cb_khoi.Text == "Khối 11")
            {
                cb_lop.Items.Clear();
                cb_lop.Items.Add("A1");
                cb_lop.Items.Add("A2");
                cb_lop.Items.Add("A3");
            }
            if (cb_khoi.Text == "Khối 12")
            {
                cb_lop.Items.Clear();
                cb_lop.Items.Add("A1");
                cb_lop.Items.Add("A2");
            }
        }

        private void dtgv_danhsachlop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lop_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
