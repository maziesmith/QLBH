namespace Project_2nd_FormQL
{
    partial class Phieu_xuat
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ds_pg = new System.Windows.Forms.DataGridView();
            this.qLLKDataSet = new Project_2nd_FormQL.QLLKDataSet();
            this.pHIEUGIAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEU_GIAOTableAdapter = new Project_2nd_FormQL.QLLKDataSetTableAdapters.PHIEU_GIAOTableAdapter();
            this.iDPGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYGIAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOINHANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANGTHAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.txtidpg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_pg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUGIAOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ds_pg);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu giao";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnCapNhap);
            this.groupBox2.Controls.Add(this.txtidpg);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTrangthai);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(910, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản Lý PG";
            // 
            // ds_pg
            // 
            this.ds_pg.AutoGenerateColumns = false;
            this.ds_pg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ds_pg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPGDataGridViewTextBoxColumn,
            this.iDHDDataGridViewTextBoxColumn,
            this.iDKHDataGridViewTextBoxColumn,
            this.nGAYGIAODataGridViewTextBoxColumn,
            this.nOINHANDataGridViewTextBoxColumn,
            this.tRANGTHAIDataGridViewTextBoxColumn});
            this.ds_pg.DataSource = this.pHIEUGIAOBindingSource;
            this.ds_pg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ds_pg.Location = new System.Drawing.Point(3, 18);
            this.ds_pg.Name = "ds_pg";
            this.ds_pg.RowTemplate.Height = 24;
            this.ds_pg.Size = new System.Drawing.Size(904, 285);
            this.ds_pg.TabIndex = 0;
            // 
            // qLLKDataSet
            // 
            this.qLLKDataSet.DataSetName = "QLLKDataSet";
            this.qLLKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUGIAOBindingSource
            // 
            this.pHIEUGIAOBindingSource.DataMember = "PHIEU_GIAO";
            this.pHIEUGIAOBindingSource.DataSource = this.qLLKDataSet;
            // 
            // pHIEU_GIAOTableAdapter
            // 
            this.pHIEU_GIAOTableAdapter.ClearBeforeFill = true;
            // 
            // iDPGDataGridViewTextBoxColumn
            // 
            this.iDPGDataGridViewTextBoxColumn.DataPropertyName = "ID_PG";
            this.iDPGDataGridViewTextBoxColumn.HeaderText = "ID_PG";
            this.iDPGDataGridViewTextBoxColumn.Name = "iDPGDataGridViewTextBoxColumn";
            // 
            // iDHDDataGridViewTextBoxColumn
            // 
            this.iDHDDataGridViewTextBoxColumn.DataPropertyName = "ID_HD";
            this.iDHDDataGridViewTextBoxColumn.HeaderText = "ID_HD";
            this.iDHDDataGridViewTextBoxColumn.Name = "iDHDDataGridViewTextBoxColumn";
            // 
            // iDKHDataGridViewTextBoxColumn
            // 
            this.iDKHDataGridViewTextBoxColumn.DataPropertyName = "ID_KH";
            this.iDKHDataGridViewTextBoxColumn.HeaderText = "ID_KH";
            this.iDKHDataGridViewTextBoxColumn.Name = "iDKHDataGridViewTextBoxColumn";
            // 
            // nGAYGIAODataGridViewTextBoxColumn
            // 
            this.nGAYGIAODataGridViewTextBoxColumn.DataPropertyName = "NGAY_GIAO";
            this.nGAYGIAODataGridViewTextBoxColumn.HeaderText = "NGAY_GIAO";
            this.nGAYGIAODataGridViewTextBoxColumn.Name = "nGAYGIAODataGridViewTextBoxColumn";
            // 
            // nOINHANDataGridViewTextBoxColumn
            // 
            this.nOINHANDataGridViewTextBoxColumn.DataPropertyName = "NOI_NHAN";
            this.nOINHANDataGridViewTextBoxColumn.HeaderText = "NOI_NHAN";
            this.nOINHANDataGridViewTextBoxColumn.Name = "nOINHANDataGridViewTextBoxColumn";
            // 
            // tRANGTHAIDataGridViewTextBoxColumn
            // 
            this.tRANGTHAIDataGridViewTextBoxColumn.DataPropertyName = "TRANG_THAI";
            this.tRANGTHAIDataGridViewTextBoxColumn.HeaderText = "TRANG_THAI";
            this.tRANGTHAIDataGridViewTextBoxColumn.Name = "tRANGTHAIDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trạng thái";
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(109, 22);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(100, 22);
            this.txtTrangthai.TabIndex = 1;
            // 
            // txtidpg
            // 
            this.txtidpg.Location = new System.Drawing.Point(360, 25);
            this.txtidpg.Name = "txtidpg";
            this.txtidpg.Size = new System.Drawing.Size(100, 22);
            this.txtidpg.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID_PG";
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(45, 50);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(271, 34);
            this.btnCapNhap.TabIndex = 4;
            this.btnCapNhap.Text = "Cập nhập trạng thái phiếu giao";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(360, 53);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(192, 31);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "xóa phiếu giao";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // Phieu_xuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Phieu_xuat";
            this.Text = "Phieu_xuat";
            this.Load += new System.EventHandler(this.Phieu_xuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_pg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUGIAOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ds_pg;
        private System.Windows.Forms.GroupBox groupBox2;
        private QLLKDataSet qLLKDataSet;
        private System.Windows.Forms.BindingSource pHIEUGIAOBindingSource;
        private QLLKDataSetTableAdapters.PHIEU_GIAOTableAdapter pHIEU_GIAOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYGIAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOINHANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANGTHAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.TextBox txtidpg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.Label label1;
    }
}