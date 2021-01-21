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
using DAL;
namespace GUI
{
    public partial class ThayDoiQuyDinh : Form
    {
        public ThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            txt_diem.Enabled = false;
            txt_siso.Enabled = false;
            txt_tuoilon.Enabled = false;
            txt_tuoinho.Enabled = false;
        }

        private void btn_tuoi_Click(object sender, EventArgs e)
        {
            txt_tuoinho.Enabled = true;
            txt_tuoilon.Enabled = true;
            btn_diem.Enabled = false;
            btn_siso.Enabled = false;
            btn_tuoi.Visible = false;
            btn_luu.Visible = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_tuoilon.Text != "") && (txt_tuoinho.Text != ""))
                {
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.CapNhatTuoi(Int32.Parse (txt_tuoinho.Text), Int32.Parse (txt_tuoilon.Text));
                    MessageBox.Show("Cập nhật thành công số tuổi quy định", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công! Mời bạn xem lại dữ liệu nhập! ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mời nhập lại!");
            }

            txt_tuoinho.Text = "";
            txt_tuoilon.Text = "";
            txt_tuoinho.Enabled = false;
            txt_tuoilon.Enabled = false;
            btn_diem.Enabled = true;
            btn_siso.Enabled = true;
            btn_tuoi.Visible = true;
            btn_luu.Visible = false;
        }

        private void btn_luuss_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_siso.Text != "") )
                {
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.CapNhatSiSo(Int32.Parse(txt_siso.Text));
                    MessageBox.Show("Cập nhật thành công sỉ số lớp", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công! Mời bạn xem lại dữ liệu nhập! ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mời nhập lại!");
            }


            txt_diem.Enabled = false;
            txt_siso.Enabled = false;
            txt_tuoilon.Enabled = false;
            txt_tuoinho.Enabled = false;
            btn_tuoi.Enabled = true;
            btn_luuss.Visible = false;
            btn_siso.Visible = true;
            btn_diem.Enabled = true;
            txt_siso.Text = "";
        }

        private void btn_siso_Click(object sender, EventArgs e)
        {
            txt_diem.Enabled = false;
            txt_siso.Enabled = true;
            txt_tuoilon.Enabled = false;
            txt_tuoinho.Enabled = false;
            btn_tuoi.Enabled = false;
            btn_luuss.Visible = true;
            btn_siso.Visible = false;
            btn_diem.Enabled = false;
        }

        private void btn_diem_Click(object sender, EventArgs e)
        {
            txt_diem.Enabled = true;
            txt_siso.Enabled = false;
            txt_tuoilon.Enabled = false;
            txt_tuoinho.Enabled = false;
            btn_tuoi.Enabled = false;
            btn_luudiem.Visible = true;
            btn_siso.Enabled = false;
            btn_diem.Visible = false;
        }

        private void btn_luudiem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_diem.Text != ""))
                {
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.CapNhatDiem(Int32.Parse(txt_diem.Text));
                    MessageBox.Show("Cập nhật thành công điểm đạt môn", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công! Mời bạn xem lại dữ liệu nhập! ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mời nhập lại!");
            }

            txt_diem.Enabled = false;
            txt_siso.Enabled = false;
            txt_tuoilon.Enabled = false;
            txt_tuoinho.Enabled = false;
            btn_tuoi.Enabled = true;
            btn_luudiem.Visible = false;
            btn_siso.Enabled = true;
            btn_diem.Visible = true;
            txt_diem.Text = "";
        }
    }
}
