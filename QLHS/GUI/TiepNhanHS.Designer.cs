
namespace GUI
{
    partial class frmTiepNhanHS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_mahocsinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_hoanthanh = new System.Windows.Forms.Button();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_hovaten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_danhsachhocsinh = new System.Windows.Forms.DataGridView();
            this.btn_xeplophocsinh = new System.Windows.Forms.Button();
            this.btn_xoahocsinh = new System.Windows.Forms.Button();
            this.btn_capnhathocsinh = new System.Windows.Forms.Button();
            this.btn_tailai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachhocsinh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_mahocsinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_hoanthanh);
            this.groupBox1.Controls.Add(this.dt_ngaysinh);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_gioitinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_hovaten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm học sinh";
            // 
            // txt_mahocsinh
            // 
            this.txt_mahocsinh.Location = new System.Drawing.Point(456, 46);
            this.txt_mahocsinh.Multiline = true;
            this.txt_mahocsinh.Name = "txt_mahocsinh";
            this.txt_mahocsinh.Size = new System.Drawing.Size(118, 29);
            this.txt_mahocsinh.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã học sinh : ";
            // 
            // btn_hoanthanh
            // 
            this.btn_hoanthanh.Location = new System.Drawing.Point(272, 170);
            this.btn_hoanthanh.Name = "btn_hoanthanh";
            this.btn_hoanthanh.Size = new System.Drawing.Size(161, 35);
            this.btn_hoanthanh.TabIndex = 10;
            this.btn_hoanthanh.Text = "Hoàn Thành";
            this.btn_hoanthanh.UseVisualStyleBackColor = true;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Location = new System.Drawing.Point(85, 78);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(214, 22);
            this.dt_ngaysinh.TabIndex = 1;
            this.dt_ngaysinh.Value = new System.DateTime(2020, 12, 28, 0, 0, 0, 0);
            this.dt_ngaysinh.ValueChanged += new System.EventHandler(this.dt_ngaysinh_ValueChanged);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(456, 110);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(246, 50);
            this.txt_diachi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ : ";
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gioitinh.Location = new System.Drawing.Point(456, 81);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(118, 23);
            this.cb_gioitinh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giới tính : ";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(85, 106);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(214, 29);
            this.txt_email.TabIndex = 4;
            // 
            // txt_hovaten
            // 
            this.txt_hovaten.Location = new System.Drawing.Point(85, 43);
            this.txt_hovaten.Multiline = true;
            this.txt_hovaten.Name = "txt_hovaten";
            this.txt_hovaten.Size = new System.Drawing.Size(214, 29);
            this.txt_hovaten.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_danhsachhocsinh);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 280);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học sinh đã tiếp nhận";
            // 
            // dtgv_danhsachhocsinh
            // 
            this.dtgv_danhsachhocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_danhsachhocsinh.Location = new System.Drawing.Point(6, 22);
            this.dtgv_danhsachhocsinh.Name = "dtgv_danhsachhocsinh";
            this.dtgv_danhsachhocsinh.Size = new System.Drawing.Size(568, 252);
            this.dtgv_danhsachhocsinh.TabIndex = 0;
            // 
            // btn_xeplophocsinh
            // 
            this.btn_xeplophocsinh.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.btn_xeplophocsinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xeplophocsinh.Location = new System.Drawing.Point(606, 459);
            this.btn_xeplophocsinh.Name = "btn_xeplophocsinh";
            this.btn_xeplophocsinh.Size = new System.Drawing.Size(114, 50);
            this.btn_xeplophocsinh.TabIndex = 11;
            this.btn_xeplophocsinh.Text = "Lập danh sách lóp";
            this.btn_xeplophocsinh.UseVisualStyleBackColor = true;
            this.btn_xeplophocsinh.Click += new System.EventHandler(this.btn_xeplophocsinh_Click);
            // 
            // btn_xoahocsinh
            // 
            this.btn_xoahocsinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoahocsinh.Location = new System.Drawing.Point(606, 353);
            this.btn_xoahocsinh.Name = "btn_xoahocsinh";
            this.btn_xoahocsinh.Size = new System.Drawing.Size(114, 35);
            this.btn_xoahocsinh.TabIndex = 11;
            this.btn_xoahocsinh.Text = "Xoá Học Sinh";
            this.btn_xoahocsinh.UseVisualStyleBackColor = true;
            // 
            // btn_capnhathocsinh
            // 
            this.btn_capnhathocsinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhathocsinh.Location = new System.Drawing.Point(606, 312);
            this.btn_capnhathocsinh.Name = "btn_capnhathocsinh";
            this.btn_capnhathocsinh.Size = new System.Drawing.Size(114, 35);
            this.btn_capnhathocsinh.TabIndex = 12;
            this.btn_capnhathocsinh.Text = "Cập nhật học sinh";
            this.btn_capnhathocsinh.UseVisualStyleBackColor = true;
            // 
            // btn_tailai
            // 
            this.btn_tailai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tailai.Location = new System.Drawing.Point(607, 271);
            this.btn_tailai.Name = "btn_tailai";
            this.btn_tailai.Size = new System.Drawing.Size(114, 35);
            this.btn_tailai.TabIndex = 13;
            this.btn_tailai.Text = "Tải lại danh sách";
            this.btn_tailai.UseVisualStyleBackColor = true;
            // 
            // frmTiepNhanHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(733, 528);
            this.Controls.Add(this.btn_tailai);
            this.Controls.Add(this.btn_capnhathocsinh);
            this.Controls.Add(this.btn_xoahocsinh);
            this.Controls.Add(this.btn_xeplophocsinh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTiepNhanHS";
            this.Text = "Tiếp nhận học sinh";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachhocsinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_hoanthanh;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_hovaten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv_danhsachhocsinh;
        private System.Windows.Forms.Button btn_xeplophocsinh;
        private System.Windows.Forms.Button btn_xoahocsinh;
        private System.Windows.Forms.Button btn_capnhathocsinh;
        private System.Windows.Forms.Button btn_tailai;
        private System.Windows.Forms.TextBox txt_mahocsinh;
        private System.Windows.Forms.Label label6;
    }
}

