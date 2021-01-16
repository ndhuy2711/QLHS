
namespace GUI
{
    partial class KhoiLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoiLop));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_khoilop = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_makhoilop = new System.Windows.Forms.TextBox();
            this.txt_tenkhoilop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_themkhoilop = new System.Windows.Forms.Button();
            this.btn_capnhatkhoilop = new System.Windows.Forms.Button();
            this.btn_xoakhoilop = new System.Windows.Forms.Button();
            this.btn_themlop = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_khoilop)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xoakhoilop);
            this.groupBox1.Controls.Add(this.btn_capnhatkhoilop);
            this.groupBox1.Controls.Add(this.btn_themkhoilop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tenkhoilop);
            this.groupBox1.Controls.Add(this.txt_makhoilop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khối Lớp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtgv_khoilop
            // 
            this.dtgv_khoilop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_khoilop.Location = new System.Drawing.Point(6, 24);
            this.dtgv_khoilop.Name = "dtgv_khoilop";
            this.dtgv_khoilop.Size = new System.Drawing.Size(268, 150);
            this.dtgv_khoilop.TabIndex = 1;
            this.dtgv_khoilop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_khoilop);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khối lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khối lớp";
            // 
            // txt_makhoilop
            // 
            this.txt_makhoilop.Location = new System.Drawing.Point(108, 27);
            this.txt_makhoilop.Name = "txt_makhoilop";
            this.txt_makhoilop.Size = new System.Drawing.Size(73, 25);
            this.txt_makhoilop.TabIndex = 1;
            // 
            // txt_tenkhoilop
            // 
            this.txt_tenkhoilop.Location = new System.Drawing.Point(304, 27);
            this.txt_tenkhoilop.Name = "txt_tenkhoilop";
            this.txt_tenkhoilop.Size = new System.Drawing.Size(70, 25);
            this.txt_tenkhoilop.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khối lớp";
            // 
            // btn_themkhoilop
            // 
            this.btn_themkhoilop.Location = new System.Drawing.Point(23, 81);
            this.btn_themkhoilop.Name = "btn_themkhoilop";
            this.btn_themkhoilop.Size = new System.Drawing.Size(94, 35);
            this.btn_themkhoilop.TabIndex = 4;
            this.btn_themkhoilop.Text = "Thêm khối";
            this.btn_themkhoilop.UseVisualStyleBackColor = true;
            this.btn_themkhoilop.Click += new System.EventHandler(this.btn_themkhoilop_Click);
            // 
            // btn_capnhatkhoilop
            // 
            this.btn_capnhatkhoilop.Location = new System.Drawing.Point(143, 81);
            this.btn_capnhatkhoilop.Name = "btn_capnhatkhoilop";
            this.btn_capnhatkhoilop.Size = new System.Drawing.Size(94, 35);
            this.btn_capnhatkhoilop.TabIndex = 5;
            this.btn_capnhatkhoilop.Text = "Cập nhật";
            this.btn_capnhatkhoilop.UseVisualStyleBackColor = true;
            this.btn_capnhatkhoilop.Click += new System.EventHandler(this.btn_capnhatkhoilop_Click);
            // 
            // btn_xoakhoilop
            // 
            this.btn_xoakhoilop.Location = new System.Drawing.Point(260, 81);
            this.btn_xoakhoilop.Name = "btn_xoakhoilop";
            this.btn_xoakhoilop.Size = new System.Drawing.Size(94, 35);
            this.btn_xoakhoilop.TabIndex = 6;
            this.btn_xoakhoilop.Text = "Xoá khối";
            this.btn_xoakhoilop.UseVisualStyleBackColor = true;
            this.btn_xoakhoilop.Click += new System.EventHandler(this.btn_xoakhoilop_Click);
            // 
            // btn_themlop
            // 
            this.btn_themlop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themlop.Location = new System.Drawing.Point(298, 254);
            this.btn_themlop.Name = "btn_themlop";
            this.btn_themlop.Size = new System.Drawing.Size(119, 35);
            this.btn_themlop.TabIndex = 7;
            this.btn_themlop.Text = "Thêm lớp học";
            this.btn_themlop.UseVisualStyleBackColor = true;
            this.btn_themlop.Click += new System.EventHandler(this.btn_themlop_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(298, 295);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(119, 35);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // KhoiLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(431, 351);
            this.Controls.Add(this.btn_themlop);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KhoiLop";
            this.Text = "KhoiLop";
            this.Load += new System.EventHandler(this.KhoiLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_khoilop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_khoilop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenkhoilop;
        private System.Windows.Forms.TextBox txt_makhoilop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_xoakhoilop;
        private System.Windows.Forms.Button btn_capnhatkhoilop;
        private System.Windows.Forms.Button btn_themkhoilop;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_themlop;
    }
}