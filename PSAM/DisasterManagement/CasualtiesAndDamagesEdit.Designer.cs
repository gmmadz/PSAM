namespace PSAM
{
    partial class CasualtiesAndDamagesEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.disasterCombo = new System.Windows.Forms.ComboBox();
            this.familyHead = new System.Windows.Forms.ComboBox();
            this.casualtiesDGV = new MetroFramework.Controls.MetroGrid();
            this.injuredButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.missingButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.deadButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.editButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.damages = new MetroFramework.Controls.MetroGrid();
            this.metroTextButton5 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.itemCost = new System.Windows.Forms.TextBox();
            this.damagedItem = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.itemExtent = new System.Windows.Forms.ComboBox();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.casualtiesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damages)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(41, 101);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Disaster :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(41, 150);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Family Head:";
            // 
            // disasterCombo
            // 
            this.disasterCombo.FormattingEnabled = true;
            this.disasterCombo.Location = new System.Drawing.Point(221, 101);
            this.disasterCombo.Name = "disasterCombo";
            this.disasterCombo.Size = new System.Drawing.Size(176, 21);
            this.disasterCombo.TabIndex = 3;
            this.disasterCombo.SelectionChangeCommitted += new System.EventHandler(this.disasterCombo_SelectionChangeCommitted);
            // 
            // familyHead
            // 
            this.familyHead.FormattingEnabled = true;
            this.familyHead.Location = new System.Drawing.Point(221, 150);
            this.familyHead.Name = "familyHead";
            this.familyHead.Size = new System.Drawing.Size(176, 21);
            this.familyHead.TabIndex = 4;
            // 
            // casualtiesDGV
            // 
            this.casualtiesDGV.AllowUserToAddRows = false;
            this.casualtiesDGV.AllowUserToDeleteRows = false;
            this.casualtiesDGV.AllowUserToResizeRows = false;
            this.casualtiesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.casualtiesDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.casualtiesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.casualtiesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.casualtiesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.casualtiesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.casualtiesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.casualtiesDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.casualtiesDGV.EnableHeadersVisualStyles = false;
            this.casualtiesDGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.casualtiesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.casualtiesDGV.Location = new System.Drawing.Point(3, 33);
            this.casualtiesDGV.Name = "casualtiesDGV";
            this.casualtiesDGV.ReadOnly = true;
            this.casualtiesDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.casualtiesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.casualtiesDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.casualtiesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.casualtiesDGV.Size = new System.Drawing.Size(494, 214);
            this.casualtiesDGV.TabIndex = 5;
            // 
            // injuredButton
            // 
            this.injuredButton.Image = null;
            this.injuredButton.Location = new System.Drawing.Point(530, 58);
            this.injuredButton.Name = "injuredButton";
            this.injuredButton.Size = new System.Drawing.Size(397, 42);
            this.injuredButton.TabIndex = 6;
            this.injuredButton.Text = "INJURED";
            this.injuredButton.UseSelectable = true;
            this.injuredButton.UseVisualStyleBackColor = true;
            this.injuredButton.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // missingButton
            // 
            this.missingButton.Image = null;
            this.missingButton.Location = new System.Drawing.Point(530, 117);
            this.missingButton.Name = "missingButton";
            this.missingButton.Size = new System.Drawing.Size(397, 42);
            this.missingButton.TabIndex = 7;
            this.missingButton.Text = "MISSING";
            this.missingButton.UseSelectable = true;
            this.missingButton.UseVisualStyleBackColor = true;
            this.missingButton.Click += new System.EventHandler(this.missingButton_Click);
            // 
            // deadButton
            // 
            this.deadButton.Image = null;
            this.deadButton.Location = new System.Drawing.Point(530, 176);
            this.deadButton.Name = "deadButton";
            this.deadButton.Size = new System.Drawing.Size(397, 42);
            this.deadButton.TabIndex = 8;
            this.deadButton.Text = "DEAD";
            this.deadButton.UseSelectable = true;
            this.deadButton.UseVisualStyleBackColor = true;
            this.deadButton.Click += new System.EventHandler(this.deadButton_Click);
            // 
            // editButton
            // 
            this.editButton.Image = null;
            this.editButton.Location = new System.Drawing.Point(433, 148);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "EDIT";
            this.editButton.UseSelectable = true;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.metroTextButton4_Click);
            // 
            // damages
            // 
            this.damages.AllowUserToAddRows = false;
            this.damages.AllowUserToDeleteRows = false;
            this.damages.AllowUserToResizeRows = false;
            this.damages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.damages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.damages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.damages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.damages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.damages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.damages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.damages.DefaultCellStyle = dataGridViewCellStyle5;
            this.damages.EnableHeadersVisualStyles = false;
            this.damages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.damages.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.damages.Location = new System.Drawing.Point(493, 49);
            this.damages.MultiSelect = false;
            this.damages.Name = "damages";
            this.damages.ReadOnly = true;
            this.damages.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.damages.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.damages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.damages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.damages.Size = new System.Drawing.Size(434, 185);
            this.damages.Style = MetroFramework.MetroColorStyle.Teal;
            this.damages.TabIndex = 38;
            this.damages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.damages_CellContentClick);
            // 
            // metroTextButton5
            // 
            this.metroTextButton5.Image = null;
            this.metroTextButton5.Location = new System.Drawing.Point(199, 194);
            this.metroTextButton5.Name = "metroTextButton5";
            this.metroTextButton5.Size = new System.Drawing.Size(264, 40);
            this.metroTextButton5.TabIndex = 46;
            this.metroTextButton5.Text = "Update";
            this.metroTextButton5.UseSelectable = true;
            this.metroTextButton5.UseVisualStyleBackColor = true;
            this.metroTextButton5.Click += new System.EventHandler(this.metroTextButton5_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(493, 27);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(160, 19);
            this.metroLabel4.TabIndex = 37;
            this.metroLabel4.Text = "Tap the row below to edit";
            // 
            // itemCost
            // 
            this.itemCost.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCost.Location = new System.Drawing.Point(199, 146);
            this.itemCost.Name = "itemCost";
            this.itemCost.Size = new System.Drawing.Size(264, 33);
            this.itemCost.TabIndex = 44;
            // 
            // damagedItem
            // 
            this.damagedItem.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damagedItem.Location = new System.Drawing.Point(199, 51);
            this.damagedItem.Name = "damagedItem";
            this.damagedItem.Size = new System.Drawing.Size(264, 33);
            this.damagedItem.TabIndex = 45;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(19, 59);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(135, 25);
            this.metroLabel6.TabIndex = 39;
            this.metroLabel6.Text = "Damaged Item:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(19, 154);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(135, 25);
            this.metroLabel8.TabIndex = 43;
            this.metroLabel8.Text = "Estimated Cost:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(19, 106);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(158, 25);
            this.metroLabel7.TabIndex = 41;
            this.metroLabel7.Text = "Extent of Damage:";
            // 
            // itemExtent
            // 
            this.itemExtent.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemExtent.FormattingEnabled = true;
            this.itemExtent.Items.AddRange(new object[] {
            "Totally Damaged",
            "Partially Damaged"});
            this.itemExtent.Location = new System.Drawing.Point(199, 98);
            this.itemExtent.Name = "itemExtent";
            this.itemExtent.Size = new System.Drawing.Size(264, 33);
            this.itemExtent.TabIndex = 42;
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(724, 91);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(162, 80);
            this.metroTextButton1.TabIndex = 47;
            this.metroTextButton1.Text = "SAVE";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click_1);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(41, 218);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(938, 302);
            this.metroTabControl1.TabIndex = 48;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroTextButton5);
            this.metroTabPage1.Controls.Add(this.damagedItem);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.damages);
            this.metroTabPage1.Controls.Add(this.itemCost);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.itemExtent);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(930, 260);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "DAMAGES";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.casualtiesDGV);
            this.metroTabPage2.Controls.Add(this.injuredButton);
            this.metroTabPage2.Controls.Add(this.deadButton);
            this.metroTabPage2.Controls.Add(this.missingButton);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(930, 260);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "CASUALTIES";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // CasualtiesAndDamagesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 543);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroTextButton1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.familyHead);
            this.Controls.Add(this.disasterCombo);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Name = "CasualtiesAndDamagesEdit";
            this.Text = "Manage Casualties and Damages";
            this.Load += new System.EventHandler(this.CasualtiesAndDamagesEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casualtiesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damages)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox disasterCombo;
        private System.Windows.Forms.ComboBox familyHead;
        private MetroFramework.Controls.MetroGrid casualtiesDGV;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton injuredButton;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton missingButton;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton deadButton;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton editButton;
        private MetroFramework.Controls.MetroGrid damages;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox itemCost;
        private System.Windows.Forms.TextBox damagedItem;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.ComboBox itemExtent;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
    }
}