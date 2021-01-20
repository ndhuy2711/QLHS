
namespace GUI
{
    partial class NhapBangDiemMonHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapBangDiemMonHoc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_mamonhoc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.txt_diemck = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_diem1tiet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tenmh = new System.Windows.Forms.ComboBox();
            this.txt_tenhs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mahocsinh = new System.Windows.Forms.TextBox();
            this.txt_diem15phut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_danhsachbangdiem = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachbangdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_mamonhoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.txt_diemck);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_diem1tiet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_tenmh);
            this.groupBox1.Controls.Add(this.txt_tenhs);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_mahocsinh);
            this.groupBox1.Controls.Add(this.txt_diem15phut);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập bảng điểm môn học";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lb_mamonhoc
            // 
            this.lb_mamonhoc.AutoSize = true;
            this.lb_mamonhoc.Location = new System.Drawing.Point(121, 141);
            this.lb_mamonhoc.Name = "lb_mamonhoc";
            this.lb_mamonhoc.Size = new System.Drawing.Size(50, 17);
            this.lb_mamonhoc.TabIndex = 25;
            this.lb_mamonhoc.Text = "NULL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Mã môn học";
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(379, 141);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(111, 31);
            this.btn_luu.TabIndex = 23;
            this.btn_luu.Text = "Lưu tất cả";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_diemck
            // 
            this.txt_diemck.Location = new System.Drawing.Point(390, 99);
            this.txt_diemck.Name = "txt_diemck";
            this.txt_diemck.Size = new System.Drawing.Size(100, 25);
            this.txt_diemck.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm 1 tiết";
            // 
            // txt_diem1tiet
            // 
            this.txt_diem1tiet.Location = new System.Drawing.Point(390, 68);
            this.txt_diem1tiet.Name = "txt_diem1tiet";
            this.txt_diem1tiet.Size = new System.Drawing.Size(100, 25);
            this.txt_diem1tiet.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm 15 phút";
            // 
            // cb_tenmh
            // 
            this.cb_tenmh.FormattingEnabled = true;
            this.cb_tenmh.Location = new System.Drawing.Point(119, 99);
            this.cb_tenmh.Name = "cb_tenmh";
            this.cb_tenmh.Size = new System.Drawing.Size(103, 25);
            this.cb_tenmh.TabIndex = 22;
            this.cb_tenmh.SelectedIndexChanged += new System.EventHandler(this.cb_tenmh_SelectedIndexChanged);
            // 
            // txt_tenhs
            // 
            this.txt_tenhs.Enabled = false;
            this.txt_tenhs.Location = new System.Drawing.Point(119, 68);
            this.txt_tenhs.Name = "txt_tenhs";
            this.txt_tenhs.Size = new System.Drawing.Size(103, 25);
            this.txt_tenhs.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tên học sinh";
            // 
            // txt_mahocsinh
            // 
            this.txt_mahocsinh.Location = new System.Drawing.Point(119, 37);
            this.txt_mahocsinh.Name = "txt_mahocsinh";
            this.txt_mahocsinh.Size = new System.Drawing.Size(103, 25);
            this.txt_mahocsinh.TabIndex = 18;
            this.txt_mahocsinh.TextChanged += new System.EventHandler(this.txt_mahocsinh_TextChanged);
            // 
            // txt_diem15phut
            // 
            this.txt_diem15phut.Location = new System.Drawing.Point(390, 37);
            this.txt_diem15phut.Name = "txt_diem15phut";
            this.txt_diem15phut.Size = new System.Drawing.Size(100, 25);
            this.txt_diem15phut.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm cuối kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học sinh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_danhsachbangdiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bảng điểm";
            // 
            // dtgv_danhsachbangdiem
            // 
            this.dtgv_danhsachbangdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_danhsachbangdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_danhsachbangdiem.Location = new System.Drawing.Point(3, 21);
            this.dtgv_danhsachbangdiem.Name = "dtgv_danhsachbangdiem";
            this.dtgv_danhsachbangdiem.Size = new System.Drawing.Size(500, 148);
            this.dtgv_danhsachbangdiem.TabIndex = 0;
            this.dtgv_danhsachbangdiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_danhsachbangdiem_CellContentClick);
            // 
            // NhapBangDiemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 388);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhapBangDiemMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Bảng Điểm Cho Môn Học";
            this.Load += new System.EventHandler(this.NhapBangDiemMonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachbangdiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_diem15phut;
        private System.Windows.Forms.TextBox txt_diem1tiet;
        private System.Windows.Forms.TextBox txt_diemck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_mahocsinh;
        private System.Windows.Forms.TextBox txt_tenhs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_tenmh;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.DataGridView dtgv_danhsachbangdiem;
        private System.Windows.Forms.Label lb_mamonhoc;
        private System.Windows.Forms.Label label7;
    }
}