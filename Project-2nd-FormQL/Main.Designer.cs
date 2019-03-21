namespace Project_2nd_FormQL
{
    partial class Main
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
            this.btn_combo = new System.Windows.Forms.Button();
            this.btn_QLSP = new System.Windows.Forms.Button();
            this.btn_QLPG = new System.Windows.Forms.Button();
            this.btn_QLHD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_combo
            // 
            this.btn_combo.Location = new System.Drawing.Point(144, 60);
            this.btn_combo.Name = "btn_combo";
            this.btn_combo.Size = new System.Drawing.Size(317, 127);
            this.btn_combo.TabIndex = 0;
            this.btn_combo.Text = "Bán hàng Combo";
            this.btn_combo.UseVisualStyleBackColor = true;
            this.btn_combo.Click += new System.EventHandler(this.btn_combo_Click);
            // 
            // btn_QLSP
            // 
            this.btn_QLSP.Location = new System.Drawing.Point(531, 60);
            this.btn_QLSP.Name = "btn_QLSP";
            this.btn_QLSP.Size = new System.Drawing.Size(317, 127);
            this.btn_QLSP.TabIndex = 1;
            this.btn_QLSP.Text = "Quản Lý Sản Phẩm";
            this.btn_QLSP.UseVisualStyleBackColor = true;
            this.btn_QLSP.Click += new System.EventHandler(this.btn_QLSP_Click);
            // 
            // btn_QLPG
            // 
            this.btn_QLPG.Location = new System.Drawing.Point(144, 233);
            this.btn_QLPG.Name = "btn_QLPG";
            this.btn_QLPG.Size = new System.Drawing.Size(317, 127);
            this.btn_QLPG.TabIndex = 2;
            this.btn_QLPG.Text = "Quản Lý Phiếu Giao";
            this.btn_QLPG.UseVisualStyleBackColor = true;
            this.btn_QLPG.Click += new System.EventHandler(this.btn_QLPG_Click);
            // 
            // btn_QLHD
            // 
            this.btn_QLHD.Location = new System.Drawing.Point(531, 233);
            this.btn_QLHD.Name = "btn_QLHD";
            this.btn_QLHD.Size = new System.Drawing.Size(317, 127);
            this.btn_QLHD.TabIndex = 3;
            this.btn_QLHD.Text = "Quản Lý Hóa Đơn";
            this.btn_QLHD.UseVisualStyleBackColor = true;
            this.btn_QLHD.Click += new System.EventHandler(this.btn_QLHD_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 515);
            this.Controls.Add(this.btn_QLHD);
            this.Controls.Add(this.btn_QLPG);
            this.Controls.Add(this.btn_QLSP);
            this.Controls.Add(this.btn_combo);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_combo;
        private System.Windows.Forms.Button btn_QLSP;
        private System.Windows.Forms.Button btn_QLPG;
        private System.Windows.Forms.Button btn_QLHD;
    }
}

