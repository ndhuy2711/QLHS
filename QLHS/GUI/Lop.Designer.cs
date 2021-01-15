
namespace GUI
{
    partial class Lop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lop));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_hoanthanh = new System.Windows.Forms.Button();
            this.dtgv_danhsachlop = new System.Windows.Forms.DataGridView();
            this.btn_themlop = new System.Windows.Forms.Button();
            this.btn_capnhatlop = new System.Windows.Forms.Button();
            this.btn_xoalop = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_khoi = new System.Windows.Forms.ComboBox();
            this.txt_mahocsinh = new System.Windows.Forms.TextBox();
            this.txt_namsinh = new System.Windows.Forms.TextBox();
            this.txt_tenhocsinh = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_tailai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachlop)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_hoanthanh);
            this.groupBox1.Controls.Add(this.dtgv_danhsachlop);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(4, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "* Sau khi chọn lớp cho học sinh. Vui lòng bấm \"Hoàn Thành\".";
            // 
            // btn_hoanthanh
            // 
            this.btn_hoanthanh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoanthanh.Location = new System.Drawing.Point(465, 281);
            this.btn_hoanthanh.Name = "btn_hoanthanh";
            this.btn_hoanthanh.Size = new System.Drawing.Size(146, 38);
            this.btn_hoanthanh.TabIndex = 5;
            this.btn_hoanthanh.Text = "Hoàn Thành";
            this.btn_hoanthanh.UseVisualStyleBackColor = true;
            // 
            // dtgv_danhsachlop
            // 
            this.dtgv_danhsachlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_danhsachlop.Location = new System.Drawing.Point(4, 25);
            this.dtgv_danhsachlop.Name = "dtgv_danhsachlop";
            this.dtgv_danhsachlop.Size = new System.Drawing.Size(501, 208);
            this.dtgv_danhsachlop.TabIndex = 0;
            this.dtgv_danhsachlop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_danhsachlop_CellContentClick);
            // 
            // btn_themlop
            // 
            this.btn_themlop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themlop.Location = new System.Drawing.Point(532, 249);
            this.btn_themlop.Name = "btn_themlop";
            this.btn_themlop.Size = new System.Drawing.Size(98, 38);
            this.btn_themlop.TabIndex = 1;
            this.btn_themlop.Text = "Thêm lớp";
            this.btn_themlop.UseVisualStyleBackColor = true;
            // 
            // btn_capnhatlop
            // 
            this.btn_capnhatlop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhatlop.Location = new System.Drawing.Point(532, 293);
            this.btn_capnhatlop.Name = "btn_capnhatlop";
            this.btn_capnhatlop.Size = new System.Drawing.Size(98, 38);
            this.btn_capnhatlop.TabIndex = 2;
            this.btn_capnhatlop.Text = "Cập nhật lớp";
            this.btn_capnhatlop.UseVisualStyleBackColor = true;
            // 
            // btn_xoalop
            // 
            this.btn_xoalop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoalop.Location = new System.Drawing.Point(532, 337);
            this.btn_xoalop.Name = "btn_xoalop";
            this.btn_xoalop.Size = new System.Drawing.Size(98, 38);
            this.btn_xoalop.TabIndex = 3;
            this.btn_xoalop.Text = "Xoá lớp";
            this.btn_xoalop.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(532, 381);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(98, 38);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Khối";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã học sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Năm sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên học sinh";
            // 
            // cb_khoi
            // 
            this.cb_khoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_khoi.FormattingEnabled = true;
            this.cb_khoi.Items.AddRange(new object[] {
            "Khối 10",
            "Khối 11",
            "Khối 12"});
            this.cb_khoi.Location = new System.Drawing.Point(466, 27);
            this.cb_khoi.Name = "cb_khoi";
            this.cb_khoi.Size = new System.Drawing.Size(100, 27);
            this.cb_khoi.TabIndex = 9;
            this.cb_khoi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_mahocsinh
            // 
            this.txt_mahocsinh.Location = new System.Drawing.Point(89, 28);
            this.txt_mahocsinh.Name = "txt_mahocsinh";
            this.txt_mahocsinh.Size = new System.Drawing.Size(125, 26);
            this.txt_mahocsinh.TabIndex = 10;
            this.txt_mahocsinh.TextChanged += new System.EventHandler(this.txt_mahocsinh_TextChanged);
            // 
            // txt_namsinh
            // 
            this.txt_namsinh.Enabled = false;
            this.txt_namsinh.Location = new System.Drawing.Point(331, 28);
            this.txt_namsinh.Name = "txt_namsinh";
            this.txt_namsinh.Size = new System.Drawing.Size(74, 26);
            this.txt_namsinh.TabIndex = 11;
            this.txt_namsinh.TextChanged += new System.EventHandler(this.txt_namsinh_TextChanged);
            // 
            // txt_tenhocsinh
            // 
            this.txt_tenhocsinh.Enabled = false;
            this.txt_tenhocsinh.Location = new System.Drawing.Point(89, 65);
            this.txt_tenhocsinh.Name = "txt_tenhocsinh";
            this.txt_tenhocsinh.Size = new System.Drawing.Size(156, 26);
            this.txt_tenhocsinh.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.cb_lop);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.txt_namsinh);
            this.groupBox2.Controls.Add(this.txt_mahocsinh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cb_khoi);
            this.groupBox2.Controls.Add(this.txt_tenhocsinh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 161);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin học sinh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // cb_lop
            // 
            this.cb_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(466, 65);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(100, 27);
            this.cb_lop.TabIndex = 16;
            this.cb_lop.DropDown += new System.EventHandler(this.cb_lop_DropDown);
            this.cb_lop.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.cb_lop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_lop_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lớp";
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(184, 117);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(234, 38);
            this.btn_them.TabIndex = 14;
            this.btn_them.Text = "Thêm học sinh vào lớp";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_tailai
            // 
            this.btn_tailai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tailai.Location = new System.Drawing.Point(532, 205);
            this.btn_tailai.Name = "btn_tailai";
            this.btn_tailai.Size = new System.Drawing.Size(98, 38);
            this.btn_tailai.TabIndex = 14;
            this.btn_tailai.Text = "Tải lại";
            this.btn_tailai.UseVisualStyleBackColor = true;
            this.btn_tailai.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(642, 427);
            this.Controls.Add(this.btn_tailai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoalop);
            this.Controls.Add(this.btn_capnhatlop);
            this.Controls.Add(this.btn_themlop);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lop";
            this.Text = "Lớp học";
            this.Load += new System.EventHandler(this.Lop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachlop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_danhsachlop;
        private System.Windows.Forms.Button btn_themlop;
        private System.Windows.Forms.Button btn_capnhatlop;
        private System.Windows.Forms.Button btn_xoalop;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hoanthanh;
        private System.Windows.Forms.ComboBox cb_khoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mahocsinh;
        private System.Windows.Forms.TextBox txt_namsinh;
        private System.Windows.Forms.TextBox txt_tenhocsinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_tailai;
    }
}