namespace PSAM
{
    partial class SurveyMonthlyIncome
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
            this.secondBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProfilingSubsystem = new PSAM.ProfilingSubsystem();
            this.firstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thirdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fourthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fifthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalHouseholdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.total = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.surveyYear = new System.Windows.Forms.ComboBox();
            this.gkk = new System.Windows.Forms.ComboBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.secondTableAdapter = new PSAM.ProfilingSubsystemTableAdapters.secondTableAdapter();
            this.firstTableAdapter = new PSAM.ProfilingSubsystemTableAdapters.firstTableAdapter();
            this.thirdTableAdapter = new PSAM.ProfilingSubsystemTableAdapters.thirdTableAdapter();
            this.fourthTableAdapter = new PSAM.ProfilingSubsystemTableAdapters.fourthTableAdapter();
            this.fifthTableAdapter = new PSAM.ProfilingSubsystemTableAdapters.fifthTableAdapter();
            this.DataTable1TableAdapter = new PSAM.ProfilingSubsystemTableAdapters.DataTable1TableAdapter();
            this.totalHouseholdTableAdapter = new PSAM.ProfilingSubsystemTableAdapters.totalHouseholdTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.secondBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilingSubsystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalHouseholdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // secondBindingSource
            // 
            this.secondBindingSource.DataMember = "second";
            this.secondBindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // ProfilingSubsystem
            // 
            this.ProfilingSubsystem.DataSetName = "ProfilingSubsystem";
            this.ProfilingSubsystem.EnforceConstraints = false;
            this.ProfilingSubsystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firstBindingSource
            // 
            this.firstBindingSource.DataMember = "first";
            this.firstBindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // thirdBindingSource
            // 
            this.thirdBindingSource.DataMember = "third";
            this.thirdBindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // fourthBindingSource
            // 
            this.fourthBindingSource.DataMember = "fourth";
            this.fourthBindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // fifthBindingSource
            // 
            this.fifthBindingSource.DataMember = "fifth";
            this.fifthBindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // totalHouseholdBindingSource
            // 
            this.totalHouseholdBindingSource.DataMember = "totalHousehold";
            this.totalHouseholdBindingSource.DataSource = this.ProfilingSubsystem;
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
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.total);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.surveyYear);
            this.splitContainer1.Panel1.Controls.Add(this.gkk);
            this.splitContainer1.Panel1.Controls.Add(this.metroTile1);
            this.splitContainer1.Panel1.Controls.Add(this.metroTextButton1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1072, 434);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 0;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(891, 17);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(143, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Number of Household:";
            this.metroLabel3.Visible = false;
            // 
            // total
            // 
            this.total.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(1040, 17);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(16, 19);
            this.total.TabIndex = 21;
            this.total.Text = "0";
            this.total.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(593, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(146, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "District - GKK - Address";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(453, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Year of Survey";
            // 
            // surveyYear
            // 
            this.surveyYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.surveyYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.surveyYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.surveyYear.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surveyYear.FormattingEnabled = true;
            this.surveyYear.Location = new System.Drawing.Point(453, 41);
            this.surveyYear.Name = "surveyYear";
            this.surveyYear.Size = new System.Drawing.Size(103, 29);
            this.surveyYear.TabIndex = 17;
            // 
            // gkk
            // 
            this.gkk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gkk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.gkk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gkk.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gkk.FormattingEnabled = true;
            this.gkk.Location = new System.Drawing.Point(593, 41);
            this.gkk.Name = "gkk";
            this.gkk.Size = new System.Drawing.Size(351, 29);
            this.gkk.TabIndex = 15;
            this.gkk.SelectionChangeCommitted += new System.EventHandler(this.gkk_SelectionChangeCommitted_1);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTile1.Location = new System.Drawing.Point(0, 85);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1072, 5);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.TabIndex = 16;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroTextButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(956, 39);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(100, 29);
            this.metroTextButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextButton1.TabIndex = 20;
            this.metroTextButton1.Text = "Generate";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.secondBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.firstBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.thirdBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.fourthBindingSource;
            reportDataSource5.Name = "DataSet5";
            reportDataSource5.Value = this.fifthBindingSource;
            reportDataSource6.Name = "DataSet6";
            reportDataSource6.Value = this.DataTable1BindingSource;
            reportDataSource7.Name = "DataSet7";
            reportDataSource7.Value = this.totalHouseholdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PSAM.HouseholdAverageMonthlyIncome.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1072, 340);
            this.reportViewer1.TabIndex = 0;
            // 
            // secondTableAdapter
            // 
            this.secondTableAdapter.ClearBeforeFill = true;
            // 
            // firstTableAdapter
            // 
            this.firstTableAdapter.ClearBeforeFill = true;
            // 
            // thirdTableAdapter
            // 
            this.thirdTableAdapter.ClearBeforeFill = true;
            // 
            // fourthTableAdapter
            // 
            this.fourthTableAdapter.ClearBeforeFill = true;
            // 
            // fifthTableAdapter
            // 
            this.fifthTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // totalHouseholdTableAdapter
            // 
            this.totalHouseholdTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 50);
            this.label1.TabIndex = 28;
            this.label1.Text = "Average Monthly Income";
            // 
            // SurveyMonthlyIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 484);
            this.Controls.Add(this.splitContainer1);
            this.DisplayHeader = false;
            this.Name = "SurveyMonthlyIncome";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Total Household Average Monthly Income";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SurveyMonthlyIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secondBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilingSubsystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalHouseholdBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource secondBindingSource;
        private ProfilingSubsystem ProfilingSubsystem;
        private System.Windows.Forms.BindingSource firstBindingSource;
        private System.Windows.Forms.BindingSource thirdBindingSource;
        private System.Windows.Forms.BindingSource fourthBindingSource;
        private System.Windows.Forms.BindingSource fifthBindingSource;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.BindingSource totalHouseholdBindingSource;
        private ProfilingSubsystemTableAdapters.secondTableAdapter secondTableAdapter;
        private ProfilingSubsystemTableAdapters.firstTableAdapter firstTableAdapter;
        private ProfilingSubsystemTableAdapters.thirdTableAdapter thirdTableAdapter;
        private ProfilingSubsystemTableAdapters.fourthTableAdapter fourthTableAdapter;
        private ProfilingSubsystemTableAdapters.fifthTableAdapter fifthTableAdapter;
        private ProfilingSubsystemTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private ProfilingSubsystemTableAdapters.totalHouseholdTableAdapter totalHouseholdTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox surveyYear;
        private System.Windows.Forms.ComboBox gkk;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel total;
        private System.Windows.Forms.Label label1;
    }
}