
namespace GUI
{
    partial class MonHoc
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
            this.btn_nhapdiemmonhoc = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhatmon = new System.Windows.Forms.Button();
            this.btn_themmon = new System.Windows.Forms.Button();
            this.txt_tenmonhoc = new System.Windows.Forms.TextBox();
            this.txt_mamonhoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_danhsachmonhoc = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachmonhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_nhapdiemmonhoc);
            this.groupBox1.Controls.Add(this.btn_XacNhan);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_capnhatmon);
            this.groupBox1.Controls.Add(this.btn_themmon);
            this.groupBox1.Controls.Add(this.txt_tenmonhoc);
            this.groupBox1.Controls.Add(this.txt_mamonhoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Môn học";
            // 
            // btn_nhapdiemmonhoc
            // 
            this.btn_nhapdiemmonhoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapdiemmonhoc.Location = new System.Drawing.Point(593, 82);
            this.btn_nhapdiemmonhoc.Name = "btn_nhapdiemmonhoc";
            this.btn_nhapdiemmonhoc.Size = new System.Drawing.Size(131, 33);
            this.btn_nhapdiemmonhoc.TabIndex = 8;
            this.btn_nhapdiemmonhoc.Text = "Nhập điểm môn học";
            this.btn_nhapdiemmonhoc.UseVisualStyleBackColor = true;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(55, 82);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(98, 33);
            this.btn_XacNhan.TabIndex = 7;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Visible = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(336, 82);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 33);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xoá môn";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhatmon
            // 
            this.btn_capnhatmon.Location = new System.Drawing.Point(170, 82);
            this.btn_capnhatmon.Name = "btn_capnhatmon";
            this.btn_capnhatmon.Size = new System.Drawing.Size(131, 33);
            this.btn_capnhatmon.TabIndex = 5;
            this.btn_capnhatmon.Text = "Cập nhật môn";
            this.btn_capnhatmon.UseVisualStyleBackColor = true;
            this.btn_capnhatmon.Click += new System.EventHandler(this.btn_capnhatmon_Click);
            // 
            // btn_themmon
            // 
            this.btn_themmon.Location = new System.Drawing.Point(55, 82);
            this.btn_themmon.Name = "btn_themmon";
            this.btn_themmon.Size = new System.Drawing.Size(98, 33);
            this.btn_themmon.TabIndex = 4;
            this.btn_themmon.Text = "Thêm môn ";
            this.btn_themmon.UseVisualStyleBackColor = true;
            this.btn_themmon.Click += new System.EventHandler(this.btn_themmon_Click);
            // 
            // txt_tenmonhoc
            // 
            this.txt_tenmonhoc.Location = new System.Drawing.Point(512, 33);
            this.txt_tenmonhoc.Name = "txt_tenmonhoc";
            this.txt_tenmonhoc.Size = new System.Drawing.Size(139, 25);
            this.txt_tenmonhoc.TabIndex = 3;
            // 
            // txt_mamonhoc
            // 
            this.txt_mamonhoc.Location = new System.Drawing.Point(184, 33);
            this.txt_mamonhoc.Name = "txt_mamonhoc";
            this.txt_mamonhoc.Size = new System.Drawing.Size(140, 25);
            this.txt_mamonhoc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_danhsachmonhoc);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách môn học";
            // 
            // dtgv_danhsachmonhoc
            // 
            this.dtgv_danhsachmonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_danhsachmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_danhsachmonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_danhsachmonhoc.Location = new System.Drawing.Point(3, 21);
            this.dtgv_danhsachmonhoc.Name = "dtgv_danhsachmonhoc";
            this.dtgv_danhsachmonhoc.Size = new System.Drawing.Size(724, 201);
            this.dtgv_danhsachmonhoc.TabIndex = 0;
            this.dtgv_danhsachmonhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_danhsachmonhoc_CellContentClick);
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(754, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonHoc";
            this.Text = "MonHoc";
            this.Load += new System.EventHandler(this.MonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachmonhoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tenmonhoc;
        private System.Windows.Forms.TextBox txt_mamonhoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_themmon;
        private System.Windows.Forms.DataGridView dtgv_danhsachmonhoc;
        private System.Windows.Forms.Button btn_capnhatmon;
        private System.Windows.Forms.Button btn_nhapdiemmonhoc;
        private System.Windows.Forms.Button btn_XacNhan;
    }
}