namespace Project_2nd_FormQL
{
    partial class frm_SanPham
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dt_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.txt_loaisp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idsp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ds_sp = new System.Windows.Forms.DataGridView();
            this.qLLKDataSet = new Project_2nd_FormQL.QLLKDataSet();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAN_PHAMTableAdapter = new Project_2nd_FormQL.QLLKDataSetTableAdapters.SAN_PHAMTableAdapter();
            this.iDSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYNHAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAISANPHAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sANPHAMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.dt_ngaynhap);
            this.groupBox1.Controls.Add(this.txt_loaisp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_soluong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_dongia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_tensp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_idsp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(790, 155);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(148, 77);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(623, 155);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(148, 77);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(453, 155);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(148, 77);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(287, 155);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(148, 77);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(123, 155);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(148, 77);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dt_ngaynhap
            // 
            this.dt_ngaynhap.Location = new System.Drawing.Point(717, 41);
            this.dt_ngaynhap.Name = "dt_ngaynhap";
            this.dt_ngaynhap.Size = new System.Drawing.Size(177, 34);
            this.dt_ngaynhap.TabIndex = 12;
            // 
            // txt_loaisp
            // 
            this.txt_loaisp.Location = new System.Drawing.Point(717, 94);
            this.txt_loaisp.Name = "txt_loaisp";
            this.txt_loaisp.Size = new System.Drawing.Size(177, 34);
            this.txt_loaisp.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(626, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Loại SP";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(386, 94);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(177, 34);
            this.txt_soluong.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(79, 94);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(177, 34);
            this.txt_dongia.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày nhập";
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(386, 35);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(177, 34);
            this.txt_tensp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên_SP";
            // 
            // txt_idsp
            // 
            this.txt_idsp.Location = new System.Drawing.Point(79, 35);
            this.txt_idsp.Name = "txt_idsp";
            this.txt_idsp.Size = new System.Drawing.Size(177, 34);
            this.txt_idsp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_SP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ds_sp);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1045, 280);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách SP";
            // 
            // ds_sp
            // 
            this.ds_sp.AutoGenerateColumns = false;
            this.ds_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ds_sp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSPDataGridViewTextBoxColumn,
            this.tENSPDataGridViewTextBoxColumn,
            this.nGAYNHAPDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.cTSPDataGridViewTextBoxColumn,
            this.lOAISANPHAMDataGridViewTextBoxColumn});
            this.ds_sp.DataSource = this.sANPHAMBindingSource1;
            this.ds_sp.Location = new System.Drawing.Point(3, 30);
            this.ds_sp.Name = "ds_sp";
            this.ds_sp.RowTemplate.Height = 24;
            this.ds_sp.Size = new System.Drawing.Size(1039, 247);
            this.ds_sp.TabIndex = 0;
            // 
            // qLLKDataSet
            // 
            this.qLLKDataSet.DataSetName = "QLLKDataSet";
            this.qLLKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SAN_PHAM";
            this.sANPHAMBindingSource.DataSource = this.qLLKDataSet;
            // 
            // sAN_PHAMTableAdapter
            // 
            this.sAN_PHAMTableAdapter.ClearBeforeFill = true;
            // 
            // iDSPDataGridViewTextBoxColumn
            // 
            this.iDSPDataGridViewTextBoxColumn.DataPropertyName = "ID_SP";
            this.iDSPDataGridViewTextBoxColumn.HeaderText = "ID_SP";
            this.iDSPDataGridViewTextBoxColumn.Name = "iDSPDataGridViewTextBoxColumn";
            // 
            // tENSPDataGridViewTextBoxColumn
            // 
            this.tENSPDataGridViewTextBoxColumn.DataPropertyName = "TEN_SP";
            this.tENSPDataGridViewTextBoxColumn.HeaderText = "TEN_SP";
            this.tENSPDataGridViewTextBoxColumn.Name = "tENSPDataGridViewTextBoxColumn";
            // 
            // nGAYNHAPDataGridViewTextBoxColumn
            // 
            this.nGAYNHAPDataGridViewTextBoxColumn.DataPropertyName = "NGAY_NHAP";
            this.nGAYNHAPDataGridViewTextBoxColumn.HeaderText = "NGAY_NHAP";
            this.nGAYNHAPDataGridViewTextBoxColumn.Name = "nGAYNHAPDataGridViewTextBoxColumn";
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DON_GIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "DON_GIA";
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SO_LUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "SO_LUONG";
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            // 
            // cTSPDataGridViewTextBoxColumn
            // 
            this.cTSPDataGridViewTextBoxColumn.DataPropertyName = "CT_SP";
            this.cTSPDataGridViewTextBoxColumn.HeaderText = "CT_SP";
            this.cTSPDataGridViewTextBoxColumn.Name = "cTSPDataGridViewTextBoxColumn";
            // 
            // lOAISANPHAMDataGridViewTextBoxColumn
            // 
            this.lOAISANPHAMDataGridViewTextBoxColumn.DataPropertyName = "LOAI_SAN_PHAM";
            this.lOAISANPHAMDataGridViewTextBoxColumn.HeaderText = "LOAI_SAN_PHAM";
            this.lOAISANPHAMDataGridViewTextBoxColumn.Name = "lOAISANPHAMDataGridViewTextBoxColumn";
            // 
            // sANPHAMBindingSource1
            // 
            this.sANPHAMBindingSource1.DataMember = "SAN_PHAM";
            this.sANPHAMBindingSource1.DataSource = this.qLLKDataSet;
            // 
            // frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 577);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_SanPham";
            this.Text = "frm_SanPham";
            this.Load += new System.EventHandler(this.frm_SanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt_ngaynhap;
        private System.Windows.Forms.TextBox txt_loaisp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView ds_sp;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private QLLKDataSet qLLKDataSet;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private QLLKDataSetTableAdapters.SAN_PHAMTableAdapter sAN_PHAMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYNHAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAISANPHAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource1;
    }
}