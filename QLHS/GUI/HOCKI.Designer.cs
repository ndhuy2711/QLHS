
namespace GUI
{
    partial class HOCKI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOCKI));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_nhapdiemmonhoc = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dtgv_danhsachhocki = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xoahocki = new System.Windows.Forms.Button();
            this.btn_capnhathocki = new System.Windows.Forms.Button();
            this.btn_themhocki = new System.Windows.Forms.Button();
            this.txt_tenhocki = new System.Windows.Forms.TextBox();
            this.txt_mahocki = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachhocki)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_nhapdiemmonhoc);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.dtgv_danhsachhocki);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 144);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học kì";
            // 
            // btn_nhapdiemmonhoc
            // 
            this.btn_nhapdiemmonhoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapdiemmonhoc.Location = new System.Drawing.Point(309, 58);
            this.btn_nhapdiemmonhoc.Name = "btn_nhapdiemmonhoc";
            this.btn_nhapdiemmonhoc.Size = new System.Drawing.Size(131, 33);
            this.btn_nhapdiemmonhoc.TabIndex = 8;
            this.btn_nhapdiemmonhoc.Text = "Nhập điểm môn học";
            this.btn_nhapdiemmonhoc.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(307, 102);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(131, 33);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dtgv_danhsachhocki
            // 
            this.dtgv_danhsachhocki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_danhsachhocki.Location = new System.Drawing.Point(7, 25);
            this.dtgv_danhsachhocki.Name = "dtgv_danhsachhocki";
            this.dtgv_danhsachhocki.Size = new System.Drawing.Size(294, 113);
            this.dtgv_danhsachhocki.TabIndex = 0;
            this.dtgv_danhsachhocki.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_danhsachhocki_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xoahocki);
            this.groupBox1.Controls.Add(this.btn_capnhathocki);
            this.groupBox1.Controls.Add(this.btn_themhocki);
            this.groupBox1.Controls.Add(this.txt_tenhocki);
            this.groupBox1.Controls.Add(this.txt_mahocki);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Học Kỳ";
            // 
            // btn_xoahocki
            // 
            this.btn_xoahocki.Location = new System.Drawing.Point(309, 81);
            this.btn_xoahocki.Name = "btn_xoahocki";
            this.btn_xoahocki.Size = new System.Drawing.Size(104, 33);
            this.btn_xoahocki.TabIndex = 6;
            this.btn_xoahocki.Text = "Xoá học kì";
            this.btn_xoahocki.UseVisualStyleBackColor = true;
            this.btn_xoahocki.Click += new System.EventHandler(this.btn_xoahocki_Click);
            // 
            // btn_capnhathocki
            // 
            this.btn_capnhathocki.Location = new System.Drawing.Point(160, 81);
            this.btn_capnhathocki.Name = "btn_capnhathocki";
            this.btn_capnhathocki.Size = new System.Drawing.Size(131, 33);
            this.btn_capnhathocki.TabIndex = 5;
            this.btn_capnhathocki.Text = "Cập nhật học kì";
            this.btn_capnhathocki.UseVisualStyleBackColor = true;
            this.btn_capnhathocki.Click += new System.EventHandler(this.btn_capnhathocki_Click);
            // 
            // btn_themhocki
            // 
            this.btn_themhocki.Location = new System.Drawing.Point(33, 81);
            this.btn_themhocki.Name = "btn_themhocki";
            this.btn_themhocki.Size = new System.Drawing.Size(104, 33);
            this.btn_themhocki.TabIndex = 4;
            this.btn_themhocki.Text = "Thêm học kì";
            this.btn_themhocki.UseVisualStyleBackColor = true;
            this.btn_themhocki.Click += new System.EventHandler(this.btn_themhocki_Click);
            // 
            // txt_tenhocki
            // 
            this.txt_tenhocki.Location = new System.Drawing.Point(292, 38);
            this.txt_tenhocki.Name = "txt_tenhocki";
            this.txt_tenhocki.Size = new System.Drawing.Size(139, 25);
            this.txt_tenhocki.TabIndex = 3;
            // 
            // txt_mahocki
            // 
            this.txt_mahocki.Location = new System.Drawing.Point(100, 38);
            this.txt_mahocki.Name = "txt_mahocki";
            this.txt_mahocki.Size = new System.Drawing.Size(77, 25);
            this.txt_mahocki.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên học kì";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học kì";
            // 
            // HOCKI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(477, 303);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HOCKI";
            this.Text = "Học Kỳ";
            this.Load += new System.EventHandler(this.HOCKI_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachhocki)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_nhapdiemmonhoc;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dtgv_danhsachhocki;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_xoahocki;
        private System.Windows.Forms.Button btn_capnhathocki;
        private System.Windows.Forms.Button btn_themhocki;
        private System.Windows.Forms.TextBox txt_tenhocki;
        private System.Windows.Forms.TextBox txt_mahocki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}