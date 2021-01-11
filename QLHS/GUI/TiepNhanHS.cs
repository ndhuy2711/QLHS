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
    public partial class frmTiepNhanHS : Form
    {
        public frmTiepNhanHS()
        {
            InitializeComponent();
        }
        QLHS_DTO RowSelected;
        public void LoadData()
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
        private void dt_ngaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_xeplophocsinh_Click(object sender, EventArgs e)
        {
            Lop l = new Lop();
            l.Show();
        }

        private void frmTiepNhanHS_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_hoanthanh_Click(object sender, EventArgs e)
        {
            try
            {
                QLHS_DTO hs = new QLHS_DTO();
                hs.MaHocSinh = txt_mahocsinh.Text;
                hs.HoTen = txt_hovaten.Text;
                hs.NgaySinh = dt_ngaysinh.Value.ToString();
                hs.GioiTinh = cb_gioitinh.Text;
                hs.DiaChi = txt_diachi.Text;
                hs.Email = txt_email.Text;
                QLHS_BUS bus = new QLHS_BUS();
                bus.ThemHocSinh(hs);
                LoadData();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_tailai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_xoahocsinh_Click(object sender, EventArgs e)
        {
            try
            {
                QLHS_DTO hs = new QLHS_DTO();
                hs.MaHocSinh = txt_mahocsinh.Text;
                QLHS_BUS bus = new QLHS_BUS();
                bus.XoaHocSinh(hs);
                LoadData();
            }
            catch (Exception ex)
            {

            }
        }

        private void dtgv_danhsachhocsinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv_danhsachhocsinh.CurrentRow.Index;
            txt_mahocsinh.Text = dtgv_danhsachhocsinh.Rows[i].Cells[0].Value.ToString();
            txt_hovaten.Text = dtgv_danhsachhocsinh.Rows[i].Cells[1].Value.ToString();
            cb_gioitinh.Text = dtgv_danhsachhocsinh.Rows[i].Cells[2].Value.ToString();
            txt_diachi.Text = dtgv_danhsachhocsinh.Rows[i].Cells[4].Value.ToString();
            txt_email.Text = dtgv_danhsachhocsinh.Rows[i].Cells[5].Value.ToString();
        }

        private void dtgv_danhsachhocsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
