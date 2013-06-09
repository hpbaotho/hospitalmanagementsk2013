namespace projectquanlybenhvientinhangiang
{
    partial class frtamung
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
            this.cbotenbn = new System.Windows.Forms.ComboBox();
            this.cbohobn = new System.Windows.Forms.ComboBox();
            this.cbomabn = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttienphaitra = new System.Windows.Forms.TextBox();
            this.txttientamung = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttienkham = new System.Windows.Forms.TextBox();
            this.txtchuandoan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txttienhoanlai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btntienhoanlai = new System.Windows.Forms.Button();
            this.dgwtamung = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwtamung)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbotenbn);
            this.groupBox1.Controls.Add(this.cbohobn);
            this.groupBox1.Controls.Add(this.cbomabn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(32, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã Số, Họ Tên Bệnh Nhân";
            // 
            // cbotenbn
            // 
            this.cbotenbn.FormattingEnabled = true;
            this.cbotenbn.Location = new System.Drawing.Point(133, 108);
            this.cbotenbn.Name = "cbotenbn";
            this.cbotenbn.Size = new System.Drawing.Size(164, 24);
            this.cbotenbn.TabIndex = 2;
            // 
            // cbohobn
            // 
            this.cbohobn.FormattingEnabled = true;
            this.cbohobn.Location = new System.Drawing.Point(133, 68);
            this.cbohobn.Name = "cbohobn";
            this.cbohobn.Size = new System.Drawing.Size(164, 24);
            this.cbohobn.TabIndex = 1;
            // 
            // cbomabn
            // 
            this.cbomabn.FormattingEnabled = true;
            this.cbomabn.Location = new System.Drawing.Point(133, 26);
            this.cbomabn.Name = "cbomabn";
            this.cbomabn.Size = new System.Drawing.Size(164, 24);
            this.cbomabn.TabIndex = 0;
            this.cbomabn.SelectedIndexChanged += new System.EventHandler(this.cbomabn_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(20, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên BN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ BN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Số BN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(127, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TẠM ỨNG VIỆN PHÍ VÀ TIỀN HOÀN LẠI CHO BỆNH NHÂN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttienphaitra);
            this.groupBox2.Controls.Add(this.txttientamung);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(382, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 138);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiền Tạm Ứng, Tiền Phải Trả";
            // 
            // txttienphaitra
            // 
            this.txttienphaitra.Location = new System.Drawing.Point(122, 80);
            this.txttienphaitra.Name = "txttienphaitra";
            this.txttienphaitra.Size = new System.Drawing.Size(164, 22);
            this.txttienphaitra.TabIndex = 4;
            // 
            // txttientamung
            // 
            this.txttientamung.Location = new System.Drawing.Point(122, 35);
            this.txttientamung.Name = "txttientamung";
            this.txttientamung.Size = new System.Drawing.Size(164, 22);
            this.txttientamung.TabIndex = 3;
            this.txttientamung.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tiền Phải Trả";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tiền Tạm Ứng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttienkham);
            this.groupBox3.Controls.Add(this.txtchuandoan);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(32, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 106);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Căn Bệnh Chuẩn Đoán, Tiền Khám";
            // 
            // txttienkham
            // 
            this.txttienkham.Location = new System.Drawing.Point(133, 63);
            this.txttienkham.Name = "txttienkham";
            this.txttienkham.Size = new System.Drawing.Size(164, 22);
            this.txttienkham.TabIndex = 6;
            // 
            // txtchuandoan
            // 
            this.txtchuandoan.Location = new System.Drawing.Point(133, 28);
            this.txtchuandoan.Name = "txtchuandoan";
            this.txtchuandoan.Size = new System.Drawing.Size(164, 22);
            this.txtchuandoan.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(20, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tiền Khám";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(20, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chuẩn Đoán";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txttienhoanlai);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(382, 231);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tổng Tiền Hoàn Lại Cho Bệnh Nhân";
            // 
            // txttienhoanlai
            // 
            this.txttienhoanlai.Location = new System.Drawing.Point(157, 41);
            this.txttienhoanlai.Name = "txttienhoanlai";
            this.txttienhoanlai.Size = new System.Drawing.Size(144, 22);
            this.txttienhoanlai.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(6, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tổng Tiền Hoàn Lại";
            // 
            // btntienhoanlai
            // 
            this.btntienhoanlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntienhoanlai.ForeColor = System.Drawing.Color.Fuchsia;
            this.btntienhoanlai.Location = new System.Drawing.Point(258, 338);
            this.btntienhoanlai.Name = "btntienhoanlai";
            this.btntienhoanlai.Size = new System.Drawing.Size(91, 50);
            this.btntienhoanlai.TabIndex = 8;
            this.btntienhoanlai.Text = "Tính Tiền Hoàn Lại";
            this.btntienhoanlai.UseVisualStyleBackColor = true;
            this.btntienhoanlai.Click += new System.EventHandler(this.btntienhoanlai_Click);
            // 
            // dgwtamung
            // 
            this.dgwtamung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwtamung.Location = new System.Drawing.Point(12, 393);
            this.dgwtamung.Name = "dgwtamung";
            this.dgwtamung.Size = new System.Drawing.Size(704, 106);
            this.dgwtamung.TabIndex = 6;
            this.dgwtamung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwtamung_CellContentClick);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnthoat.Location = new System.Drawing.Point(381, 338);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(91, 50);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frtamung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 501);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dgwtamung);
            this.Controls.Add(this.btntienhoanlai);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frtamung";
            this.Text = "frtamung";
            this.Load += new System.EventHandler(this.frtamung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwtamung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btntienhoanlai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgwtamung;
        private System.Windows.Forms.ComboBox cbotenbn;
        private System.Windows.Forms.ComboBox cbohobn;
        private System.Windows.Forms.ComboBox cbomabn;
        private System.Windows.Forms.TextBox txttienphaitra;
        private System.Windows.Forms.TextBox txttientamung;
        private System.Windows.Forms.TextBox txttienkham;
        private System.Windows.Forms.TextBox txtchuandoan;
        private System.Windows.Forms.TextBox txttienhoanlai;
        private System.Windows.Forms.Button btnthoat;
    }
}