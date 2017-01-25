using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAM
{
    public partial class ProgramManagement : MetroForm
    {
        public ProgramManagement()
        {
            InitializeComponent();
        }
        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING
        
        
        
        //**************************LOAD DATAGRIDVIEW**************************
        private void loadDataGridView(string query, DataGridView gridview)
        {

            gridview.DataSource = null;
            gridview.Refresh();
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            gridview.DataSource = dt;
        }
        //**************************LOAD PROGRAM**************************
        private void loadProgram(ComboBox combo)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string program = "SELECT program.programID, CONCAT(program.programTitle,': ',  disaster.disasterType, '(',disaster.disasterDate, ')') AS program, program.programTitle FROM program, disaster WHERE program.disasterID = disaster.disasterID AND program.status = 'Pending'";
            MySqlCommand mycommand = new MySqlCommand(program, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            combo.DataSource = dt;
            combo.DisplayMember = "program";
            combo.ValueMember = "programID";
        }

        //**************************LOAD APROGRAM**************************
        private void loadAProgram()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string program = "SELECT program.programID, CONCAT(program.programTitle,' / ',  disaster.disasterType, ' / ',disaster.disasterDate) AS program, program.programTitle FROM program, disaster WHERE program.disasterID = disaster.disasterID AND program.status = 'Approved'";
            MySqlCommand mycommand = new MySqlCommand(program, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            approvedPrograms.DataSource = dt;
            approvedPrograms.DisplayMember = "program";
            approvedPrograms.ValueMember = "programID";
        }


        //**************************LOAD DISASTER**************************
        private void loadDisaster(ComboBox combo)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string disaster = "SELECT disasterID, CONCAT(disasterType, ': ', DATE_FORMAT(disasterDate,'%b %d %Y')) as disasterName FROM disaster";
            MySqlCommand mycommand = new MySqlCommand(disaster, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            combo.DataSource = dt;
            combo.DisplayMember = "disasterName";
            combo.ValueMember = "disasterID";
        }
        //**************************LOAD APPROVE**************************
        private void loadApproveProgram()
        {
            string query = "SELECT  CONCAT(disaster.disasterType, ': ', DATE_FORMAT(disaster.disasterDate,'%b %d %Y')) as disasterName, program.programTitle, program.programDescription, CONCAT(program.startTimeFrame, ' to ', program.endTimeFrame) AS TimeFrame, program.dateProposed, program.status, " +
                                        " FORMAT(SUM(budget.budget),2) AS Total_Budget, program.programID " +
                                         " FROM program, disaster, budget " +
                                         " WHERE program.disasterID = disaster.disasterID AND program.programID = budget.programID AND program.status = 'Pending' GROUP BY program.programID";

            loadDataGridView(query, approveProgDGV);
        }

        //**************************GET RESULT QUERY**************************
        private string getResultQuery(string query)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            MySqlDataAdapter da = new MySqlDataAdapter(query, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return "";
            }
            else
            {
                return dt.Rows[0][0] + "";
            }

        }

        private void loadFinProg()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string query = " SELECT  program.programID,CONCAT(program.programTitle, ': ', disaster.disasterType, ': ', DATE_FORMAT(disaster.disasterDate,'%b %d %Y')) as disasterName, program.programDescription, CONCAT(program.startTimeFrame, ' to ', program.endTimeFrame) AS TimeFrame, program.dateProposed, program.status, " +
                            " FORMAT(SUM(budget.budget),2) AS Total_Budget " +
                            " FROM program, disaster, budget " +
                            " WHERE program.disasterID = disaster.disasterID AND program.programID = budget.programID AND program.status = 'Approved' GROUP BY program.programID";
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            programfinished.DataSource = dt;
            programfinished.DisplayMember = "disasterName";
            programfinished.ValueMember = "programID";
        }
        //**************************PAGE LOAD**************************
        private void ProgramProposalEdit_Load(object sender, EventArgs e)
        {
            loadProgram(programCombo);
            loadProgram(viewProgTitle);
            loadApproveProgram();
            loadAProgram(); //used for expenses
            totalExpenses.Text = "0";
            expensePrice.Text = "0";
            quantity.Text = "0";

            loadFinProg();



            
        }

        //**************************VIEW ALL**************************
        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            viewProgramDGV.DataSource = null;
            viewProgramDGV.DataSource = null;
            if (metroRadioButton1.Checked == true)
            {
                string queryViewAll = "SELECT  CONCAT(disaster.disasterType, ': ', DATE_FORMAT(disaster.disasterDate,'%b %d %Y')) as disasterName, program.programTitle, program.programDescription, CONCAT(program.startTimeFrame, ' to ', program.endTimeFrame) AS TimeFrame, program.dateProposed, program.status, " +
                                        " FORMAT(SUM(budget.budget),2) AS Total_Budget " +
                                        " FROM program, disaster, budget " +
                                        " WHERE program.disasterID = disaster.disasterID AND program.programID = budget.programID " +
                                        " GROUP BY program.programID";
                loadDataGridView(queryViewAll, viewProgramDGV);

                viewProgTitle.Visible = false;

                statusCombo.Visible = false;

                to.Visible = false;
                from.Visible = false;
                labelEnd.Visible = false;
                labelStart.Visible = false;
                viewDateButton.Visible = false;

                disasterType.Visible = false;

                

            }
        }

        //**************************VIEW BY STATUS**************************

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            viewProgramDGV.DataSource = null;
            viewProgramDGV.DataSource = null;
            if (metroRadioButton2.Checked == true)
            {
                viewProgTitle.Visible = false;

                statusCombo.Visible = true;

                to.Visible = false;
                from.Visible = false;
                labelEnd.Visible = false;
                labelStart.Visible = false;
                viewDateButton.Visible = false;

                disasterType.Visible = false;
            }
        }

        //**************************VIEW BY DATE*************************
        private void metroRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            viewProgramDGV.DataSource = null;
            viewProgramDGV.DataSource = null;
            if (metroRadioButton4.Checked == true)
            {
                viewProgTitle.Visible = false;

                statusCombo.Visible = false;

                to.Visible = true;
                from.Visible = true;
                labelEnd.Visible = true;
                labelStart.Visible = true;
                viewDateButton.Visible = true;

                disasterType.Visible = false;
            }
        }

        private void viewDateButton_Click(object sender, EventArgs e)
        {

            DateTime startDate = from.Value.Date;
            DateTime endDate = to.Value.Date;

            string sstartDate = String.Format("{0:yyyy-MM-dd}", startDate);
            string eendDate = String.Format("{0:yyyy-MM-dd}", endDate);

            if (startDate > endDate)
            {
                MetroMessageBox.Show(this, "End Date is later than Start Date!", "Invalid Time Frame!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "SELECT  CONCAT(disaster.disasterType, ': ', DATE_FORMAT(disaster.disasterDate,'%b %d %Y')) as disasterName, program.programTitle, program.programDescription, CONCAT(program.startTimeFrame, ' to ', program.endTimeFrame) AS TimeFrame, program.dateProposed, program.status, " +
                                "FORMAT(SUM(budget.budget),2) AS Total_Budget " +
                                "FROM program, disaster, budget " +
                                "WHERE program.disasterID = disaster.disasterID AND program.programID = budget.programID AND program.dateProposed BETWEEN '" + from.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + to.Value.Date.ToString("yyyy-MM-dd") + "' " +
                                "GROUP BY program.programID";
                loadDataGridView(query, viewProgramDGV);
            }
            
        }
        //**************************VIEW BY DISASTER TYPE*************************
        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            viewProgramDGV.DataSource = null;
            viewProgramDGV.DataSource = null;
            if (metroRadioButton3.Checked == true)
            {
                viewProgTitle.Visible = false;

                statusCombo.Visible = false;

                to.Visible = false;
                from.Visible = false;
                labelEnd.Visible = false;
                labelStart.Visible = false;
                viewDateButton.Visible = false;

                disasterType.Visible = true;
            }
        }

        private void disasterType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string query = "SELECT  CONCAT(disaster.disasterType, ': ', DATE_FORMAT(disaster.disasterDate,'%b %d %Y')) as disasterName, program.programTitle, program.programDescription, CONCAT(program.startTimeFrame, ' to ', program.endTimeFrame) AS TimeFrame, program.dateProposed, program.status,  FORMAT(SUM(budget.budget),2) AS Total_Budget  " +
                         "FROM program, disaster, budget " +
                         "WHERE program.disasterID = disaster.disasterID AND program.programID = budget.programID AND disaster.disasterType = '"+disasterType.SelectedItem.ToString()+"' " +
                         "GROUP BY program.programID";
            loadDataGridView(query, viewProgramDGV);
        }



        //**************************VIEW BY PROGRAM TITLE*************************
        private void metroRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            viewProgramDGV.DataSource = null;
            viewProgramDGV.DataSource = null;
            if (metroRadioButton5.Checked == true)
            {
                viewProgTitle.Visible = true;

                statusCombo.Visible = false;

                to.Visible = false;
                from.Visible = false;
                labelEnd.Visible = false;
                labelStart.Visible = false;
                viewDateButton.Visible = false;

                disasterType.Visible = false;
            }
        }

        private void viewProgTitle_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)viewProgTitle.SelectedItem;
            string prog = drv["programTitle"].ToString();
            string query = "SELECT  CONCAT(disaster.disasterType, ': ', DATE_FORMAT(disaster.disasterDate,'%b %d %Y')) as disasterName, program.programTitle, program.programDescription, CONCAT(program.startTimeFrame, ' to ', program.endTimeFrame) AS TimeFrame, program.dateProposed, program.status,  FORMAT(SUM(budget.budget),2) AS Total_Budget  " +
                         "FROM program, disaster, budget " +
                         "WHERE program.disasterID = disaster.disasterID AND program.programID = budget.programID AND program.programTitle = '" + prog + "' " +
                         "GROUP BY program.programID";
            loadDataGridView(query, viewProgramDGV);
        }



        //**************************LOAD EDIT*************************
        private void metroTile1_Click(object sender, EventArgs e)
        {
            panelProgram.Visible = true;
            pandelBudget.Visible = true;
            updateButton.Visible = true;
            
            DataRowView drv = (DataRowView)programCombo.SelectedItem;
            string prog = drv["programID"].ToString();
            MySqlConnection myconn = new MySqlConnection(connString);
            string loadProgram = "SELECT program.programTitle, program.programDescription, program.startTimeFrame, program.endTimeFrame " +  
                             "FROM program, disaster, budget " +
                             "WHERE program.disasterID = disaster.disasterID AND program.programID  = '"+prog+"' " +
                             "GROUP BY program.programID";
            MySqlDataAdapter da = new MySqlDataAdapter(loadProgram, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {


            }
            else
            {
                programTitle.Text = dt.Rows[0][0] + "";
                programDescription.Text = dt.Rows[0][1] + "";
                programFrom.Text = dt.Rows[0][2] + "";
                programTo.Text = dt.Rows[0][3] + "";
                string budgetQuery = "SELECT budget.description AS DESCRIPTION, budget.budget AS BUDGET, budget.budgetID FROM budget, program WHERE program.programID = budget.programID AND program.programID = '"+prog+"' ";
                loadDataGridView(budgetQuery, budgetDGV);
                budgetDGV.Columns["budgetID"].Visible = false;
                double result = 0;
                foreach (DataGridViewRow row in budgetDGV.Rows)
                {
                    result += Convert.ToDouble(row.Cells["budget"].Value);
                }

                totalBudget.Text = Convert.ToDecimal(result).ToString("#,##0.00");
            }
        }
        //**************************UPDATE EVERYTHING**************************
        private void updateButton_Click(object sender, EventArgs e)
        {
            
            DateTime startDate = programFrom.Value.Date;
            DateTime endDate = programTo.Value.Date;

            if (programTitle.Text == "" || programDescription.Text == "")
            {
                MetroMessageBox.Show(this, "Please fill up the empty fields!", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (startDate > endDate)
            {
                MetroMessageBox.Show(this, "End Date is later than Start Date!", "Invalid Time Frame!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MetroMessageBox.Show(this, "Are you sure you want to update everything?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataRowView drv = (DataRowView)programCombo.SelectedItem;
                    string prog = drv["programID"].ToString();
                    string query = "UPDATE program SET programTitle = '" + programTitle.Text + "', programDescription = '" + programDescription.Text + "' WHERE programID = '" + prog + "'";

                    MySqlConnection myconn = new MySqlConnection(connString);
                    MySqlCommand update = new MySqlCommand(query, myconn);
                    MySqlDataReader rdr;
                    myconn.Open();
                    rdr = update.ExecuteReader();
                    myconn.Close();
                    MetroMessageBox.Show(this, "You have successfully updated the program details!", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelProgram.Visible = false;
                    pandelBudget.Visible = false;
                    updateButton.Visible = false;
                }
            }

        }

        private void budgetPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            char key = e.KeyChar;
            if (!char.IsDigit(key) && char.IsLetter(key))
            {
                e.KeyChar = '\0';
            }
        }
        //**************************ADD BUDGET LISTBOX**************************
        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (budgetDescription.Text == "" || budgetPrice.Text == "")
            {
                MetroMessageBox.Show(this, "Please fill up the empty fields!", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {

                bool found = false;
                foreach (DataGridViewRow row in budgetDGV.Rows)
                {
                    if (row.Cells[0].Value.ToString() == budgetDescription.Text.ToString())
                    {
                        found = true;
                        MetroMessageBox.Show(this, "Item '" + budgetDescription.Text + "' already exists!", "Already Exists!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                if (!found)
                {
                    string desc = budgetDescription.Text;
                    string price = budgetPrice.Text;
                    

                    DataRowView drv = (DataRowView)programCombo.SelectedItem;
                    string prog = drv["programID"].ToString();
                    MySqlConnection connectMe = new MySqlConnection(connString);
                    connectMe.Open();
                    MySqlCommand insertBudgets = connectMe.CreateCommand();
                    insertBudgets.CommandText = "INSERT INTO budget(programID, dateAdded, description, budget) VALUES (@programID, @dateAdded, @description, @budget)";
                    insertBudgets.Parameters.AddWithValue("@programID", prog);
                    insertBudgets.Parameters.AddWithValue("@dateAdded", DateTime.Now);
                    insertBudgets.Parameters.AddWithValue("@description", desc);
                    insertBudgets.Parameters.AddWithValue("@budget", price);
                    insertBudgets.ExecuteNonQuery();
                    connectMe.Close();
                    string budgetQuery = "SELECT budget.description AS DESCRIPTION, budget.budget AS BUDGET, budget.budgetID FROM budget, program WHERE program.programID = budget.programID AND program.programID = '" + prog + "' ";
                    loadDataGridView(budgetQuery, budgetDGV);
                    budgetDGV.Columns["budgetID"].Visible = false;

                    double result = 0;
                    foreach (DataGridViewRow row in budgetDGV.Rows)
                    {
                        result += Convert.ToDouble(row.Cells["budget"].Value);
                    }

                    totalBudget.Text = Convert.ToDecimal(result).ToString("#,##0.00");
                    budgetDescription.Text = "";
                    budgetPrice.Text = "";
                }


            }
        }

        //**************************UPDATE BUDGET LISTBOX**************************
        private void budgetDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = budgetDGV.Rows[i];
            budgetDescription.Text = row.Cells[0].Value.ToString();
            budgetPrice.Text = row.Cells[1].Value.ToString();
            budgetLabel.Text = row.Cells[2].Value.ToString();
        }
        private void updateBudget(string id)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            string query = "UPDATE budget SET description = '"+budgetDescription.Text+"', budget = '"+budgetPrice.Text+"' WHERE budget.budgetID = '"+id+"'";
            MySqlCommand update = new MySqlCommand(query, myconn);
            MySqlDataReader rdr;
            myconn.Open();
            rdr = update.ExecuteReader();
            myconn.Close();
        }
        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (budgetDescription.Text == "" || budgetPrice.Text == "")
            {
                MetroMessageBox.Show(this, "Please fill up the empty fields!", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {

                bool found = false;
                foreach (DataGridViewRow row in budgetDGV.Rows)
                {
                    if (row.Cells[0].Value.ToString() == budgetDescription.Text.ToString() && row.Cells[1].Value.ToString() == budgetPrice.Text.ToString())
                    {
                        found = true;
                        MetroMessageBox.Show(this, "Item '" + budgetDescription.Text + "' already exists!", "Already Exists!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                if (!found)
                {

                    if (MetroMessageBox.Show(this, "Are you sure you want to update the budget detail?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string desc = budgetDescription.Text;
                        string price = budgetPrice.Text;


                        DataRowView drv = (DataRowView)programCombo.SelectedItem;
                        string prog = drv["programID"].ToString();
                        updateBudget(budgetLabel.Text);
                        string budgetQuery = "SELECT budget.description AS DESCRIPTION, budget.budget AS BUDGET, budget.budgetID FROM budget, program WHERE program.programID = budget.programID AND program.programID = '" + prog + "' ";
                        loadDataGridView(budgetQuery, budgetDGV);
                        budgetDGV.Columns["budgetID"].Visible = false;

                        double result = 0;
                        foreach (DataGridViewRow row in budgetDGV.Rows)
                        {
                            result += Convert.ToDouble(row.Cells["budget"].Value);
                        }

                        totalBudget.Text = Convert.ToDecimal(result).ToString("#,##0.00");
                        budgetDescription.Text = "";
                        budgetPrice.Text = "";
                        MetroMessageBox.Show(this, "You have successfully updated the budget!", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        
                        budgetLabel.Text = "";
                        budgetDescription.Text = "";
                        budgetPrice.Text = "";
                    }
                    
                }
            }
        }

        //**************************DELETE BUDGET LISTBOX**************************
    
        private void metroTile3_Click_1(object sender, EventArgs e)
        {
            

            if (budgetDescription.Text == "" || budgetPrice.Text == "")
            {
                MetroMessageBox.Show(this, "Select a row you want to delete!", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                if (MetroMessageBox.Show(this, "Are you sure you want to delete the budget detail?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataRowView drv = (DataRowView)programCombo.SelectedItem;
                    string prog = drv["programID"].ToString();
                    MySqlConnection myconn = new MySqlConnection(connString);
                    string query = "DELETE FROM budget WHERE budget.budgetID = '" + budgetLabel.Text + "'";
                    MySqlCommand delete = new MySqlCommand(query, myconn);
                    MySqlDataReader rdr;
                    myconn.Open();
                    rdr = delete.ExecuteReader();
                    myconn.Close();

                    string budgetQuery = "SELECT budget.description AS DESCRIPTION, budget.budget AS BUDGET, budget.budgetID FROM budget, program WHERE program.programID = budget.programID AND program.programID = '" + prog + "' ";
                    loadDataGridView(budgetQuery, budgetDGV);
                    budgetDGV.Columns["budgetID"].Visible = false;

                    double result = 0;
                    foreach (DataGridViewRow row in budgetDGV.Rows)
                    {
                        result += Convert.ToDouble(row.Cells["budget"].Value);
                    }

                    totalBudget.Text = Convert.ToDecimal(result).ToString("#,##0.00");
                    budgetDescription.Text = "";
                    budgetPrice.Text = "";
                    MetroMessageBox.Show(this, "You have successfully deleted the budget!", "Delete Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadProgram(programCombo);
                    loadProgram(viewProgTitle);
                    budgetLabel.Text = "";
                    budgetDescription.Text = "";
                    budgetPrice.Text = "";
                    loadAProgram(); 
                }
            }

        }
        //**************************APPROVE PROGRAM**************************
        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            if (cancelProgTitle.Text == "" && cancelProgDesc.Text == "" && cancelStartDate.Text == "" && cancelEnd.Text == "" && cancelBudget.Text == "")
            {
                MetroMessageBox.Show(this, "Select a row you want to Approve!", "No Program Selected", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                if (MetroMessageBox.Show(this, "Are you sure you want to approve the Program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection myconn = new MySqlConnection(connString);
                    string query = "UPDATE program SET status = 'Approved' WHERE programID = '"+labelProgramID.Text+"'";
                    MySqlCommand approve = new MySqlCommand(query, myconn);
                    MySqlDataReader rdr;
                    myconn.Open();
                    rdr = approve.ExecuteReader();
                    myconn.Close();
                    MetroMessageBox.Show(this, "You have successfully Approved the Program!", "Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadApproveProgram();
                    cancelProgTitle.Text = ""; 
                    cancelProgDesc.Text = "";
                    cancelStartDate.Text = "";
                    cancelEnd.Text = "";
                    cancelBudget.Text = "";
                    loadProgram(programCombo);
                    loadProgram(viewProgTitle);
                    loadAProgram(); loadFinProg();
                }
            }

        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void approveProgDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = approveProgDGV.Rows[i];

            cancelProgTitle.Text = row.Cells[0].Value.ToString();
            cancelProgDesc.Text = row.Cells[2].Value.ToString();
            cancelStartDate.Text = row.Cells[1].Value.ToString();
            cancelEnd.Text = row.Cells[3].Value.ToString();
            cancelBudget.Text = row.Cells[6].Value.ToString();
            labelProgramID.Text = row.Cells[7].Value.ToString();
        }

        private void statusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = "";
            if (statusCombo.SelectedIndex == 0)
            {
                status = "Pending";
            }
            else if (statusCombo.SelectedIndex == 1)
            {
                status = "Cancelled";
            }
            else if (statusCombo.SelectedIndex == 2)
            {
                status = "Approved";
            }
            else
            {
                status = "Finished";
            }



            string query = " SELECT  CONCAT(disaster.disasterType, ': ', DATE_FORMAT(disaster.disasterDate,'%b %d %Y')) as disasterName, program.programTitle, program.programDescription, CONCAT(program.startTimeFrame, ' to ', program.endTimeFrame) AS TimeFrame, program.dateProposed, program.status, " +
                             " FORMAT(SUM(budget.budget),2) AS Total_Budget " +
                             " FROM program, disaster, budget " +
                             " WHERE program.disasterID = disaster.disasterID AND program.programID = budget.programID AND program.status = '" + status + "' GROUP BY program.programID";

            loadDataGridView(query, viewProgramDGV);
        }
        //**************************CANCEL PROGRAM**************************
        private void metroTile5_Click(object sender, EventArgs e)
        {
            if (cancelProgTitle.Text == "" && cancelProgDesc.Text == "" && cancelStartDate.Text == "" && cancelEnd.Text == "" && cancelBudget.Text == "")
            {
                MetroMessageBox.Show(this, "Select a row you want to Cancel!", "No Program Selected", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                if (MetroMessageBox.Show(this, "Are you sure you want to Cancel the Program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection myconn = new MySqlConnection(connString);
                    string query = "UPDATE program SET status = 'Cancelled' WHERE programID = '" + labelProgramID.Text + "'";
                    MySqlCommand approve = new MySqlCommand(query, myconn);
                    MySqlDataReader rdr;
                    myconn.Open();
                    rdr = approve.ExecuteReader();
                    myconn.Close();
                    MetroMessageBox.Show(this, "You have successfully Cancelled the Program!", "Cancelled Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadApproveProgram();
                    cancelProgTitle.Text = "";
                    cancelProgDesc.Text = "";
                    cancelStartDate.Text = "";
                    cancelEnd.Text = "";
                    cancelBudget.Text = "";
                    loadProgram(programCombo);
                    loadProgram(viewProgTitle);
                }
            }
        }
        //**************************LOAD APPROVE PROGRAM FOR EXPENSES**************************

        private void metroTile9_Click(object sender, EventArgs e)
        {

            try
            {
                totalBudgetTB.Text = " 0.00";
                totalExpensesTB.Text = "0.00";
                remainingBalance.Text = "0.00";
                DataRowView drv = (DataRowView)approvedPrograms.SelectedItem;
                string prog = drv["programID"].ToString();
                MySqlConnection myconn = new MySqlConnection(connString);
                string loadProgram = "SELECT program.programTitle, program.programDescription, CONCAT(program.startTimeFrame, ' to ', program.endTimeFrame) AS TimeFrame, FORMAT(SUM(budget.budget),2) AS Total_Budget " +
                                 "FROM program, disaster, budget " +
                                 "WHERE program.disasterID = disaster.disasterID AND program.programID = budget.programID AND program.programID  = '" + prog + "' " +
                                 "GROUP BY program.programID";
                MySqlDataAdapter da = new MySqlDataAdapter(loadProgram, myconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {


                }
                else
                {
                    peProgTitle.Text = dt.Rows[0][0] + "";
                    peProgDesc.Text = dt.Rows[0][1] + "";
                    peProgTime.Text = dt.Rows[0][2] + "";
                    peProgBudget.Text = dt.Rows[0][3] + "";
                    totalBudgetTB.Text = dt.Rows[0][3] + "";


                    //LOAD PREVIOUS EXPENSES
                    string expenses = "SELECT expenses.itemName AS DESCRIPTION, budget.budget AS BUDGET, FORMAT(sum(expenses.price * expenses.quantity),'##,##0') as TOTAL_EXPENSES, expenses.price " +
                        "FROM expenses, budget, program " +
                        "WHERE program.programID = budget.programID AND budget.budgetID = expenses.budgetID AND program.programID = '" + prog + "' GROUP BY budget.budgetID";
                    loadDataGridView(expenses, previousExpensesDGV);
                    previousExpensesDGV.Columns["price"].Visible = false;

                    //LOAD PROGRAM BUDGET
                    string budgetQuery = "SELECT budget.description AS DESCRIPTION, budget.budget AS BUDGET, budget.budgetID FROM budget, program WHERE program.programID = budget.programID AND program.programID = '" + prog + "' ";
                    loadDataGridView(budgetQuery, programBudgetDGV);
                    programBudgetDGV.Columns["budgetID"].Visible = false;

                    double result = 0;
                    foreach (DataGridViewRow row in previousExpensesDGV.Rows)
                    {
                        result += Convert.ToDouble(row.Cells["price"].Value);
                    }

                    previousExpensesTB.Text = Convert.ToDecimal(result).ToString("#,##0.00");
                    remainingBalance.Text = Convert.ToDecimal("0").ToString("#,##0.00");

                    string totalBudget = "SELECT sum(budget.budget) AS BUDGET FROM budget, program WHERE program.programID = budget.programID AND program.programID = '" + prog + "' group by budget.programID ";
                    string totalExpenses = "SELECT sum(expenses.price * expenses.quantity) FROM expenses, budget, program " +
                      "WHERE program.programID = budget.programID AND budget.budgetID = expenses.budgetID AND program.programID = '" + prog + "' GROUP BY budget.programID";

                    string dayti1 = "";
                    string dayti2 = "";

                    MySqlDataAdapter da1 = new MySqlDataAdapter(totalBudget, myconn);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    if (dt1.Rows.Count == 0)
                    {
                        totalExpensesTB.Text = "0.00";
                        dayti1 = "0.00";
                    }
                    else { totalBudgetTB.Text = Convert.ToDecimal(dt1.Rows[0][0]).ToString("#,##0.00"); dayti1 = Convert.ToDecimal(dt1.Rows[0][0]).ToString("#,##0.00"); }

                    MySqlDataAdapter da2 = new MySqlDataAdapter(totalExpenses, myconn);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    if (dt2.Rows.Count == 0) { totalExpensesTB.Text = "0.00"; dayti2 = "0.00"; }
                    else
                    {
                        totalExpensesTB.Text = Convert.ToDecimal(dt2.Rows[0][0]).ToString("#,##0.00");
                        dayti2 = Convert.ToDecimal(dt2.Rows[0][0]).ToString("#,##0.00");
                    }

                    remainingBalance.Text = (Convert.ToDecimal(dayti1) - Convert.ToDecimal(dayti2)).ToString("#,##0.00");


                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        //**************************ADD CURRENT EXPENSES**************************
        private void metroTile6_Click(object sender, EventArgs e)
        {
            try
            {
                string queryTotalExpenses = "SELECT SUM(price) AS total FROM expenses WHERE budgetID = '"+expenseBudgetID.Text+"'";
                string totalBudgetPerItem = (getResultQuery(queryTotalExpenses) == "") ? "0" : getResultQuery(queryTotalExpenses);




                if (expenseDesc.Text == "" || expensePrice.Text == "0" || expensePrice.Text == " " || expensePrice.Text == "" || quantity.Text == "0" || quantity.Text == " " || quantity.Text == "" || totalExpenses.Text == "")
                {
                    MetroMessageBox.Show(this, "Please fill up the empty fields!", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    string desc = expenseDesc.Text;
                    string price = totalExpensesPerBudget.Text; //from previous expenses

                    if ((Convert.ToDecimal(price) + Convert.ToDecimal(totalExpenses.Text)) > Convert.ToDecimal(budgetExpenseLabel.Text))
                    {                                                          //    ^current
                        MetroMessageBox.Show(this, "Expenses cannot exceed the alloted budget!", "Insufficient Budget on item '" + expenseDesc.Text + "'", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        this.currentExpensesDGV.Rows.Add(desc, Convert.ToDecimal(expensePrice.Text).ToString("#,##0.00"), quantity.Text, expenseBudgetID.Text);

                        double result = 0;
                        foreach (DataGridViewRow row in currentExpensesDGV.Rows)
                        {
                            result += Convert.ToDouble(row.Cells["price"].Value);
                        }

                        remainingBalance.Text = Convert.ToDecimal(result).ToString("#,##0.00");
                        expenseDesc.Text = "";
                        expensePrice.Text = "0";
                        expenseBudgetID.Text = "";
                        quantity.Text = "0";
                        totalExpenses.Text = "0.00";

                        foreach (DataGridViewRow item in programBudgetDGV.SelectedRows)
                        {
                            programBudgetDGV.Rows.RemoveAt(item.Index);
                        }


                    }
                    
                }
            }
            catch (Exception ex)
            {
                //MetroMessageBox.Show(this, "" + ex, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                
            }
        }

        private void expensePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && char.IsLetter(key))
            {
                e.KeyChar = '\0';
            }

            if (expensePrice.Text.Length == 0 && e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

           
        }

        private void previousExpensesTB_TextChanged(object sender, EventArgs e)
        {
           

        }

       
        private void programBudgetDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = programBudgetDGV.Rows[i];

            expenseDesc.Text = row.Cells[0].Value.ToString();
            expenseBudgetID.Text = row.Cells[2].Value.ToString();
            budgetExpenseLabel.Text = row.Cells[1].Value.ToString();


            
            MySqlConnection myconn = new MySqlConnection(connString);
            string bid = "SELECT sum(expenses.price * expenses.quantity) AS total FROM psam.expenses where budgetID = '"+row.Cells[2].Value.ToString()+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(bid, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {


            }
            else
            {
               totalExpensesPerBudget.Text = (dt.Rows[0][0] + "" == "") ? "0" : dt.Rows[0][0] + "";
            }
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }
        //**************************RESET**************************
        private void metroTile7_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)approvedPrograms.SelectedItem;
            string prog = drv["programID"].ToString();
            string budgetQuery = "SELECT budget.description AS DESCRIPTION, budget.budget AS BUDGET, budget.budgetID FROM budget, program WHERE program.programID = budget.programID AND program.programID = '" + prog + "' ";
            loadDataGridView(budgetQuery, programBudgetDGV);
            programBudgetDGV.Columns["budgetID"].Visible = false;
            currentExpensesDGV.Rows.Clear();
            //currentExpensesTB.Text = "0.00";
        }


        //***************************INSERT EXPENSE METHOD*************************
        private void insertExpense()
        {
            foreach (DataGridViewRow row in currentExpensesDGV.Rows)
            {
                MySqlConnection connectMe = new MySqlConnection(connString);
                connectMe.Open();
                MySqlCommand insertExpenses = connectMe.CreateCommand();
                insertExpenses.CommandText = "INSERT INTO expenses(budgetID, dateAdded, itemName, price, quantity) VALUES (@budgetID, @dateAdded, @itemName, @price, @qty)";
                insertExpenses.Parameters.AddWithValue("@budgetID", row.Cells[3].Value.ToString());
                insertExpenses.Parameters.AddWithValue("@dateAdded", DateTime.Now);
                insertExpenses.Parameters.AddWithValue("@itemName", row.Cells[0].Value.ToString());
                insertExpenses.Parameters.AddWithValue("@price", Convert.ToDecimal(row.Cells[1].Value.ToString()));
                insertExpenses.Parameters.AddWithValue("@qty", row.Cells[2].Value.ToString());
                insertExpenses.ExecuteNonQuery();
                connectMe.Close();
            }

        }
        //**************************ADD EVERYTHING**************************
        private void metroTile8_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentExpensesDGV.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Please add program's expense!", "No Expenses!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (MetroMessageBox.Show(this, "Are you sure you want to add the expense(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        insertExpense();
                        currentExpensesDGV.Rows.Clear();
                        remainingBalance.Text = "0.00";
                        previousExpensesTB.Text = "0.00";
                        totalBudgetTB.Text = "0.00";
                        totalExpensesTB.Text = "0.00";
                        previousExpensesDGV.DataSource = null;
                        programBudgetDGV.DataSource = null;
                        MetroMessageBox.Show(this, "The expense/s is/are successfully added.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(previousExpensesTB.Text) && !string.IsNullOrEmpty(remainingBalance.Text))
                {
                    totalExpenses.Text = (Convert.ToDecimal(quantity.Text) * Convert.ToDecimal(expensePrice.Text)).ToString("#,##0.00");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(previousExpensesTB.Text) && !string.IsNullOrEmpty(remainingBalance.Text))
                {
                    totalExpenses.Text = (Convert.ToDecimal(quantity.Text) * Convert.ToDecimal(expensePrice.Text)).ToString("#,##0.00");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void expensePrice_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(previousExpensesTB.Text) && !string.IsNullOrEmpty(remainingBalance.Text))
                {
                    totalExpenses.Text = (Convert.ToDecimal(quantity.Text) * Convert.ToDecimal(expensePrice.Text)).ToString("#,##0.00");
                }
            }
            catch (Exception ex) { }
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (quantity.Text.Length == 0 && e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            char key = e.KeyChar;
            if (!char.IsDigit(key) && char.IsLetter(key))
            {
                e.KeyChar = '\0';
            }

        }

        private void totalBudgetTB_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(totalBudgetTB.Text) && !string.IsNullOrEmpty(totalExpensesTB.Text))
            {
                remainingBalance.Text = (Convert.ToDecimal(totalBudgetTB.Text) - Convert.ToDecimal(totalExpensesTB.Text)).ToString("#,##0.00");
            }
        }

        private void totalExpensesTB_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(totalBudgetTB.Text) && !string.IsNullOrEmpty(totalExpensesTB.Text))
            {
                remainingBalance.Text = (Convert.ToDecimal(totalBudgetTB.Text) - Convert.ToDecimal(totalExpensesTB.Text)).ToString("#,##0.00");
            }
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {

        }

        private void metroTile10_Click_1(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to set this program as Finished?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                


                MySqlConnection myconn = new MySqlConnection(connString);
                string query = "UPDATE program SET status = 'Finished' WHERE programID = '" + programfinished.SelectedValue.ToString() + "'";
                MySqlCommand approve = new MySqlCommand(query, myconn);
                MySqlDataReader rdr;
                myconn.Open();
                rdr = approve.ExecuteReader();
                myconn.Close();
                MetroMessageBox.Show(this, "You have successfully set the Program Finished!", "Finished!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadApproveProgram();
                cancelProgTitle.Text = "";
                cancelProgDesc.Text = "";
                cancelStartDate.Text = "";
                cancelEnd.Text = "";
                cancelBudget.Text = "";
                loadProgram(programCombo);
                loadProgram(viewProgTitle);
                loadAProgram(); loadFinProg();
            }
        }

        private void finishedProgs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

       
       

        
    }
}
