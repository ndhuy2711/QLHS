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
        private void btn_xeplophocsinh_Click(object sender, EventArgs e)
        {
        }

        private void frmTiepNhanHS_Load(object sender, EventArgs e)
        {
            LoadData();
            txt_mahocsinh.Enabled = false;
            txt_hovaten.Enabled = false;
            txt_email.Enabled = false;
            txt_diachi.Enabled = false;
            cb_gioitinh.Enabled = false;
            dt_ngaysinh.Enabled = false;
            txt_hovaten.DataBindings.Clear();
            txt_hovaten.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "HoTen");
            txt_mahocsinh.DataBindings.Clear();
            txt_mahocsinh.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "MaHocSinh");
            txt_email.DataBindings.Clear();
            txt_email.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "Email");
            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "DiaChi");
            cb_gioitinh.DataBindings.Clear();
            cb_gioitinh.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "GioiTinh");
            dt_ngaysinh.DataBindings.Clear();
            dt_ngaysinh.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "NgaySinh");
        }

        private void btn_hoanthanh_Click(object sender, EventArgs e)
        {
            QLHS_BUS bus = new QLHS_BUS();
            int nam = int.Parse(DateTime.Now.Year.ToString());
            int dtp = int.Parse(dt_ngaysinh.Value.Year.ToString());
            int t = nam - dtp;
            DataTable dt = bus.ThamSo();
            //MessageBox.Show(dt.Rows[0]["TuoiToiThieu"].ToString());
            //MessageBox.Show(dt.Rows[0]["TuoiToiDa"].ToString());
            try
            {
                if (Int32.Parse(dt.Rows[0]["TuoiToiThieu"].ToString()) < t && t < Int32.Parse(dt.Rows[0]["TuoiToiDa"].ToString()))
                {
                    if((txt_hovaten.Text != "") && (dt_ngaysinh.Value.ToString() != "") && (cb_gioitinh.Text != "") && (txt_diachi.Text != "") && (txt_email.Text != "") )
                    {
                        QLHS_DTO hs = new QLHS_DTO();
                        hs.MaHocSinh = txt_mahocsinh.Text;
                        hs.HoTen = txt_hovaten.Text;
                        hs.NgaySinh = dt_ngaysinh.Value.ToString();
                        hs.GioiTinh = cb_gioitinh.Text;
                        hs.DiaChi = txt_diachi.Text;
                        hs.Email = txt_email.Text;
                        bus.ThemHocSinh(hs);
                        MessageBox.Show("Thêm thành công học sinh " + txt_hovaten.Text + " !", "Thông báo");
                        LoadData();
                        bus.ThemCTDSLOP(hs);
                        btn_hoanthanh.Visible = false;
                        btn_ThemHS.Visible = true;
                        btn_capnhathocsinh.Visible = true;
                        txt_mahocsinh.Enabled = false;
                        txt_hovaten.Enabled = false;
                        txt_email.Enabled = false;
                        txt_diachi.Enabled = false;
                        cb_gioitinh.Enabled = false;
                        dt_ngaysinh.Enabled = false;
                        txt_hovaten.DataBindings.Clear();
                        txt_hovaten.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "HoTen");
                        txt_mahocsinh.DataBindings.Clear();
                        txt_mahocsinh.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "MaHocSinh");
                        txt_email.DataBindings.Clear();
                        txt_email.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "Email");
                        txt_diachi.DataBindings.Clear();
                        txt_diachi.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "DiaChi");
                        cb_gioitinh.DataBindings.Clear();
                        cb_gioitinh.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "GioiTinh");
                        dt_ngaysinh.DataBindings.Clear();
                        dt_ngaysinh.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "NgaySinh");
                    }    
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập đủ thông tin! Mời nhập lại!", "Cảnh báo");
                    }    
                }
                else
                {
                    MessageBox.Show("Tuổi của học sinh chưa đúng quy định! Không thêm thành công", "Cảnh báo");
                }
            }
            catch (Exception ex)
                {
                MessageBox.Show("Đã tồn tại Mã HS trong Data!");
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
                DialogResult DR = MessageBox.Show("Bạn có chắc chắn xoá học sinh này!", "Thông báo", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == DR)
                {
                    QLHS_DTO hs = new QLHS_DTO();
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.XoaHocSinh(txt_mahocsinh.Text);
                    MessageBox.Show("Xoá thành công học sinh " + txt_mahocsinh.Text + " !", "Thông báo");
                    LoadData();
                    ClearText();
                    txt_hovaten.DataBindings.Clear();
                    txt_hovaten.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "HoTen");
                    txt_mahocsinh.DataBindings.Clear();
                    txt_mahocsinh.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "MaHocSinh");
                    txt_email.DataBindings.Clear();
                    txt_email.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "Email");
                    txt_diachi.DataBindings.Clear();
                    txt_diachi.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "DiaChi");
                    cb_gioitinh.DataBindings.Clear();
                    cb_gioitinh.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "GioiTinh");
                    dt_ngaysinh.DataBindings.Clear();
                    dt_ngaysinh.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "NgaySinh");
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

        private void dtgv_danhsachhocsinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i;
            //i = dtgv_danhsachhocsinh.CurrentRow.Index;
            //txt_mahocsinh.Text = dtgv_danhsachhocsinh.Rows[i].Cells[0].Value.ToString();
            //txt_hovaten.Text = dtgv_danhsachhocsinh.Rows[i].Cells[1].Value.ToString();
            //cb_gioitinh.Text = dtgv_danhsachhocsinh.Rows[i].Cells[2].Value.ToString();
            //dt_ngaysinh.Text = dtgv_danhsachhocsinh.Rows[i].Cells[3].Value.ToString();
            //txt_diachi.Text = dtgv_danhsachhocsinh.Rows[i].Cells[4].Value.ToString();
            //txt_email.Text = dtgv_danhsachhocsinh.Rows[i].Cells[5].Value.ToString();
        }

        private void dtgv_danhsachhocsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_capnhathocsinh_Click(object sender, EventArgs e)
        {
            txt_mahocsinh.Enabled = true;
            txt_hovaten.Enabled = true;
            txt_email.Enabled = true;
            txt_diachi.Enabled = true;
            cb_gioitinh.Enabled = true;
            dt_ngaysinh.Enabled = true;

            btn_ThemHS.Visible = false;
            btn_Luu_HS.Visible = true;
            int index = dtgv_danhsachhocsinh.CurrentRow.Index;
            txt_mahocsinh.Enabled = false;
            txt_hovaten.Text = dtgv_danhsachhocsinh.Rows[index].Cells[1].Value.ToString();
            cb_gioitinh.Text = dtgv_danhsachhocsinh.Rows[index].Cells[2].Value.ToString();
            dt_ngaysinh.Text = dtgv_danhsachhocsinh.Rows[index].Cells[3].Value.ToString();
            txt_diachi.Text = dtgv_danhsachhocsinh.Rows[index].Cells[4].Value.ToString();
            txt_email.Text = dtgv_danhsachhocsinh.Rows[index].Cells[5].Value.ToString();
           
        }

        private void btn_themkhoilop_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Luu_HS_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_hovaten.Text != "") && (dt_ngaysinh.Value.ToString() != "") && (cb_gioitinh.Text != "") && (txt_diachi.Text != "") && (txt_email.Text != ""))
                {
                    QLHS_DTO hs = new QLHS_DTO();
                    hs.MaHocSinh = txt_mahocsinh.Text;
                    hs.HoTen = txt_hovaten.Text;
                    hs.NgaySinh = dt_ngaysinh.Value.ToString();
                    hs.GioiTinh = cb_gioitinh.Text;
                    hs.DiaChi = txt_diachi.Text;
                    hs.Email = txt_email.Text;
                    QLHS_BUS bus = new QLHS_BUS();
                    bus.CapNhatHocSinh(hs);
                    MessageBox.Show("Cập nhật thành công học sinh " + txt_mahocsinh.Text + " !", "Thông báo");
                    btn_capnhathocsinh.Visible = true;
                    btn_ThemHS.Visible = true;
                    btn_Luu_HS.Visible = false;
                    txt_mahocsinh.Enabled = true;
                    txt_mahocsinh.Enabled = false;
                    txt_hovaten.Enabled = false;
                    txt_email.Enabled = false;
                    txt_diachi.Enabled = false;
                    cb_gioitinh.Enabled = false;
                    dt_ngaysinh.Enabled = false;
                    LoadData();
                    txt_hovaten.DataBindings.Clear();
                    txt_hovaten.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "HoTen");
                    txt_mahocsinh.DataBindings.Clear();
                    txt_mahocsinh.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "MaHocSinh");
                    txt_email.DataBindings.Clear();
                    txt_email.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "Email");
                    txt_diachi.DataBindings.Clear();
                    txt_diachi.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "DiaChi");
                    cb_gioitinh.DataBindings.Clear();
                    cb_gioitinh.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "GioiTinh");
                    dt_ngaysinh.DataBindings.Clear();
                    dt_ngaysinh.DataBindings.Add("Text", dtgv_danhsachhocsinh.DataSource, "NgaySinh");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công! Mời bạn xem lại dữ liệu nhập! ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void ClearText()
        {
            txt_email.Text = "";
            txt_diachi.Text = "";
            txt_hovaten.Text = "";
            txt_mahocsinh.Text = "";
            dt_ngaysinh.Value = DateTime.Now;
        }

        private void btn_ThemHS_Click(object sender, EventArgs e)
        {
            txt_mahocsinh.Enabled = true;
            txt_hovaten.Enabled = true;
            txt_email.Enabled = true;
            txt_diachi.Enabled = true;
            cb_gioitinh.Enabled = true;
            dt_ngaysinh.Enabled = true;

            btn_capnhathocsinh.Visible = false;
            btn_ThemHS.Visible = false;
            ClearText();
            btn_hoanthanh.Visible = true;
        }

      
    }
}
