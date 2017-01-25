namespace PSAM
{
    partial class SurveyMasterlist
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProfilingSubsystem = new PSAM.ProfilingSubsystem();
            this.masterlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.surveyYear = new System.Windows.Forms.ComboBox();
            this.gkk = new System.Windows.Forms.ComboBox();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.DataTable1TableAdapter = new PSAM.ProfilingSubsystemTableAdapters.DataTable1TableAdapter();
            this.masterlistTableAdapter = new PSAM.ProfilingSubsystemTableAdapters.masterlistTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilingSubsystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // ProfilingSubsystem
            // 
            this.ProfilingSubsystem.DataSetName = "ProfilingSubsystem";
            this.ProfilingSubsystem.EnforceConstraints = false;
            this.ProfilingSubsystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterlistBindingSource
            // 
            this.masterlistBindingSource.DataMember = "masterlist";
            this.masterlistBindingSource.DataSource = this.ProfilingSubsystem;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.DataTable1BindingSource;
            reportDataSource6.Name = "DataSet2";
            reportDataSource6.Value = this.masterlistBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PSAM.Masterlist.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1065, 435);
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
            this.splitContainer1.Panel1.Controls.Add(this.metroTile1);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.surveyYear);
            this.splitContainer1.Panel1.Controls.Add(this.gkk);
            this.splitContainer1.Panel1.Controls.Add(this.metroTextButton1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1065, 530);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 1;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTile1.Location = new System.Drawing.Point(0, 86);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1065, 5);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.TabIndex = 26;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(571, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(146, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "District - GKK - Address";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(447, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Year of Survey";
            // 
            // surveyYear
            // 
            this.surveyYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.surveyYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.surveyYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.surveyYear.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surveyYear.FormattingEnabled = true;
            this.surveyYear.Location = new System.Drawing.Point(447, 37);
            this.surveyYear.Name = "surveyYear";
            this.surveyYear.Size = new System.Drawing.Size(94, 29);
            this.surveyYear.TabIndex = 22;
            // 
            // gkk
            // 
            this.gkk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gkk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.gkk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gkk.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gkk.FormattingEnabled = true;
            this.gkk.Location = new System.Drawing.Point(571, 37);
            this.gkk.Name = "gkk";
            this.gkk.Size = new System.Drawing.Size(351, 29);
            this.gkk.TabIndex = 21;
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroTextButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(934, 35);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(100, 29);
            this.metroTextButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextButton1.TabIndex = 25;
            this.metroTextButton1.Text = "Generate";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // masterlistTableAdapter
            // 
            this.masterlistTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 50);
            this.label1.TabIndex = 27;
            this.label1.Text = "Survey Masterlist";
            // 
            // SurveyMasterlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 580);
            this.Controls.Add(this.splitContainer1);
            this.DisplayHeader = false;
            this.Name = "SurveyMasterlist";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Survey Masterlist";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SurveyMasterlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilingSubsystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterlistBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ProfilingSubsystem ProfilingSubsystem;
        private ProfilingSubsystemTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox surveyYear;
        private System.Windows.Forms.ComboBox gkk;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        private System.Windows.Forms.BindingSource masterlistBindingSource;
        private ProfilingSubsystemTableAdapters.masterlistTableAdapter masterlistTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}