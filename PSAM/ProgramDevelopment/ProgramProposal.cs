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
    public partial class ProgramProposal : MetroForm
    {
        public ProgramProposal()
        {
            InitializeComponent();
        }
        long programID;
        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING

        private bool validateQuery(string query)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            MySqlDataAdapter da = new MySqlDataAdapter(query, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        //***************************LOAD DISASTER METHOD************************* 
        private void loadDisaster()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string disaster = "SELECT disasterID, CONCAT(disasterType, ': ', DATE_FORMAT(disasterDate,'%b %d %Y')) as disasterName FROM disaster";
            MySqlCommand mycommand = new MySqlCommand(disaster, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            disasterCombo.DataSource = dt;
            disasterCombo.DisplayMember = "disasterName";
            disasterCombo.ValueMember = "disasterID";
        }
        //***************************INSERT BUDGET METHOD*************************
        private void insertBudget()
        {
            foreach (DataGridViewRow row in budgetDGV.Rows)
            {
                MySqlConnection connectMe = new MySqlConnection(connString);
                connectMe.Open();
                MySqlCommand insertBudgets = connectMe.CreateCommand();
                insertBudgets.CommandText = "INSERT INTO budget(programID, dateAdded, description, budget) VALUES (@programID, @dateAdded, @description, @budget)";
                
                insertBudgets.Parameters.AddWithValue("@programID", programID);
                insertBudgets.Parameters.AddWithValue("@dateAdded", DateTime.Now);
                insertBudgets.Parameters.AddWithValue("@description", row.Cells[0].Value.ToString());
                insertBudgets.Parameters.AddWithValue("@budget", Convert.ToDecimal(row.Cells[1].Value.ToString()));
                insertBudgets.ExecuteNonQuery();
                connectMe.Close();
            }

        }
        //***************************INSERT PROGRAM METHOD*************************
        private void insertProgram()
        {

                DataRowView drv = (DataRowView)disasterCombo.SelectedItem;
                string disID = drv["disasterID"].ToString();
                MySqlConnection connectMe = new MySqlConnection(connString);
                connectMe.Open();
                MySqlCommand insertPrograms = connectMe.CreateCommand();
                insertPrograms.CommandText = "INSERT INTO program(employeeID, disasterID, programTitle, programDescription, startTimeFrame, endtimeFrame, dateProposed, status) VALUES (@employee, @disasterID, @programTitle, @progDesc, @start, @end, @date, @status)";
                insertPrograms.Parameters.AddWithValue("@employee", 1);
                insertPrograms.Parameters.AddWithValue("@disasterID", disID);
                insertPrograms.Parameters.AddWithValue("@programTitle", programTitle.Text);
                insertPrograms.Parameters.AddWithValue("@progDesc", programDescription.Text);
                insertPrograms.Parameters.AddWithValue("@start", programFrom.Value.Date.ToString("yyyy-MM-dd"));
                insertPrograms.Parameters.AddWithValue("@end", programTo.Value.Date.ToString("yyyy-MM-dd"));
                insertPrograms.Parameters.AddWithValue("@date", DateTime.Now);
                insertPrograms.Parameters.AddWithValue("@status", "Pending");
                insertPrograms.ExecuteNonQuery();
                programID = insertPrograms.LastInsertedId;
                connectMe.Close();

                insertBudget();
                MetroMessageBox.Show(this, "The program is successfully proposed.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        //***************************PAGE LOAD*************************
        private void ProgramProposal_Load(object sender, EventArgs e)
        {
            loadDisaster();
            this.budgetDGV.Columns["budget"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }


        //**************************ADD BUDGET LISTBOX**************************
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
                    if (row.Cells[0].Value.ToString() == budgetDescription.Text.ToString())
                    {
                        found = true;
                        MetroMessageBox.Show(this, "Item '" +budgetDescription.Text+ "' already exists!", "Already Exists!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                if (!found)
                {
                    string desc = budgetDescription.Text;
                    string price = budgetPrice.Text;
                    this.budgetDGV.Rows.Add(desc, Convert.ToDecimal(price).ToString("#,##0.00"));

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
        //*******************************KEY PRESS******************************
        private void budgetPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && char.IsLetter(key))
            {
                e.KeyChar = '\0';
            }
        }
        //*******************************REMOVE ITEM******************************
        private void metroTile1_Click(object sender, EventArgs e)
        {
            budgetDGV.Rows.Clear();
            budgetDGV.Refresh();
            totalBudget.Text = ""+0;
        }

        //*******************************PROPOSE PROGRAM******************************
        
        
        private void metroTile3_Click(object sender, EventArgs e)
        {
            
            if(programTitle.Text == "" || programDescription.Text == "")
            {
                MetroMessageBox.Show(this, "Please fill up every needed fields!", "Incomplete Details!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(budgetDGV.Rows.Count==0)
            {
                MetroMessageBox.Show(this, "Please add program's budget!", "No Budget!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection myconn = new MySqlConnection(connString);
                DateTime startDate = programFrom.Value.Date;
                DateTime endDate = programTo.Value.Date;

                string sstartDate = String.Format("{0:yyyy-MM-dd}", startDate);
                string eendDate = String.Format("{0:yyyy-MM-dd}", endDate);

                string checkDateSQL = "SELECT programTitle, startTimeFrame, endTimeFrame FROM program WHERE (startTimeFrame BETWEEN '" + sstartDate + "' AND '" + eendDate + "') OR (endTimeFrame BETWEEN '" + sstartDate + "' AND '" + eendDate + "')";


                if(startDate > endDate)
                {
                    MetroMessageBox.Show(this, "End Date is later than Start Date!", "Invalid Time Frame!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (validateQuery(checkDateSQL))
                    {
                        if (MetroMessageBox.Show(this, "The proposed program's schedule is in conflict with other proposed program. Do you still want to propose the program?", "Conflict with Schedule", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            insertProgram();
                        }

                    }
                    else if (!validateQuery(checkDateSQL))
                    {
                        if (MetroMessageBox.Show(this, "Are you sure you want to propose the program?", "Confirm Proposal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            insertProgram();
                        }
                    }
                }
            
               

            }

            
           
        }
    }
}
