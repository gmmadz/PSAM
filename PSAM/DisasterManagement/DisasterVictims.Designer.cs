namespace PSAM
{
    partial class DisasterVictims
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
            this.MASTERLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DisasterDATASET = new PSAM.DisasterDATASET();
            this.disastersCombo = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MASTERLISTTableAdapter = new PSAM.DisasterDATASETTableAdapters.MASTERLISTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MASTERLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisasterDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MASTERLISTBindingSource
            // 
            this.MASTERLISTBindingSource.DataMember = "MASTERLIST";
            this.MASTERLISTBindingSource.DataSource = this.DisasterDATASET;
            // 
            // DisasterDATASET
            // 
            this.DisasterDATASET.DataSetName = "DisasterDATASET";
            this.DisasterDATASET.EnforceConstraints = false;
            this.DisasterDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disastersCombo
            // 
            this.disastersCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.disastersCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disastersCombo.FormattingEnabled = true;
            this.disastersCombo.Location = new System.Drawing.Point(32, 28);
            this.disastersCombo.Name = "disastersCombo";
            this.disastersCombo.Size = new System.Drawing.Size(231, 29);
            this.disastersCombo.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.metroTile1);
            this.splitContainer1.Panel1.Controls.Add(this.disastersCombo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(843, 378);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 1;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(149, 75);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(114, 36);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Generate";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "masterlist";
            reportDataSource1.Value = this.MASTERLISTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PSAM.MasterlistVictims.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(559, 378);
            this.reportViewer1.TabIndex = 0;
            // 
            // MASTERLISTTableAdapter
            // 
            this.MASTERLISTTableAdapter.ClearBeforeFill = true;
            // 
            // DisasterVictims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 458);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DisasterVictims";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Disaster Victims Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DisasterVictims_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MASTERLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisasterDATASET)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox disastersCombo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MASTERLISTBindingSource;
        private DisasterDATASET DisasterDATASET;
        private DisasterDATASETTableAdapters.MASTERLISTTableAdapter MASTERLISTTableAdapter;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}