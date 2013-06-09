namespace projectquanlybenhvientinhangiang
{
    partial class fr_rp_hosonhanvien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbnhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dshosonhanvien = new projectquanlybenhvientinhangiang.dshosonhanvien();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbnhanvienTableAdapter = new projectquanlybenhvientinhangiang.dshosonhanvienTableAdapters.tbnhanvienTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbnhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshosonhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // tbnhanvienBindingSource
            // 
            this.tbnhanvienBindingSource.DataMember = "tbnhanvien";
            this.tbnhanvienBindingSource.DataSource = this.dshosonhanvien;
            // 
            // dshosonhanvien
            // 
            this.dshosonhanvien.DataSetName = "dshosonhanvien";
            this.dshosonhanvien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "dshosonhanvien_tbnhanvien";
            reportDataSource3.Value = this.tbnhanvienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "projectquanlybenhvientinhangiang.rp_hosonhanvien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 122);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1298, 229);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbnhanvienTableAdapter
            // 
            this.tbnhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(801, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kết Quả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(581, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(345, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn Mã Số Nhân Viên Cần In :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(467, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "THÔNG TIN  NHÂN VIÊN CẦN IN THEO MÃ SỐ";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnthoat.Location = new System.Drawing.Point(909, 56);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(82, 26);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // fr_rp_hosonhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 363);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fr_rp_hosonhanvien";
            this.Text = "fr_rp_hosonhanvien";
            this.Load += new System.EventHandler(this.fr_rp_hosonhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbnhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshosonhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbnhanvienBindingSource;
        private dshosonhanvien dshosonhanvien;
        private projectquanlybenhvientinhangiang.dshosonhanvienTableAdapters.tbnhanvienTableAdapter tbnhanvienTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoat;
    }
}