namespace PSAM
{
    partial class DisasterManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisasterManagement));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.disasterCause = new MetroFramework.Controls.MetroTextBox();
            this.disasterDate = new MetroFramework.Controls.MetroDateTime();
            this.disasterType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.detailsPanel = new MetroFramework.Controls.MetroPanel();
            this.editDisasterType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.editDisasterCause = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.editDisasterDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.disastersCombo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.to = new MetroFramework.Controls.MetroLabel();
            this.from = new MetroFramework.Controls.MetroLabel();
            this.filterByDateFrom = new MetroFramework.Controls.MetroDateTime();
            this.viewSpecific = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.filterByDateTo = new MetroFramework.Controls.MetroDateTime();
            this.filterDisasterType = new MetroFramework.Controls.MetroComboBox();
            this.filterByDate = new MetroFramework.Controls.MetroRadioButton();
            this.filterByType = new MetroFramework.Controls.MetroRadioButton();
            this.viewAll = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.disasterGridView = new System.Windows.Forms.DataGridView();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disasterGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(780, 406);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroTile1);
            this.metroTabPage1.Controls.Add(this.disasterCause);
            this.metroTabPage1.Controls.Add(this.disasterDate);
            this.metroTabPage1.Controls.Add(this.disasterType);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(772, 361);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Add Disaster Details";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(522, 225);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(254, 111);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 10;
            this.metroTile1.Text = "Save";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // disasterCause
            // 
            // 
            // 
            // 
            this.disasterCause.CustomButton.Image = null;
            this.disasterCause.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.disasterCause.CustomButton.Name = "";
            this.disasterCause.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.disasterCause.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.disasterCause.CustomButton.TabIndex = 1;
            this.disasterCause.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.disasterCause.CustomButton.UseSelectable = true;
            this.disasterCause.CustomButton.Visible = false;
            this.disasterCause.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.disasterCause.Lines = new string[] {
        " "};
            this.disasterCause.Location = new System.Drawing.Point(303, 143);
            this.disasterCause.MaxLength = 32767;
            this.disasterCause.Name = "disasterCause";
            this.disasterCause.PasswordChar = '\0';
            this.disasterCause.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.disasterCause.SelectedText = "";
            this.disasterCause.SelectionLength = 0;
            this.disasterCause.SelectionStart = 0;
            this.disasterCause.Size = new System.Drawing.Size(281, 29);
            this.disasterCause.TabIndex = 9;
            this.disasterCause.Text = " ";
            this.disasterCause.UseSelectable = true;
            this.disasterCause.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.disasterCause.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // disasterDate
            // 
            this.disasterDate.Location = new System.Drawing.Point(303, 96);
            this.disasterDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.disasterDate.Name = "disasterDate";
            this.disasterDate.Size = new System.Drawing.Size(281, 29);
            this.disasterDate.TabIndex = 8;
            // 
            // disasterType
            // 
            this.disasterType.FormattingEnabled = true;
            this.disasterType.ItemHeight = 23;
            this.disasterType.Items.AddRange(new object[] {
            "Flood or Storm",
            "Earthquake",
            "Landslide",
            "Volcanic",
            "Tsunami",
            "Fire",
            "Accident",
            "Epidemic"});
            this.disasterType.Location = new System.Drawing.Point(303, 48);
            this.disasterType.Name = "disasterType";
            this.disasterType.Size = new System.Drawing.Size(281, 29);
            this.disasterType.TabIndex = 5;
            this.disasterType.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(87, 153);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(107, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Reported Cause:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(87, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Date of Occurence:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(87, 58);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(138, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Disaster/Incident Type:";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.detailsPanel);
            this.metroTabPage2.Controls.Add(this.disastersCombo);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.metroTile3);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(772, 361);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Edit Disaster Details";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.editDisasterType);
            this.detailsPanel.Controls.Add(this.metroLabel6);
            this.detailsPanel.Controls.Add(this.editDisasterCause);
            this.detailsPanel.Controls.Add(this.metroLabel5);
            this.detailsPanel.Controls.Add(this.editDisasterDate);
            this.detailsPanel.Controls.Add(this.metroLabel3);
            this.detailsPanel.HorizontalScrollbarBarColor = true;
            this.detailsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.detailsPanel.HorizontalScrollbarSize = 10;
            this.detailsPanel.Location = new System.Drawing.Point(52, 81);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(551, 153);
            this.detailsPanel.TabIndex = 20;
            this.detailsPanel.VerticalScrollbarBarColor = true;
            this.detailsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.detailsPanel.VerticalScrollbarSize = 10;
            this.detailsPanel.Visible = false;
            // 
            // editDisasterType
            // 
            this.editDisasterType.FormattingEnabled = true;
            this.editDisasterType.ItemHeight = 23;
            this.editDisasterType.Items.AddRange(new object[] {
            "Flood or Storm",
            "Earthquake",
            "Landslide",
            "Volcanic",
            "Tsunami",
            "Fire",
            "Accident",
            "Epidemic"});
            this.editDisasterType.Location = new System.Drawing.Point(260, 17);
            this.editDisasterType.Name = "editDisasterType";
            this.editDisasterType.Size = new System.Drawing.Size(281, 29);
            this.editDisasterType.TabIndex = 14;
            this.editDisasterType.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(42, 27);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(138, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Disaster/Incident Type:";
            // 
            // editDisasterCause
            // 
            // 
            // 
            // 
            this.editDisasterCause.CustomButton.Image = null;
            this.editDisasterCause.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.editDisasterCause.CustomButton.Name = "";
            this.editDisasterCause.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.editDisasterCause.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editDisasterCause.CustomButton.TabIndex = 1;
            this.editDisasterCause.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editDisasterCause.CustomButton.UseSelectable = true;
            this.editDisasterCause.CustomButton.Visible = false;
            this.editDisasterCause.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.editDisasterCause.Lines = new string[] {
        " "};
            this.editDisasterCause.Location = new System.Drawing.Point(260, 112);
            this.editDisasterCause.MaxLength = 32767;
            this.editDisasterCause.Name = "editDisasterCause";
            this.editDisasterCause.PasswordChar = '\0';
            this.editDisasterCause.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.editDisasterCause.SelectedText = "";
            this.editDisasterCause.SelectionLength = 0;
            this.editDisasterCause.SelectionStart = 0;
            this.editDisasterCause.Size = new System.Drawing.Size(281, 29);
            this.editDisasterCause.TabIndex = 16;
            this.editDisasterCause.Text = " ";
            this.editDisasterCause.UseSelectable = true;
            this.editDisasterCause.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editDisasterCause.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(42, 75);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(121, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Date of Occurence:";
            // 
            // editDisasterDate
            // 
            this.editDisasterDate.Location = new System.Drawing.Point(260, 65);
            this.editDisasterDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.editDisasterDate.Name = "editDisasterDate";
            this.editDisasterDate.Size = new System.Drawing.Size(281, 29);
            this.editDisasterDate.TabIndex = 15;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(42, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Reported Cause:";
            // 
            // disastersCombo
            // 
            this.disastersCombo.FormattingEnabled = true;
            this.disastersCombo.ItemHeight = 23;
            this.disastersCombo.Items.AddRange(new object[] {
            "Flood or Storm",
            "Earthquake",
            "Landslide",
            "Volcanic",
            "Tsunami",
            "Fire",
            "Accident",
            "Epidemic"});
            this.disastersCombo.Location = new System.Drawing.Point(312, 46);
            this.disastersCombo.Name = "disastersCombo";
            this.disastersCombo.Size = new System.Drawing.Size(281, 29);
            this.disastersCombo.TabIndex = 19;
            this.disastersCombo.UseSelectable = true;
            this.disastersCombo.SelectedIndexChanged += new System.EventHandler(this.disastersCombo_SelectedIndexChanged);
            this.disastersCombo.SelectionChangeCommitted += new System.EventHandler(this.disastersCombo_SelectionChangeCommitted);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(96, 56);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(96, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Select Disaster:";
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile3.Location = new System.Drawing.Point(591, 240);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(175, 104);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile3.TabIndex = 17;
            this.metroTile3.Text = "Save";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.to);
            this.metroTabPage3.Controls.Add(this.from);
            this.metroTabPage3.Controls.Add(this.filterByDateFrom);
            this.metroTabPage3.Controls.Add(this.viewSpecific);
            this.metroTabPage3.Controls.Add(this.filterByDateTo);
            this.metroTabPage3.Controls.Add(this.filterDisasterType);
            this.metroTabPage3.Controls.Add(this.filterByDate);
            this.metroTabPage3.Controls.Add(this.filterByType);
            this.metroTabPage3.Controls.Add(this.viewAll);
            this.metroTabPage3.Controls.Add(this.metroPanel1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(772, 361);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "View Disaster Details";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(469, 72);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(25, 19);
            this.to.TabIndex = 12;
            this.to.Text = "To:";
            this.to.Visible = false;
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(201, 72);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(44, 19);
            this.from.TabIndex = 11;
            this.from.Text = "From:";
            this.from.Visible = false;
            // 
            // filterByDateFrom
            // 
            this.filterByDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filterByDateFrom.Location = new System.Drawing.Point(259, 63);
            this.filterByDateFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.filterByDateFrom.Name = "filterByDateFrom";
            this.filterByDateFrom.Size = new System.Drawing.Size(175, 29);
            this.filterByDateFrom.TabIndex = 10;
            this.filterByDateFrom.Visible = false;
            // 
            // viewSpecific
            // 
            this.viewSpecific.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewSpecific.Image = null;
            this.viewSpecific.Location = new System.Drawing.Point(683, 63);
            this.viewSpecific.Name = "viewSpecific";
            this.viewSpecific.Size = new System.Drawing.Size(86, 29);
            this.viewSpecific.Style = MetroFramework.MetroColorStyle.Red;
            this.viewSpecific.TabIndex = 9;
            this.viewSpecific.Text = "View";
            this.viewSpecific.UseSelectable = true;
            this.viewSpecific.UseVisualStyleBackColor = true;
            this.viewSpecific.Visible = false;
            this.viewSpecific.Click += new System.EventHandler(this.viewSpecific_Click);
            // 
            // filterByDateTo
            // 
            this.filterByDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filterByDateTo.Location = new System.Drawing.Point(502, 63);
            this.filterByDateTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.filterByDateTo.Name = "filterByDateTo";
            this.filterByDateTo.Size = new System.Drawing.Size(175, 29);
            this.filterByDateTo.TabIndex = 8;
            this.filterByDateTo.Visible = false;
            this.filterByDateTo.ValueChanged += new System.EventHandler(this.filterDisasterDatePicker_ValueChanged);
            // 
            // filterDisasterType
            // 
            this.filterDisasterType.FormattingEnabled = true;
            this.filterDisasterType.ItemHeight = 23;
            this.filterDisasterType.Items.AddRange(new object[] {
            "Flood or Storm",
            "Earthquake",
            "Landslide",
            "Volcanic",
            "Tsunami",
            "Fire",
            "Accident",
            "Epidemic"});
            this.filterDisasterType.Location = new System.Drawing.Point(201, 28);
            this.filterDisasterType.Name = "filterDisasterType";
            this.filterDisasterType.Size = new System.Drawing.Size(233, 29);
            this.filterDisasterType.TabIndex = 6;
            this.filterDisasterType.UseSelectable = true;
            this.filterDisasterType.Visible = false;
            this.filterDisasterType.SelectionChangeCommitted += new System.EventHandler(this.filterDisasterType_SelectionChangeCommitted);
            // 
            // filterByDate
            // 
            this.filterByDate.AutoSize = true;
            this.filterByDate.Location = new System.Drawing.Point(32, 77);
            this.filterByDate.Name = "filterByDate";
            this.filterByDate.Size = new System.Drawing.Size(92, 15);
            this.filterByDate.TabIndex = 5;
            this.filterByDate.Text = "Filter by Date";
            this.filterByDate.UseSelectable = true;
            this.filterByDate.CheckedChanged += new System.EventHandler(this.filterByDate_CheckedChanged);
            // 
            // filterByType
            // 
            this.filterByType.AutoSize = true;
            this.filterByType.Location = new System.Drawing.Point(32, 42);
            this.filterByType.Name = "filterByType";
            this.filterByType.Size = new System.Drawing.Size(93, 15);
            this.filterByType.TabIndex = 4;
            this.filterByType.Text = "Filter by Type";
            this.filterByType.UseSelectable = true;
            this.filterByType.CheckedChanged += new System.EventHandler(this.filterByType_CheckedChanged);
            // 
            // viewAll
            // 
            this.viewAll.AutoSize = true;
            this.viewAll.Location = new System.Drawing.Point(32, 10);
            this.viewAll.Name = "viewAll";
            this.viewAll.Size = new System.Drawing.Size(65, 15);
            this.viewAll.TabIndex = 3;
            this.viewAll.Text = "View All";
            this.viewAll.UseSelectable = true;
            this.viewAll.CheckedChanged += new System.EventHandler(this.viewAll_CheckedChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.disasterGridView);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 107);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(772, 254);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // disasterGridView
            // 
            this.disasterGridView.AllowUserToAddRows = false;
            this.disasterGridView.AllowUserToDeleteRows = false;
            this.disasterGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.disasterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disasterGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disasterGridView.Location = new System.Drawing.Point(0, 0);
            this.disasterGridView.Name = "disasterGridView";
            this.disasterGridView.ReadOnly = true;
            this.disasterGridView.Size = new System.Drawing.Size(772, 254);
            this.disasterGridView.TabIndex = 2;
            // 
            // DisasterManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 486);
            this.Controls.Add(this.metroTabControl1);
            this.MinimizeBox = false;
            this.Name = "DisasterManagement";
            this.Resizable = false;
            this.Text = "Disaster Management";
            this.Load += new System.EventHandler(this.DisasterManagement_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.disasterGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime disasterDate;
        private MetroFramework.Controls.MetroComboBox disasterType;
        private MetroFramework.Controls.MetroTextBox disasterCause;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroComboBox disastersCombo;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTextBox editDisasterCause;
        private MetroFramework.Controls.MetroDateTime editDisasterDate;
        private MetroFramework.Controls.MetroComboBox editDisasterType;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel detailsPanel;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton viewAll;
        private MetroFramework.Controls.MetroRadioButton filterByType;
        private MetroFramework.Controls.MetroRadioButton filterByDate;
        private System.Windows.Forms.DataGridView disasterGridView;
        private MetroFramework.Controls.MetroComboBox filterDisasterType;
        private MetroFramework.Controls.MetroDateTime filterByDateTo;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton viewSpecific;
        private MetroFramework.Controls.MetroLabel to;
        private MetroFramework.Controls.MetroLabel from;
        private MetroFramework.Controls.MetroDateTime filterByDateFrom;
    }
}