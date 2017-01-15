namespace DOAN
{
    partial class Report_TKKD
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThongKeKinhDoanh = new DOAN.ThongKeKinhDoanh();
            this.DataTableTKKDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableTKKDTableAdapter = new DOAN.ThongKeKinhDoanhTableAdapters.DataTableTKKDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeKinhDoanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableTKKDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_TKKD";
            reportDataSource1.Value = this.DataTableTKKDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOAN.Report_TKKD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(699, 442);
            this.reportViewer1.TabIndex = 0;
            // 
            // ThongKeKinhDoanh
            // 
            this.ThongKeKinhDoanh.DataSetName = "ThongKeKinhDoanh";
            this.ThongKeKinhDoanh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableTKKDBindingSource
            // 
            this.DataTableTKKDBindingSource.DataMember = "DataTableTKKD";
            this.DataTableTKKDBindingSource.DataSource = this.ThongKeKinhDoanh;
            // 
            // DataTableTKKDTableAdapter
            // 
            this.DataTableTKKDTableAdapter.ClearBeforeFill = true;
            // 
            // Report_TKKD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 442);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_TKKD";
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.Report_TKDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeKinhDoanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableTKKDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableTKKDBindingSource;
        private ThongKeKinhDoanh ThongKeKinhDoanh;
        private ThongKeKinhDoanhTableAdapters.DataTableTKKDTableAdapter DataTableTKKDTableAdapter;
    }
}