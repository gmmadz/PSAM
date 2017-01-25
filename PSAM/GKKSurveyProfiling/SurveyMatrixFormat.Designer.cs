namespace PSAM
{
    partial class SurveyMatrixFormat
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.residenceLocation = new System.Windows.Forms.ComboBox();
            this.houseStructure = new System.Windows.Forms.ComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.houseOccupancy = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.surveyYear = new System.Windows.Forms.ComboBox();
            this.gkk = new System.Windows.Forms.ComboBox();
            this.monthlyIncome = new System.Windows.Forms.ComboBox();
            this.MatrixBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProfilingSubsystem = new PSAM.ProfilingSubsystem();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MatrixTableAdapter = new PSAM.ProfilingSubsystemTableAdapters.MatrixTableAdapter();
            this.DataTable1TableAdapter = new PSAM.ProfilingSubsystemTableAdapters.DataTable1TableAdapter();
            this.isMemberGovOrg = new System.Windows.Forms.ComboBox();
            this.ifCanHelpCombo = new System.Windows.Forms.ComboBox();
            this.floodProne = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilingSubsystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "matrixFormat";
            reportDataSource1.Value = this.MatrixBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PSAM.MatrixFormat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1065, 310);
            this.reportViewer1.TabIndex = 1;
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
            this.splitContainer1.Panel1.Controls.Add(this.floodProne);
            this.splitContainer1.Panel1.Controls.Add(this.ifCanHelpCombo);
            this.splitContainer1.Panel1.Controls.Add(this.isMemberGovOrg);
            this.splitContainer1.Panel1.Controls.Add(this.monthlyIncome);
            this.splitContainer1.Panel1.Controls.Add(this.residenceLocation);
            this.splitContainer1.Panel1.Controls.Add(this.houseStructure);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel4);
            this.splitContainer1.Panel1.Controls.Add(this.houseOccupancy);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.metroTextButton1);
            this.splitContainer1.Panel1.Controls.Add(this.metroPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.surveyYear);
            this.splitContainer1.Panel1.Controls.Add(this.gkk);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1065, 445);
            this.splitContainer1.SplitterDistance = 131;
            this.splitContainer1.TabIndex = 2;
            // 
            // residenceLocation
            // 
            this.residenceLocation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.residenceLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.residenceLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.residenceLocation.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residenceLocation.FormattingEnabled = true;
            this.residenceLocation.Items.AddRange(new object[] {
            "Duol sa Suba",
            "Duol sa Creek",
            "Agi-anan sa tubig",
            "Pundohanan sa tubig",
            "Baybayon",
            "Dagat",
            "Kilid sa Bakilid",
            "None"});
            this.residenceLocation.Location = new System.Drawing.Point(221, 61);
            this.residenceLocation.Name = "residenceLocation";
            this.residenceLocation.Size = new System.Drawing.Size(233, 29);
            this.residenceLocation.TabIndex = 14;
            this.residenceLocation.Visible = false;
            // 
            // houseStructure
            // 
            this.houseStructure.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.houseStructure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.houseStructure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.houseStructure.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houseStructure.FormattingEnabled = true;
            this.houseStructure.Items.AddRange(new object[] {
            "Wooden",
            "Semi-Concrete",
            "Concrete"});
            this.houseStructure.Location = new System.Drawing.Point(221, 61);
            this.houseStructure.Name = "houseStructure";
            this.houseStructure.Size = new System.Drawing.Size(233, 29);
            this.houseStructure.TabIndex = 13;
            this.houseStructure.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(221, 39);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Field:";
            // 
            // houseOccupancy
            // 
            this.houseOccupancy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.houseOccupancy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.houseOccupancy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.houseOccupancy.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houseOccupancy.FormattingEnabled = true;
            this.houseOccupancy.Items.AddRange(new object[] {
            "Owned",
            "Renting",
            "Living with Parents/Relatives",
            "Used Free"});
            this.houseOccupancy.Location = new System.Drawing.Point(221, 61);
            this.houseOccupancy.Name = "houseOccupancy";
            this.houseOccupancy.Size = new System.Drawing.Size(233, 29);
            this.houseOccupancy.TabIndex = 11;
            this.houseOccupancy.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 39);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Filter By:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "View All",
            "House Structure",
            "House Occupancy",
            "Residence Location",
            "Monthly Income",
            "Member of NGO/GO",
            "Can Help During Disaster",
            "Flood Prone"});
            this.comboBox1.Location = new System.Drawing.Point(14, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 29);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroTextButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(943, 62);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(100, 29);
            this.metroTextButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextButton1.TabIndex = 8;
            this.metroTextButton1.Text = "Generate";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 126);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1065, 5);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile1.Location = new System.Drawing.Point(0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1065, 5);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(586, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(146, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "District - GKK - Address";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(469, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Year of Survey";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // surveyYear
            // 
            this.surveyYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.surveyYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.surveyYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.surveyYear.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surveyYear.FormattingEnabled = true;
            this.surveyYear.Location = new System.Drawing.Point(469, 62);
            this.surveyYear.Name = "surveyYear";
            this.surveyYear.Size = new System.Drawing.Size(103, 29);
            this.surveyYear.TabIndex = 4;
            this.surveyYear.SelectedIndexChanged += new System.EventHandler(this.surveyYear_SelectedIndexChanged);
            // 
            // gkk
            // 
            this.gkk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gkk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.gkk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gkk.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gkk.FormattingEnabled = true;
            this.gkk.Location = new System.Drawing.Point(586, 62);
            this.gkk.Name = "gkk";
            this.gkk.Size = new System.Drawing.Size(351, 29);
            this.gkk.TabIndex = 1;
            this.gkk.SelectedIndexChanged += new System.EventHandler(this.gkk_SelectedIndexChanged);
            // 
            // monthlyIncome
            // 
            this.monthlyIncome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.monthlyIncome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.monthlyIncome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.monthlyIncome.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyIncome.FormattingEnabled = true;
            this.monthlyIncome.Items.AddRange(new object[] {
            "below P5,000",
            "P5,001 - P10,000",
            "P10,001 - P15,000",
            "P15,001 - P20,000",
            "above P20,000"});
            this.monthlyIncome.Location = new System.Drawing.Point(221, 61);
            this.monthlyIncome.Name = "monthlyIncome";
            this.monthlyIncome.Size = new System.Drawing.Size(233, 29);
            this.monthlyIncome.TabIndex = 15;
            this.monthlyIncome.Visible = false;
            // 
            // MatrixBindingSource
            // 
            this.MatrixBindingSource.DataMember = "Matrix";
            this.MatrixBindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // ProfilingSubsystem
            // 
            this.ProfilingSubsystem.DataSetName = "ProfilingSubsystem";
            this.ProfilingSubsystem.EnforceConstraints = false;
            this.ProfilingSubsystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // MatrixTableAdapter
            // 
            this.MatrixTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // isMemberGovOrg
            // 
            this.isMemberGovOrg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.isMemberGovOrg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.isMemberGovOrg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.isMemberGovOrg.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isMemberGovOrg.FormattingEnabled = true;
            this.isMemberGovOrg.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.isMemberGovOrg.Location = new System.Drawing.Point(221, 61);
            this.isMemberGovOrg.Name = "isMemberGovOrg";
            this.isMemberGovOrg.Size = new System.Drawing.Size(233, 29);
            this.isMemberGovOrg.TabIndex = 16;
            this.isMemberGovOrg.Visible = false;
            // 
            // ifCanHelpCombo
            // 
            this.ifCanHelpCombo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ifCanHelpCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ifCanHelpCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ifCanHelpCombo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ifCanHelpCombo.FormattingEnabled = true;
            this.ifCanHelpCombo.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.ifCanHelpCombo.Location = new System.Drawing.Point(221, 61);
            this.ifCanHelpCombo.Name = "ifCanHelpCombo";
            this.ifCanHelpCombo.Size = new System.Drawing.Size(233, 29);
            this.ifCanHelpCombo.TabIndex = 17;
            this.ifCanHelpCombo.Visible = false;
            // 
            // floodProne
            // 
            this.floodProne.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.floodProne.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.floodProne.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.floodProne.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floodProne.FormattingEnabled = true;
            this.floodProne.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.floodProne.Location = new System.Drawing.Point(221, 61);
            this.floodProne.Name = "floodProne";
            this.floodProne.Size = new System.Drawing.Size(233, 29);
            this.floodProne.TabIndex = 18;
            this.floodProne.Visible = false;
            // 
            // SurveyMatrixFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 525);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SurveyMatrixFormat";
            this.Text = "Survey Summary - Matrix Format";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SurveyMatrixFormat_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MatrixBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilingSubsystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox gkk;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox surveyYear;
        private System.Windows.Forms.BindingSource MatrixBindingSource;
        private ProfilingSubsystem ProfilingSubsystem;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ProfilingSubsystemTableAdapters.MatrixTableAdapter MatrixTableAdapter;
        private ProfilingSubsystemTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox houseOccupancy;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox residenceLocation;
        private System.Windows.Forms.ComboBox houseStructure;
        private System.Windows.Forms.ComboBox monthlyIncome;
        private System.Windows.Forms.ComboBox floodProne;
        private System.Windows.Forms.ComboBox ifCanHelpCombo;
        private System.Windows.Forms.ComboBox isMemberGovOrg;
    }
}