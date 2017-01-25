namespace PSAM
{
    partial class Form1
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
            this.psamDataSet = new PSAM.psamDataSet();
            this.respondent1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.respondent1TableAdapter = new PSAM.psamDataSetTableAdapters.respondent1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.psamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respondent1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.respondent1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PSAM.ViewProfile.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1190, 347);
            this.reportViewer1.TabIndex = 0;
            // 
            // psamDataSet
            // 
            this.psamDataSet.DataSetName = "psamDataSet";
            this.psamDataSet.EnforceConstraints = false;
            this.psamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // respondent1BindingSource
            // 
            this.respondent1BindingSource.DataMember = "respondent1";
            this.respondent1BindingSource.DataSource = this.psamDataSet;
            // 
            // respondent1TableAdapter
            // 
            this.respondent1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 347);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.psamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respondent1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource respondent1BindingSource;
        private psamDataSet psamDataSet;
        private psamDataSetTableAdapters.respondent1TableAdapter respondent1TableAdapter;
    }
}