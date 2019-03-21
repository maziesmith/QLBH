namespace Project_2nd_FormQL
{
    partial class frm_QLHD
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
            this.ds_hd = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hd_ct = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.qLLKDataSet = new Project_2nd_FormQL.QLLKDataSet();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOA_DONTableAdapter = new Project_2nd_FormQL.QLLKDataSetTableAdapters.HOA_DONTableAdapter();
            this.iDHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANGTHAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tONGTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtidhd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_hd)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hd_ct)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLLKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ds_hd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // ds_hd
            // 
            this.ds_hd.AutoGenerateColumns = false;
            this.ds_hd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ds_hd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDHDDataGridViewTextBoxColumn,
            this.iDNVDataGridViewTextBoxColumn,
            this.iDKHDataGridViewTextBoxColumn,
            this.nGAYBANDataGridViewTextBoxColumn,
            this.tRANGTHAIDataGridViewTextBoxColumn,
            this.tONGTIENDataGridViewTextBoxColumn});
            this.ds_hd.DataSource = this.hOADONBindingSource;
            this.ds_hd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ds_hd.Location = new System.Drawing.Point(3, 18);
            this.ds_hd.Name = "ds_hd";
            this.ds_hd.RowTemplate.Height = 24;
            this.ds_hd.Size = new System.Drawing.Size(670, 365);
            this.ds_hd.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hd_ct);
            this.groupBox2.Location = new System.Drawing.Point(703, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 518);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // hd_ct
            // 
            this.hd_ct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hd_ct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hd_ct.Location = new System.Drawing.Point(3, 18);
            this.hd_ct.Name = "hd_ct";
            this.hd_ct.RowTemplate.Height = 24;
            this.hd_ct.Size = new System.Drawing.Size(497, 497);
            this.hd_ct.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXem);
            this.groupBox3.Controls.Add(this.txtidhd);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnXoaHD);
            this.groupBox3.Controls.Add(this.btnCapNhap);
            this.groupBox3.Controls.Add(this.txttrangthai);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 404);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(675, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Qản lý HD";
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Location = new System.Drawing.Point(303, 59);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(199, 50);
            this.btnXoaHD.TabIndex = 4;
            this.btnXoaHD.Text = "Xóa Hóa Đơn";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(47, 59);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(197, 50);
            this.btnCapNhap.TabIndex = 3;
            this.btnCapNhap.Text = "Cập nhập trạng thái";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // txttrangthai
            // 
            this.txttrangthai.Location = new System.Drawing.Point(110, 22);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(80, 22);
            this.txttrangthai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trạng thái";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // qLLKDataSet
            // 
            this.qLLKDataSet.DataSetName = "QLLKDataSet";
            this.qLLKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOA_DON";
            this.hOADONBindingSource.DataSource = this.qLLKDataSet;
            // 
            // hOA_DONTableAdapter
            // 
            this.hOA_DONTableAdapter.ClearBeforeFill = true;
            // 
            // iDHDDataGridViewTextBoxColumn
            // 
            this.iDHDDataGridViewTextBoxColumn.DataPropertyName = "ID_HD";
            this.iDHDDataGridViewTextBoxColumn.HeaderText = "ID_HD";
            this.iDHDDataGridViewTextBoxColumn.Name = "iDHDDataGridViewTextBoxColumn";
            // 
            // iDNVDataGridViewTextBoxColumn
            // 
            this.iDNVDataGridViewTextBoxColumn.DataPropertyName = "ID_NV";
            this.iDNVDataGridViewTextBoxColumn.HeaderText = "ID_NV";
            this.iDNVDataGridViewTextBoxColumn.Name = "iDNVDataGridViewTextBoxColumn";
            // 
            // iDKHDataGridViewTextBoxColumn
            // 
            this.iDKHDataGridViewTextBoxColumn.DataPropertyName = "ID_KH";
            this.iDKHDataGridViewTextBoxColumn.HeaderText = "ID_KH";
            this.iDKHDataGridViewTextBoxColumn.Name = "iDKHDataGridViewTextBoxColumn";
            // 
            // nGAYBANDataGridViewTextBoxColumn
            // 
            this.nGAYBANDataGridViewTextBoxColumn.DataPropertyName = "NGAY_BAN";
            this.nGAYBANDataGridViewTextBoxColumn.HeaderText = "NGAY_BAN";
            this.nGAYBANDataGridViewTextBoxColumn.Name = "nGAYBANDataGridViewTextBoxColumn";
            // 
            // tRANGTHAIDataGridViewTextBoxColumn
            // 
            this.tRANGTHAIDataGridViewTextBoxColumn.DataPropertyName = "TRANG_THAI";
            this.tRANGTHAIDataGridViewTextBoxColumn.HeaderText = "TRANG_THAI";
            this.tRANGTHAIDataGridViewTextBoxColumn.Name = "tRANGTHAIDataGridViewTextBoxColumn";
            // 
            // tONGTIENDataGridViewTextBoxColumn
            // 
            this.tONGTIENDataGridViewTextBoxColumn.DataPropertyName = "TONG_TIEN";
            this.tONGTIENDataGridViewTextBoxColumn.HeaderText = "TONG_TIEN";
            this.tONGTIENDataGridViewTextBoxColumn.Name = "tONGTIENDataGridViewTextBoxColumn";
            // 
            // txtidhd
            // 
            this.txtidhd.Location = new System.Drawing.Point(340, 25);
            this.txtidhd.Name = "txtidhd";
            this.txtidhd.Size = new System.Drawing.Size(80, 22);
            this.txtidhd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID_HD";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(526, 59);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(123, 50);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "Xem DS_SP";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // frm_QLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_QLHD";
            this.Text = "frm_QLHD";
            this.Load += new System.EventHandler(this.frm_QLHD_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_hd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hd_ct)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLLKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ds_hd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView hd_ct;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private QLLKDataSet qLLKDataSet;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QLLKDataSetTableAdapters.HOA_DONTableAdapter hOA_DONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANGTHAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tONGTIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtidhd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXem;
    }
}