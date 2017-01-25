namespace PSAM
{
    partial class ProgramProposal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.totalBudget = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.budgetDGV = new MetroFramework.Controls.MetroGrid();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disasterCombo = new System.Windows.Forms.ComboBox();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.budgetPrice = new MetroFramework.Controls.MetroTextBox();
            this.budgetDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.programTo = new MetroFramework.Controls.MetroDateTime();
            this.programFrom = new MetroFramework.Controls.MetroDateTime();
            this.programDescription = new MetroFramework.Controls.MetroTextBox();
            this.programTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(42, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Program Title:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(228, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Disaster Type and Date of Occurence:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(42, 275);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Start Date:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(42, 168);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(134, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Program Description:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(42, 332);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "End Date:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.Controls.Add(this.totalBudget);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.budgetDGV);
            this.metroPanel1.Controls.Add(this.disasterCombo);
            this.metroPanel1.Controls.Add(this.metroTile3);
            this.metroPanel1.Controls.Add(this.metroTile2);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Controls.Add(this.budgetPrice);
            this.metroPanel1.Controls.Add(this.budgetDescription);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.programTo);
            this.metroPanel1.Controls.Add(this.programFrom);
            this.metroPanel1.Controls.Add(this.programDescription);
            this.metroPanel1.Controls.Add(this.programTitle);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(813, 436);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // totalBudget
            // 
            // 
            // 
            // 
            this.totalBudget.CustomButton.Image = null;
            this.totalBudget.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.totalBudget.CustomButton.Name = "";
            this.totalBudget.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalBudget.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalBudget.CustomButton.TabIndex = 1;
            this.totalBudget.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalBudget.CustomButton.UseSelectable = true;
            this.totalBudget.CustomButton.Visible = false;
            this.totalBudget.Lines = new string[] {
        "0"};
            this.totalBudget.Location = new System.Drawing.Point(578, 601);
            this.totalBudget.MaxLength = 32767;
            this.totalBudget.Name = "totalBudget";
            this.totalBudget.PasswordChar = '\0';
            this.totalBudget.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalBudget.SelectedText = "";
            this.totalBudget.SelectionLength = 0;
            this.totalBudget.SelectionStart = 0;
            this.totalBudget.Size = new System.Drawing.Size(188, 23);
            this.totalBudget.Style = MetroFramework.MetroColorStyle.Green;
            this.totalBudget.TabIndex = 67;
            this.totalBudget.Text = "0";
            this.totalBudget.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalBudget.UseSelectable = true;
            this.totalBudget.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalBudget.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(429, 605);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(143, 19);
            this.metroLabel11.TabIndex = 66;
            this.metroLabel11.Text = "Total Budget Proposal:";
            // 
            // budgetDGV
            // 
            this.budgetDGV.AllowUserToAddRows = false;
            this.budgetDGV.AllowUserToDeleteRows = false;
            this.budgetDGV.AllowUserToResizeRows = false;
            this.budgetDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.budgetDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.budgetDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.budgetDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.budgetDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.budgetDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.budgetDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.budgetDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Budget});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.budgetDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.budgetDGV.EnableHeadersVisualStyles = false;
            this.budgetDGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.budgetDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.budgetDGV.Location = new System.Drawing.Point(429, 461);
            this.budgetDGV.MultiSelect = false;
            this.budgetDGV.Name = "budgetDGV";
            this.budgetDGV.ReadOnly = true;
            this.budgetDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.budgetDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.budgetDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.budgetDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.budgetDGV.Size = new System.Drawing.Size(337, 122);
            this.budgetDGV.Style = MetroFramework.MetroColorStyle.Green;
            this.budgetDGV.TabIndex = 65;
            // 
            // Description
            // 
            this.Description.HeaderText = "DESCRIPTION";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Budget
            // 
            this.Budget.HeaderText = "BUDGET";
            this.Budget.Name = "Budget";
            this.Budget.ReadOnly = true;
            // 
            // disasterCombo
            // 
            this.disasterCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.disasterCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.disasterCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disasterCombo.FormattingEnabled = true;
            this.disasterCombo.Location = new System.Drawing.Point(307, 74);
            this.disasterCombo.Name = "disasterCombo";
            this.disasterCombo.Size = new System.Drawing.Size(459, 29);
            this.disasterCombo.TabIndex = 64;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile3.Location = new System.Drawing.Point(42, 945);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(724, 84);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile3.TabIndex = 63;
            this.metroTile3.Text = "Propose Program";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.Location = new System.Drawing.Point(175, 575);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(108, 53);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 8;
            this.metroTile2.Text = "Add";
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(297, 575);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(108, 53);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 61;
            this.metroTile1.Text = "Clear";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // budgetPrice
            // 
            this.budgetPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.budgetPrice.CustomButton.Image = null;
            this.budgetPrice.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.budgetPrice.CustomButton.Name = "";
            this.budgetPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.budgetPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.budgetPrice.CustomButton.TabIndex = 1;
            this.budgetPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.budgetPrice.CustomButton.UseSelectable = true;
            this.budgetPrice.CustomButton.Visible = false;
            this.budgetPrice.Lines = new string[0];
            this.budgetPrice.Location = new System.Drawing.Point(175, 507);
            this.budgetPrice.MaxLength = 32767;
            this.budgetPrice.Name = "budgetPrice";
            this.budgetPrice.PasswordChar = '\0';
            this.budgetPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.budgetPrice.SelectedText = "";
            this.budgetPrice.SelectionLength = 0;
            this.budgetPrice.SelectionStart = 0;
            this.budgetPrice.Size = new System.Drawing.Size(230, 23);
            this.budgetPrice.Style = MetroFramework.MetroColorStyle.Green;
            this.budgetPrice.TabIndex = 7;
            this.budgetPrice.UseSelectable = true;
            this.budgetPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.budgetPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.budgetPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.budgetPrice_KeyPress);
            // 
            // budgetDescription
            // 
            this.budgetDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.budgetDescription.CustomButton.Image = null;
            this.budgetDescription.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.budgetDescription.CustomButton.Name = "";
            this.budgetDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.budgetDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.budgetDescription.CustomButton.TabIndex = 1;
            this.budgetDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.budgetDescription.CustomButton.UseSelectable = true;
            this.budgetDescription.CustomButton.Visible = false;
            this.budgetDescription.Lines = new string[0];
            this.budgetDescription.Location = new System.Drawing.Point(175, 461);
            this.budgetDescription.MaxLength = 32767;
            this.budgetDescription.Name = "budgetDescription";
            this.budgetDescription.PasswordChar = '\0';
            this.budgetDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.budgetDescription.SelectedText = "";
            this.budgetDescription.SelectionLength = 0;
            this.budgetDescription.SelectionStart = 0;
            this.budgetDescription.Size = new System.Drawing.Size(230, 23);
            this.budgetDescription.Style = MetroFramework.MetroColorStyle.Green;
            this.budgetDescription.TabIndex = 6;
            this.budgetDescription.UseSelectable = true;
            this.budgetDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.budgetDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(42, 511);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(54, 19);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "Budget:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(42, 465);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(77, 19);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "Description:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(106, 1036);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(13, 19);
            this.metroLabel10.TabIndex = 15;
            this.metroLabel10.Text = " ";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(3, 415);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(131, 25);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Budget Details:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(4, 30);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(143, 25);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Program Details:";
            // 
            // programTo
            // 
            this.programTo.Location = new System.Drawing.Point(307, 322);
            this.programTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.programTo.Name = "programTo";
            this.programTo.Size = new System.Drawing.Size(459, 29);
            this.programTo.Style = MetroFramework.MetroColorStyle.Green;
            this.programTo.TabIndex = 5;
            // 
            // programFrom
            // 
            this.programFrom.Location = new System.Drawing.Point(307, 275);
            this.programFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.programFrom.Name = "programFrom";
            this.programFrom.Size = new System.Drawing.Size(459, 29);
            this.programFrom.Style = MetroFramework.MetroColorStyle.Green;
            this.programFrom.TabIndex = 4;
            // 
            // programDescription
            // 
            this.programDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.programDescription.CustomButton.Image = null;
            this.programDescription.CustomButton.Location = new System.Drawing.Point(373, 1);
            this.programDescription.CustomButton.Name = "";
            this.programDescription.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.programDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.programDescription.CustomButton.TabIndex = 1;
            this.programDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.programDescription.CustomButton.UseSelectable = true;
            this.programDescription.CustomButton.Visible = false;
            this.programDescription.Lines = new string[0];
            this.programDescription.Location = new System.Drawing.Point(307, 168);
            this.programDescription.MaxLength = 32767;
            this.programDescription.Multiline = true;
            this.programDescription.Name = "programDescription";
            this.programDescription.PasswordChar = '\0';
            this.programDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.programDescription.SelectedText = "";
            this.programDescription.SelectionLength = 0;
            this.programDescription.SelectionStart = 0;
            this.programDescription.Size = new System.Drawing.Size(459, 87);
            this.programDescription.Style = MetroFramework.MetroColorStyle.Green;
            this.programDescription.TabIndex = 3;
            this.programDescription.UseSelectable = true;
            this.programDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.programDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // programTitle
            // 
            this.programTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.programTitle.CustomButton.Image = null;
            this.programTitle.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.programTitle.CustomButton.Name = "";
            this.programTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.programTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.programTitle.CustomButton.TabIndex = 1;
            this.programTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.programTitle.CustomButton.UseSelectable = true;
            this.programTitle.CustomButton.Visible = false;
            this.programTitle.Lines = new string[0];
            this.programTitle.Location = new System.Drawing.Point(307, 126);
            this.programTitle.MaxLength = 32767;
            this.programTitle.Name = "programTitle";
            this.programTitle.PasswordChar = '\0';
            this.programTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.programTitle.SelectedText = "";
            this.programTitle.SelectionLength = 0;
            this.programTitle.SelectionStart = 0;
            this.programTitle.Size = new System.Drawing.Size(459, 23);
            this.programTitle.Style = MetroFramework.MetroColorStyle.Green;
            this.programTitle.TabIndex = 2;
            this.programTitle.UseSelectable = true;
            this.programTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.programTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProgramProposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 516);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "ProgramProposal";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Program Proposal";
            this.Load += new System.EventHandler(this.ProgramProposal_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox programDescription;
        private MetroFramework.Controls.MetroTextBox programTitle;
        private MetroFramework.Controls.MetroDateTime programTo;
        private MetroFramework.Controls.MetroDateTime programFrom;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox budgetPrice;
        private MetroFramework.Controls.MetroTextBox budgetDescription;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.ComboBox disasterCombo;
        private MetroFramework.Controls.MetroGrid budgetDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Budget;
        private MetroFramework.Controls.MetroTextBox totalBudget;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}