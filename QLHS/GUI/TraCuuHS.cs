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

      /*  public void LoadData()
        {
            try
            {
                QLHS_BUS bus = new QLHS_BUS();
                DataTable dt = bus.LayTatCaHocSinh();
                dtgv_danhsachhocsinh.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    dtgv_danhsachhocsinh.Rows[0].Selected = true;
                    RowSelected = new QLHS_DTO();
                    RowSelected.MaHocSinh = dtgv_danhsachhocsinh.SelectedRows[0].Cells["MaHocSinh"].Value.ToString();
                    RowSelected.HoTen = dtgv_danhsachhocsinh.SelectedRows[0].Cells["HoTen"].Value.ToString();
                    RowSelected.GioiTinh = dtgv_danhsachhocsinh.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                    RowSelected.NgaySinh = dtgv_danhsachhocsinh.SelectedRows[0].Cells["NgaySinh"].Value.ToString();
                    RowSelected.DiaChi = dtgv_danhsachhocsinh.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                    RowSelected.Email = dtgv_danhsachhocsinh.SelectedRows[0].Cells["Email"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }
      */

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TraCuuHS_Load(object sender, EventArgs e)
        {

        }
    }
}
