using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Task_4_IDE_coursework
{
    public partial class WorkerEditForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NHJRKUO\ROBISQL;Initial Catalog=task;Persist Security Info=True;User ID=eusuntrobi; Password = 1234");
        string connectionString = @"Data Source=DESKTOP-NHJRKUO\ROBISQL;Initial Catalog=task;Persist Security Info=True;User ID=eusuntrobi; Password = 1234";

        public WorkerEditForm()
        {
            InitializeComponent();
        }

        private void WorkersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taskDataSet);

        }

        private void WorkerEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taskDataSet.workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.taskDataSet.workers);

        }
        private void currentPosition()
        {
            int CurrentPosition, rowNumber;

            rowNumber = workersBindingSource.Count;
            CurrentPosition = workersBindingSource.Position + 1;
            textBox1.Text = CurrentPosition.ToString() + " of " + rowNumber.ToString();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void setValue(string table, TextBox box, string column)
        {
            SqlCommand cmd = new SqlCommand("SELECT " + table + " WHERE workerid = " + workeridTextBox.Text);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                sdr.Read();
                box.Text = sdr[column].ToString();
            }
            con.Close();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.MovePrevious();
            currentPosition();

            setValue("salary from salaries", salaryTextBox,"salary");
            setValue("position from positions",positionTextBox, "position");

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.MoveNext();
            currentPosition();

            setValue("salary from salaries", salaryTextBox, "salary");
            setValue("position from positions", positionTextBox, "position");
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.MoveFirst();
            currentPosition();

            setValue("salary from salaries", salaryTextBox, "salary");
            setValue("position from positions", positionTextBox, "position");
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.MoveLast();
            currentPosition();

            setValue("salary from salaries", salaryTextBox, "salary");
            setValue("position from positions", positionTextBox, "position");

        }
        private static void CreateCommand(string queryString, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string query;
            query = string.Format("update workers set workerid = {0}, workername = '{1}' where workerid = {0}", workeridTextBox.Text, workernameTextBox.Text);
            CreateCommand(query, connectionString);

            query = string.Format("update salaries set salary = {1} where workerid = {0}", workeridTextBox.Text, salaryTextBox.Text);
            CreateCommand(query, connectionString);

            query = string.Format("update positions set position = '{1}' where workerid = {0}", workeridTextBox.Text, positionTextBox.Text);
            CreateCommand(query, connectionString);

            MessageBox.Show("The Worker's details have been updated!");

        }
    }
}
