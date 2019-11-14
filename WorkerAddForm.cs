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
    public partial class WorkerAddForm : Form
    {//connection data
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NHJRKUO\ROBISQL;Initial Catalog=task;Persist Security Info=True;User ID=eusuntrobi; Password = 1234");
        string connectionString = @"Data Source=DESKTOP-NHJRKUO\ROBISQL;Initial Catalog=task;Persist Security Info=True;User ID=eusuntrobi; Password = 1234";

        public WorkerAddForm()
        {
            InitializeComponent();

        }

        private void WorkersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taskDataSet);

        }

        private void WorkerAddForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taskDataSet.salaries' table. You can move, or remove it, as needed.
            this.salariesTableAdapter.Fill(this.taskDataSet.salaries);
            // TODO: This line of code loads data into the 'taskDataSet.positions' table. You can move, or remove it, as needed.
            this.positionsTableAdapter.Fill(this.taskDataSet.positions);
            // TODO: This line of code loads data into the 'taskDataSet.positions' table. You can move, or remove it, as needed.
            this.positionsTableAdapter.Fill(this.taskDataSet.positions);
            // TODO: This line of code loads data into the 'taskDataSet.workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.taskDataSet.workers);

        }

        private void BtnAddWorker_Click(object sender, EventArgs e)
        {
            taskDataSet.Clear();
            workersBindingSource.AddNew();
        }
        //this function queries sql
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into workers values ({0},'{1}')", workeridTextBox.Text, workernameTextBox.Text);
            
            CreateCommand(query, connectionString);

            query = string.Format("insert into salaries values ({0},'{1}')", workeridTextBox.Text, salaryTextBox.Text);
            CreateCommand(query, connectionString);

            query = string.Format("insert into positions values ({0},'{1}')", workeridTextBox.Text, positionTextBox.Text);
            CreateCommand(query, connectionString);

            MessageBox.Show("Worker added!");
            //this.Close();

            Application.OpenForms["WorkerForm"].Hide();
            Application.OpenForms["WorkerAddForm"].Hide();
            Application.OpenForms["WorkerAddForm"].Close();
            WorkerForm newform = new WorkerForm();
            newform.ShowDialog(this);

        }
    }
}
