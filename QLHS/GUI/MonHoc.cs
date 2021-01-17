﻿using System;
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
        }

        private void btn_themmon_Click(object sender, EventArgs e)
        {
            QLHS_DTO hs = new QLHS_DTO();
            hs.MaMonHoc = txt_mamonhoc.Text;
            hs.TenMonHoc = txt_tenmonhoc.Text;
            QLHS_BUS bus = new QLHS_BUS();
            bus.ThemMonHoc(hs);
            MessageBox.Show("Thêm thành công môn học " + txt_tenmonhoc.Text + " !", "Thông báo");
            LoadData();
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
            try
            {
                if ((txt_mamonhoc.Text != "") && (txt_tenmonhoc.Text != ""))
                {
                    QLHS_DTO hs = new QLHS_DTO();
                    hs.MaMonHoc = txt_mamonhoc.Text;
                    hs.TenMonHoc = txt_tenmonhoc.Text;
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.CapNhatMonHoc(hs);
                    MessageBox.Show("Cập nhật thành công môn học " + txt_mamonhoc.Text + " !", "Thông báo");
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

        private void dtgv_danhsachmonhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv_danhsachmonhoc.CurrentRow.Index;
            txt_mamonhoc.Text = dtgv_danhsachmonhoc.Rows[i].Cells[0].Value.ToString();
            txt_tenmonhoc.Text = dtgv_danhsachmonhoc.Rows[i].Cells[1].Value.ToString();
        }

        private void btn_nhapdiemmonhoc_Click(object sender, EventArgs e)
        {
            NhapBangDiemMon nbdmh = new NhapBangDiemMon();
            nbdmh.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
