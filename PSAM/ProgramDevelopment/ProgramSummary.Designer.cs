namespace PSAM
{
    partial class ProgramSummary
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.approvedPrograms = new System.Windows.Forms.ComboBox();
            this.metroTile9 = new MetroFramework.Controls.MetroTile();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.ProgramReports = new PSAM.ProgramReports();
            this.programOverviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programOverviewTableAdapter = new PSAM.ProgramReportsTableAdapters.programOverviewTableAdapter();
            this.listofbudgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listofbudgetTableAdapter = new PSAM.ProgramReportsTableAdapters.listofbudgetTableAdapter();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expensesTableAdapter = new PSAM.ProgramReportsTableAdapters.expensesTableAdapter();
            this.programDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programDetailsTableAdapter = new PSAM.ProgramReportsTableAdapters.programDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programOverviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listofbudgetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "overview";
            reportDataSource1.Value = this.programOverviewBindingSource;
            reportDataSource2.Name = "listofbudget";
            reportDataSource2.Value = this.listofbudgetBindingSource;
            reportDataSource3.Name = "withExpenses";
            reportDataSource3.Value = this.expensesBindingSource;
            reportDataSource4.Name = "programDetails";
            reportDataSource4.Value = this.programDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PSAM.ProgramSummary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(889, 329);
            this.reportViewer1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.metroTile9);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel16);
            this.splitContainer1.Panel1.Controls.Add(this.approvedPrograms);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(889, 399);
            this.splitContainer1.SplitterDistance = 66;
            this.splitContainer1.TabIndex = 1;
            // 
            // approvedPrograms
            // 
            this.approvedPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.approvedPrograms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.approvedPrograms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.approvedPrograms.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedPrograms.FormattingEnabled = true;
            this.approvedPrograms.Location = new System.Drawing.Point(404, 22);
            this.approvedPrograms.Name = "approvedPrograms";
            this.approvedPrograms.Size = new System.Drawing.Size(355, 25);
            this.approvedPrograms.TabIndex = 68;
            // 
            // metroTile9
            // 
            this.metroTile9.ActiveControl = null;
            this.metroTile9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile9.Location = new System.Drawing.Point(765, 22);
            this.metroTile9.Name = "metroTile9";
            this.metroTile9.Size = new System.Drawing.Size(104, 25);
            this.metroTile9.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile9.TabIndex = 119;
            this.metroTile9.Text = "Select";
            this.metroTile9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile9.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile9.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile9.UseSelectable = true;
            this.metroTile9.Click += new System.EventHandler(this.metroTile9_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(128, 28);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(270, 19);
            this.metroLabel16.TabIndex = 118;
            this.metroLabel16.Text = "Program Title / Disaster / Date of Occurence";
            // 
            // ProgramReports
            // 
            this.ProgramReports.DataSetName = "ProgramReports";
            this.ProgramReports.EnforceConstraints = false;
            this.ProgramReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programOverviewBindingSource
            // 
            this.programOverviewBindingSource.DataMember = "programOverview";
            this.programOverviewBindingSource.DataSource = this.ProgramReports;
            // 
            // programOverviewTableAdapter
            // 
            this.programOverviewTableAdapter.ClearBeforeFill = true;
            // 
            // listofbudgetBindingSource
            // 
            this.listofbudgetBindingSource.DataMember = "listofbudget";
            this.listofbudgetBindingSource.DataSource = this.ProgramReports;
            // 
            // listofbudgetTableAdapter
            // 
            this.listofbudgetTableAdapter.ClearBeforeFill = true;
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "expenses";
            this.expensesBindingSource.DataSource = this.ProgramReports;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // programDetailsBindingSource
            // 
            this.programDetailsBindingSource.DataMember = "programDetails";
            this.programDetailsBindingSource.DataSource = this.ProgramReports;
            // 
            // programDetailsTableAdapter
            // 
            this.programDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ProgramSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 479);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProgramSummary";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Program Summary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProgramSummary_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProgramReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programOverviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listofbudgetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox approvedPrograms;
        private MetroFramework.Controls.MetroTile metroTile9;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.BindingSource programOverviewBindingSource;
        private ProgramReports ProgramReports;
        private System.Windows.Forms.BindingSource listofbudgetBindingSource;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private System.Windows.Forms.BindingSource programDetailsBindingSource;
        private ProgramReportsTableAdapters.programOverviewTableAdapter programOverviewTableAdapter;
        private ProgramReportsTableAdapters.listofbudgetTableAdapter listofbudgetTableAdapter;
        private ProgramReportsTableAdapters.expensesTableAdapter expensesTableAdapter;
        private ProgramReportsTableAdapters.programDetailsTableAdapter programDetailsTableAdapter;
    }
}