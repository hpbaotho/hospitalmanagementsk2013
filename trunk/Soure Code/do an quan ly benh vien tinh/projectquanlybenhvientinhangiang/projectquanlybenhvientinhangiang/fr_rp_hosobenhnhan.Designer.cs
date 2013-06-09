namespace projectquanlybenhvientinhangiang
{
    partial class fr_rp_hosobenhnhan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbbenhnhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dshosobenhnhan = new projectquanlybenhvientinhangiang.dshosobenhnhan();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbbenhnhanTableAdapter = new projectquanlybenhvientinhangiang.dshosobenhnhanTableAdapters.tbbenhnhanTableAdapter();
            this.btnkq = new System.Windows.Forms.Button();
            this.txtmabn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbbenhnhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshosobenhnhan)).BeginInit();
            this.SuspendLayout();
            // 
            // tbbenhnhanBindingSource
            // 
            this.tbbenhnhanBindingSource.DataMember = "tbbenhnhan";
            this.tbbenhnhanBindingSource.DataSource = this.dshosobenhnhan;
            // 
            // dshosobenhnhan
            // 
            this.dshosobenhnhan.DataSetName = "dshosobenhnhan";
            this.dshosobenhnhan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "dshosobenhnhan_tbbenhnhan";
            reportDataSource2.Value = this.tbbenhnhanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "projectquanlybenhvientinhangiang.rp_hosobenhnhan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1062, 237);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbbenhnhanTableAdapter
            // 
            this.tbbenhnhanTableAdapter.ClearBeforeFill = true;
            // 
            // btnkq
            // 
            this.btnkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkq.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnkq.Location = new System.Drawing.Point(685, 59);
            this.btnkq.Name = "btnkq";
            this.btnkq.Size = new System.Drawing.Size(87, 25);
            this.btnkq.TabIndex = 1;
            this.btnkq.Text = "Kết Quả";
            this.btnkq.UseVisualStyleBackColor = true;
            this.btnkq.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtmabn
            // 
            this.txtmabn.Location = new System.Drawing.Point(496, 63);
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Size = new System.Drawing.Size(159, 20);
            this.txtmabn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(245, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn Mã Số Bệnh Nhân Cần In:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(359, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "THÔNG TIN BỆNH NHÂN CẦN IN THEO MÃ SỐ";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnthoat.Location = new System.Drawing.Point(793, 59);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(87, 25);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // fr_rp_hosobenhnhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 367);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmabn);
            this.Controls.Add(this.btnkq);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fr_rp_hosobenhnhan";
            this.Text = "fr_rp_hosobenhnhan";
            this.Load += new System.EventHandler(this.fr_rp_hosobenhnhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbbenhnhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshosobenhnhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbbenhnhanBindingSource;
        private dshosobenhnhan dshosobenhnhan;
        private projectquanlybenhvientinhangiang.dshosobenhnhanTableAdapters.tbbenhnhanTableAdapter tbbenhnhanTableAdapter;
        private System.Windows.Forms.Button btnkq;
        private System.Windows.Forms.TextBox txtmabn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoat;
    }
}