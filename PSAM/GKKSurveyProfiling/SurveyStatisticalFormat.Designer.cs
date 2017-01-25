namespace PSAM
{
    partial class SurveyStatisticalFormat
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.householdMonthlyIncomeChartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProfilingSubsystem = new PSAM.ProfilingSubsystem();
            this.householdHouseOccupancyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsUsedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residenceLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isFloodProneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isMemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.surveyYear = new System.Windows.Forms.ComboBox();
            this.gkk = new System.Windows.Forms.ComboBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.householdMonthlyIncomeChartTableAdapter = new PSAM.ProfilingSubsystemTableAdapters.householdMonthlyIncomeChartTableAdapter();
            this.householdHouseOccupancyTableAdapter = new PSAM.ProfilingSubsystemTableAdapters.householdHouseOccupancyTableAdapter();
            this.materialsUsedTableAdapter = new PSAM.ProfilingSubsystemTableAdapters.materialsUsedTableAdapter();
            this.residenceLocationTableAdapter = new PSAM.ProfilingSubsystemTableAdapters.residenceLocationTableAdapter();
            this.isFloodProneTableAdapter = new PSAM.ProfilingSubsystemTableAdapters.isFloodProneTableAdapter();
            this.isMemTableAdapter = new PSAM.ProfilingSubsystemTableAdapters.isMemTableAdapter();
            this.DataTable1TableAdapter = new PSAM.ProfilingSubsystemTableAdapters.DataTable1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.householdMonthlyIncomeChartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilingSubsystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.householdHouseOccupancyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsUsedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residenceLocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isFloodProneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isMemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // householdMonthlyIncomeChartBindingSource
            // 
            this.householdMonthlyIncomeChartBindingSource.DataMember = "householdMonthlyIncomeChart";
            this.householdMonthlyIncomeChartBindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // ProfilingSubsystem
            // 
            this.ProfilingSubsystem.DataSetName = "ProfilingSubsystem";
            this.ProfilingSubsystem.EnforceConstraints = false;
            this.ProfilingSubsystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // householdHouseOccupancyBindingSource
            // 
            this.householdHouseOccupancyBindingSource.DataMember = "householdHouseOccupancy";
            this.householdHouseOccupancyBindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // materialsUsedBindingSource
            // 
            this.materialsUsedBindingSource.DataMember = "materialsUsed";
            this.materialsUsedBindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // residenceLocationBindingSource
            // 
            this.residenceLocationBindingSource.DataMember = "residenceLocation";
            this.residenceLocationBindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // isFloodProneBindingSource
            // 
            this.isFloodProneBindingSource.DataMember = "isFloodProne";
            this.isFloodProneBindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // isMemBindingSource
            // 
            this.isMemBindingSource.DataMember = "isMem";
            this.isMemBindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "monthlyIncome";
            reportDataSource1.Value = this.householdMonthlyIncomeChartBindingSource;
            reportDataSource2.Name = "houseOccupancy";
            reportDataSource2.Value = this.householdHouseOccupancyBindingSource;
            reportDataSource3.Name = "materialsUsed";
            reportDataSource3.Value = this.materialsUsedBindingSource;
            reportDataSource4.Name = "residenceLocation";
            reportDataSource4.Value = this.residenceLocationBindingSource;
            reportDataSource5.Name = "isFloodProne";
            reportDataSource5.Value = this.isFloodProneBindingSource;
            reportDataSource6.Name = "mem";
            reportDataSource6.Value = this.isMemBindingSource;
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PSAM.SurveySocioEconomicDisasterPreparednessReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1053, 362);
            this.reportViewer1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.surveyYear);
            this.splitContainer1.Panel1.Controls.Add(this.gkk);
            this.splitContainer1.Panel1.Controls.Add(this.metroTile1);
            this.splitContainer1.Panel1.Controls.Add(this.metroTextButton1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1053, 447);
            this.splitContainer1.SplitterDistance = 81;
            this.splitContainer1.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(573, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(146, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "District - GKK - Address";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(433, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Year of Survey";
            // 
            // surveyYear
            // 
            this.surveyYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.surveyYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.surveyYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.surveyYear.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surveyYear.FormattingEnabled = true;
            this.surveyYear.Location = new System.Drawing.Point(433, 36);
            this.surveyYear.Name = "surveyYear";
            this.surveyYear.Size = new System.Drawing.Size(103, 29);
            this.surveyYear.TabIndex = 11;
            // 
            // gkk
            // 
            this.gkk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gkk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.gkk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gkk.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gkk.FormattingEnabled = true;
            this.gkk.Location = new System.Drawing.Point(573, 36);
            this.gkk.Name = "gkk";
            this.gkk.Size = new System.Drawing.Size(351, 29);
            this.gkk.TabIndex = 9;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTile1.Location = new System.Drawing.Point(0, 76);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1053, 5);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.TabIndex = 10;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroTextButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(936, 34);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(100, 29);
            this.metroTextButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextButton1.TabIndex = 14;
            this.metroTextButton1.Text = "Generate";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // householdMonthlyIncomeChartTableAdapter
            // 
            this.householdMonthlyIncomeChartTableAdapter.ClearBeforeFill = true;
            // 
            // householdHouseOccupancyTableAdapter
            // 
            this.householdHouseOccupancyTableAdapter.ClearBeforeFill = true;
            // 
            // materialsUsedTableAdapter
            // 
            this.materialsUsedTableAdapter.ClearBeforeFill = true;
            // 
            // residenceLocationTableAdapter
            // 
            this.residenceLocationTableAdapter.ClearBeforeFill = true;
            // 
            // isFloodProneTableAdapter
            // 
            this.isFloodProneTableAdapter.ClearBeforeFill = true;
            // 
            // isMemTableAdapter
            // 
            this.isMemTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 50);
            this.label1.TabIndex = 28;
            this.label1.Text = "Graphical Format";
            // 
            // SurveyStatisticalFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 497);
            this.Controls.Add(this.splitContainer1);
            this.DisplayHeader = false;
            this.Name = "SurveyStatisticalFormat";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Socio Economic and Disaster Preparedness Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SurveyStatisticalFormat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.householdMonthlyIncomeChartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilingSubsystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.householdHouseOccupancyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsUsedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residenceLocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isFloodProneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isMemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox surveyYear;
        private System.Windows.Forms.ComboBox gkk;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        private System.Windows.Forms.BindingSource householdMonthlyIncomeChartBindingSource;
        private ProfilingSubsystem ProfilingSubsystem;
        private System.Windows.Forms.BindingSource householdHouseOccupancyBindingSource;
        private System.Windows.Forms.BindingSource materialsUsedBindingSource;
        private System.Windows.Forms.BindingSource residenceLocationBindingSource;
        private System.Windows.Forms.BindingSource isFloodProneBindingSource;
        private System.Windows.Forms.BindingSource isMemBindingSource;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ProfilingSubsystemTableAdapters.householdMonthlyIncomeChartTableAdapter householdMonthlyIncomeChartTableAdapter;
        private ProfilingSubsystemTableAdapters.householdHouseOccupancyTableAdapter householdHouseOccupancyTableAdapter;
        private ProfilingSubsystemTableAdapters.materialsUsedTableAdapter materialsUsedTableAdapter;
        private ProfilingSubsystemTableAdapters.residenceLocationTableAdapter residenceLocationTableAdapter;
        private ProfilingSubsystemTableAdapters.isFloodProneTableAdapter isFloodProneTableAdapter;
        private ProfilingSubsystemTableAdapters.isMemTableAdapter isMemTableAdapter;
        private ProfilingSubsystemTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Label label1;
    }
}