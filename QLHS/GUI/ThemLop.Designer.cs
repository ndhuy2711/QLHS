
namespace GUI
{
    partial class ThemLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemLop));
            this.dtgv_themlop = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Khoi_LopHoc = new System.Windows.Forms.ComboBox();
            this.btn_xoalop = new System.Windows.Forms.Button();
            this.btn_Luu_Lai = new System.Windows.Forms.Button();
            this.btn_capnhatlop = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_siso = new System.Windows.Forms.TextBox();
            this.txt_tenlop = new System.Windows.Forms.TextBox();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xeplop = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_themlop)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_themlop
            // 
            this.dtgv_themlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_themlop.Location = new System.Drawing.Point(6, 28);
            this.dtgv_themlop.Name = "dtgv_themlop";
            this.dtgv_themlop.Size = new System.Drawing.Size(390, 151);
            this.dtgv_themlop.TabIndex = 0;
            this.dtgv_themlop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_themlop_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Khoi_LopHoc);
            this.groupBox1.Controls.Add(this.btn_xoalop);
            this.groupBox1.Controls.Add(this.btn_Luu_Lai);
            this.groupBox1.Controls.Add(this.btn_capnhatlop);
            this.groupBox1.Controls.Add(this.btn_XacNhan);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_siso);
            this.groupBox1.Controls.Add(this.txt_tenlop);
            this.groupBox1.Controls.Add(this.txt_malop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm lớp";
            // 
            // cb_Khoi_LopHoc
            // 
            this.cb_Khoi_LopHoc.FormattingEnabled = true;
            this.cb_Khoi_LopHoc.Location = new System.Drawing.Point(390, 35);
            this.cb_Khoi_LopHoc.Name = "cb_Khoi_LopHoc";
            this.cb_Khoi_LopHoc.Size = new System.Drawing.Size(103, 25);
            this.cb_Khoi_LopHoc.TabIndex = 10;
            // 
            // btn_xoalop
            // 
            this.btn_xoalop.Location = new System.Drawing.Point(329, 114);
            this.btn_xoalop.Name = "btn_xoalop";
            this.btn_xoalop.Size = new System.Drawing.Size(91, 35);
            this.btn_xoalop.TabIndex = 9;
            this.btn_xoalop.Text = "Xoá lớp";
            this.btn_xoalop.UseVisualStyleBackColor = true;
            this.btn_xoalop.Click += new System.EventHandler(this.btn_xoalop_Click);
            // 
            // btn_Luu_Lai
            // 
            this.btn_Luu_Lai.Location = new System.Drawing.Point(208, 114);
            this.btn_Luu_Lai.Name = "btn_Luu_Lai";
            this.btn_Luu_Lai.Size = new System.Drawing.Size(115, 35);
            this.btn_Luu_Lai.TabIndex = 8;
            this.btn_Luu_Lai.Text = "Lưu Cập Nhật";
            this.btn_Luu_Lai.UseVisualStyleBackColor = true;
            this.btn_Luu_Lai.Visible = false;
            this.btn_Luu_Lai.Click += new System.EventHandler(this.btn_Luu_Lai_Click);
            // 
            // btn_capnhatlop
            // 
            this.btn_capnhatlop.Location = new System.Drawing.Point(208, 114);
            this.btn_capnhatlop.Name = "btn_capnhatlop";
            this.btn_capnhatlop.Size = new System.Drawing.Size(115, 35);
            this.btn_capnhatlop.TabIndex = 8;
            this.btn_capnhatlop.Text = "Cập nhật lớp";
            this.btn_capnhatlop.UseVisualStyleBackColor = true;
            this.btn_capnhatlop.Click += new System.EventHandler(this.btn_capnhatlop_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(110, 114);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(92, 35);
            this.btn_XacNhan.TabIndex = 7;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Visible = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(110, 114);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(92, 35);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm lớp";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Khối Lớp";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sĩ số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Lớp";
            // 
            // txt_siso
            // 
            this.txt_siso.Location = new System.Drawing.Point(390, 64);
            this.txt_siso.Name = "txt_siso";
            this.txt_siso.Size = new System.Drawing.Size(57, 25);
            this.txt_siso.TabIndex = 3;
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.Location = new System.Drawing.Point(82, 64);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.Size = new System.Drawing.Size(100, 25);
            this.txt_tenlop.TabIndex = 2;
            // 
            // txt_malop
            // 
            this.txt_malop.Location = new System.Drawing.Point(82, 35);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(100, 25);
            this.txt_malop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp";
            // 
            // btn_xeplop
            // 
            this.btn_xeplop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xeplop.Location = new System.Drawing.Point(402, 84);
            this.btn_xeplop.Name = "btn_xeplop";
            this.btn_xeplop.Size = new System.Drawing.Size(113, 56);
            this.btn_xeplop.TabIndex = 10;
            this.btn_xeplop.Text = "Xếp lớp cho học sinh";
            this.btn_xeplop.UseVisualStyleBackColor = true;
            this.btn_xeplop.Click += new System.EventHandler(this.btn_xeplop_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(402, 146);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(113, 33);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_themlop);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_xeplop);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 186);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp học";
            // 
            // ThemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(547, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemLop";
            this.Text = "ThemLop";
            this.Load += new System.EventHandler(this.ThemLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_themlop)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_themlop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_siso;
        private System.Windows.Forms.TextBox txt_tenlop;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xoalop;
        private System.Windows.Forms.Button btn_capnhatlop;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xeplop;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Button btn_Luu_Lai;
        private System.Windows.Forms.ComboBox cb_Khoi_LopHoc;
    }
}