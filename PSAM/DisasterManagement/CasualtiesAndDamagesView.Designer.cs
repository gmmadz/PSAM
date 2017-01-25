namespace PSAM
{
    partial class CasualtiesAndDamagesView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelType = new MetroFramework.Controls.MetroLabel();
            this.labelFamilyHead = new MetroFramework.Controls.MetroLabel();
            this.familyHead = new MetroFramework.Controls.MetroComboBox();
            this.to = new MetroFramework.Controls.MetroLabel();
            this.from = new MetroFramework.Controls.MetroLabel();
            this.filterByDateFrom = new MetroFramework.Controls.MetroDateTime();
            this.viewSpecific = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.filterByDateTo = new MetroFramework.Controls.MetroDateTime();
            this.comboDisaster = new MetroFramework.Controls.MetroComboBox();
            this.radioTypeFamHead = new MetroFramework.Controls.MetroRadioButton();
            this.radioTypeDate = new MetroFramework.Controls.MetroRadioButton();
            this.radioDate = new MetroFramework.Controls.MetroRadioButton();
            this.radioType = new MetroFramework.Controls.MetroRadioButton();
            this.radioViewAll = new MetroFramework.Controls.MetroRadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.casualtiesDGV = new System.Windows.Forms.DataGridView();
            this.damagesDGV = new System.Windows.Forms.DataGridView();
            this.viewFamilyHead = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casualtiesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damagesDGV)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.viewFamilyHead);
            this.splitContainer1.Panel1.Controls.Add(this.labelType);
            this.splitContainer1.Panel1.Controls.Add(this.labelFamilyHead);
            this.splitContainer1.Panel1.Controls.Add(this.familyHead);
            this.splitContainer1.Panel1.Controls.Add(this.to);
            this.splitContainer1.Panel1.Controls.Add(this.from);
            this.splitContainer1.Panel1.Controls.Add(this.filterByDateFrom);
            this.splitContainer1.Panel1.Controls.Add(this.viewSpecific);
            this.splitContainer1.Panel1.Controls.Add(this.filterByDateTo);
            this.splitContainer1.Panel1.Controls.Add(this.comboDisaster);
            this.splitContainer1.Panel1.Controls.Add(this.radioTypeFamHead);
            this.splitContainer1.Panel1.Controls.Add(this.radioTypeDate);
            this.splitContainer1.Panel1.Controls.Add(this.radioDate);
            this.splitContainer1.Panel1.Controls.Add(this.radioType);
            this.splitContainer1.Panel1.Controls.Add(this.radioViewAll);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(880, 462);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(290, 21);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(127, 19);
            this.labelType.TabIndex = 21;
            this.labelType.Text = "Select Disaster Type:";
            this.labelType.Visible = false;
            // 
            // labelFamilyHead
            // 
            this.labelFamilyHead.AutoSize = true;
            this.labelFamilyHead.Location = new System.Drawing.Point(290, 129);
            this.labelFamilyHead.Name = "labelFamilyHead";
            this.labelFamilyHead.Size = new System.Drawing.Size(123, 19);
            this.labelFamilyHead.TabIndex = 20;
            this.labelFamilyHead.Text = "Select Family Head:";
            this.labelFamilyHead.Visible = false;
            // 
            // familyHead
            // 
            this.familyHead.FormattingEnabled = true;
            this.familyHead.ItemHeight = 23;
            this.familyHead.Items.AddRange(new object[] {
            "Flood or Storm",
            "Earthquake",
            "Landslide",
            "Volcanic",
            "Tsunami",
            "Fire",
            "Accident",
            "Epidemic"});
            this.familyHead.Location = new System.Drawing.Point(290, 151);
            this.familyHead.Name = "familyHead";
            this.familyHead.Size = new System.Drawing.Size(233, 29);
            this.familyHead.TabIndex = 19;
            this.familyHead.UseSelectable = true;
            this.familyHead.Visible = false;
            this.familyHead.SelectionChangeCommitted += new System.EventHandler(this.familyHead_SelectionChangeCommitted);
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(558, 90);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(27, 19);
            this.to.TabIndex = 18;
            this.to.Text = "To:";
            this.to.Visible = false;
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(290, 91);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(44, 19);
            this.from.TabIndex = 17;
            this.from.Text = "From:";
            this.from.Visible = false;
            // 
            // filterByDateFrom
            // 
            this.filterByDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filterByDateFrom.Location = new System.Drawing.Point(348, 81);
            this.filterByDateFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.filterByDateFrom.Name = "filterByDateFrom";
            this.filterByDateFrom.Size = new System.Drawing.Size(175, 29);
            this.filterByDateFrom.TabIndex = 16;
            this.filterByDateFrom.Visible = false;
            // 
            // viewSpecific
            // 
            this.viewSpecific.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewSpecific.Image = null;
            this.viewSpecific.Location = new System.Drawing.Point(772, 81);
            this.viewSpecific.Name = "viewSpecific";
            this.viewSpecific.Size = new System.Drawing.Size(86, 29);
            this.viewSpecific.TabIndex = 15;
            this.viewSpecific.Text = "View";
            this.viewSpecific.UseSelectable = true;
            this.viewSpecific.UseVisualStyleBackColor = true;
            this.viewSpecific.Visible = false;
            this.viewSpecific.Click += new System.EventHandler(this.viewSpecific_Click);
            // 
            // filterByDateTo
            // 
            this.filterByDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filterByDateTo.Location = new System.Drawing.Point(591, 81);
            this.filterByDateTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.filterByDateTo.Name = "filterByDateTo";
            this.filterByDateTo.Size = new System.Drawing.Size(175, 29);
            this.filterByDateTo.TabIndex = 14;
            this.filterByDateTo.Visible = false;
            // 
            // comboDisaster
            // 
            this.comboDisaster.FormattingEnabled = true;
            this.comboDisaster.ItemHeight = 23;
            this.comboDisaster.Items.AddRange(new object[] {
            "Flood or Storm",
            "Earthquake",
            "Landslide",
            "Volcanic",
            "Tsunami",
            "Fire",
            "Accident",
            "Epidemic"});
            this.comboDisaster.Location = new System.Drawing.Point(290, 46);
            this.comboDisaster.Name = "comboDisaster";
            this.comboDisaster.Size = new System.Drawing.Size(233, 29);
            this.comboDisaster.TabIndex = 13;
            this.comboDisaster.UseSelectable = true;
            this.comboDisaster.Visible = false;
            this.comboDisaster.SelectionChangeCommitted += new System.EventHandler(this.comboDisaster_SelectionChangeCommitted);
            // 
            // radioTypeFamHead
            // 
            this.radioTypeFamHead.AutoSize = true;
            this.radioTypeFamHead.Location = new System.Drawing.Point(42, 165);
            this.radioTypeFamHead.Name = "radioTypeFamHead";
            this.radioTypeFamHead.Size = new System.Drawing.Size(186, 15);
            this.radioTypeFamHead.TabIndex = 4;
            this.radioTypeFamHead.Text = "Filter by Type and Family Head";
            this.radioTypeFamHead.UseSelectable = true;
            this.radioTypeFamHead.CheckedChanged += new System.EventHandler(this.radioTypeFamHead_CheckedChanged);
            // 
            // radioTypeDate
            // 
            this.radioTypeDate.AutoSize = true;
            this.radioTypeDate.Location = new System.Drawing.Point(42, 131);
            this.radioTypeDate.Name = "radioTypeDate";
            this.radioTypeDate.Size = new System.Drawing.Size(144, 15);
            this.radioTypeDate.TabIndex = 3;
            this.radioTypeDate.Text = "Filter by Type and Date";
            this.radioTypeDate.UseSelectable = true;
            this.radioTypeDate.CheckedChanged += new System.EventHandler(this.radioTypeDate_CheckedChanged);
            // 
            // radioDate
            // 
            this.radioDate.AutoSize = true;
            this.radioDate.Location = new System.Drawing.Point(42, 95);
            this.radioDate.Name = "radioDate";
            this.radioDate.Size = new System.Drawing.Size(92, 15);
            this.radioDate.TabIndex = 2;
            this.radioDate.Text = "Filter by Date";
            this.radioDate.UseSelectable = true;
            this.radioDate.CheckedChanged += new System.EventHandler(this.radioDate_CheckedChanged);
            // 
            // radioType
            // 
            this.radioType.AutoSize = true;
            this.radioType.Location = new System.Drawing.Point(42, 60);
            this.radioType.Name = "radioType";
            this.radioType.Size = new System.Drawing.Size(94, 15);
            this.radioType.TabIndex = 1;
            this.radioType.Text = "Filter by Type";
            this.radioType.UseSelectable = true;
            this.radioType.CheckedChanged += new System.EventHandler(this.radioType_CheckedChanged);
            // 
            // radioViewAll
            // 
            this.radioViewAll.AutoSize = true;
            this.radioViewAll.Location = new System.Drawing.Point(42, 25);
            this.radioViewAll.Name = "radioViewAll";
            this.radioViewAll.Size = new System.Drawing.Size(65, 15);
            this.radioViewAll.TabIndex = 0;
            this.radioViewAll.Text = "View All";
            this.radioViewAll.UseSelectable = true;
            this.radioViewAll.CheckedChanged += new System.EventHandler(this.radioViewAll_CheckedChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.casualtiesDGV);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.damagesDGV);
            this.splitContainer2.Size = new System.Drawing.Size(880, 251);
            this.splitContainer2.SplitterDistance = 438;
            this.splitContainer2.TabIndex = 0;
            // 
            // casualtiesDGV
            // 
            this.casualtiesDGV.AllowUserToAddRows = false;
            this.casualtiesDGV.AllowUserToDeleteRows = false;
            this.casualtiesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.casualtiesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.casualtiesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.casualtiesDGV.Location = new System.Drawing.Point(0, 0);
            this.casualtiesDGV.Name = "casualtiesDGV";
            this.casualtiesDGV.ReadOnly = true;
            this.casualtiesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.casualtiesDGV.Size = new System.Drawing.Size(438, 251);
            this.casualtiesDGV.TabIndex = 0;
            // 
            // damagesDGV
            // 
            this.damagesDGV.AllowUserToAddRows = false;
            this.damagesDGV.AllowUserToDeleteRows = false;
            this.damagesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.damagesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.damagesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.damagesDGV.Location = new System.Drawing.Point(0, 0);
            this.damagesDGV.Name = "damagesDGV";
            this.damagesDGV.ReadOnly = true;
            this.damagesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.damagesDGV.Size = new System.Drawing.Size(438, 251);
            this.damagesDGV.TabIndex = 0;
            // 
            // viewFamilyHead
            // 
            this.viewFamilyHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewFamilyHead.Image = null;
            this.viewFamilyHead.Location = new System.Drawing.Point(529, 151);
            this.viewFamilyHead.Name = "viewFamilyHead";
            this.viewFamilyHead.Size = new System.Drawing.Size(86, 29);
            this.viewFamilyHead.TabIndex = 22;
            this.viewFamilyHead.Text = "View";
            this.viewFamilyHead.UseSelectable = true;
            this.viewFamilyHead.UseVisualStyleBackColor = true;
            this.viewFamilyHead.Visible = false;
            this.viewFamilyHead.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // CasualtiesAndDamagesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 542);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CasualtiesAndDamagesView";
            this.Text = "View Casualties and Damages";
            this.Load += new System.EventHandler(this.CasualtiesAndDamagesView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.casualtiesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damagesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView casualtiesDGV;
        private System.Windows.Forms.DataGridView damagesDGV;
        private MetroFramework.Controls.MetroRadioButton radioTypeFamHead;
        private MetroFramework.Controls.MetroRadioButton radioTypeDate;
        private MetroFramework.Controls.MetroRadioButton radioDate;
        private MetroFramework.Controls.MetroRadioButton radioType;
        private MetroFramework.Controls.MetroRadioButton radioViewAll;
        private MetroFramework.Controls.MetroComboBox familyHead;
        private MetroFramework.Controls.MetroLabel to;
        private MetroFramework.Controls.MetroLabel from;
        private MetroFramework.Controls.MetroDateTime filterByDateFrom;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton viewSpecific;
        private MetroFramework.Controls.MetroDateTime filterByDateTo;
        private MetroFramework.Controls.MetroComboBox comboDisaster;
        private MetroFramework.Controls.MetroLabel labelType;
        private MetroFramework.Controls.MetroLabel labelFamilyHead;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton viewFamilyHead;
    }
}