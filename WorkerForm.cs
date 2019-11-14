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
    public partial class WorkerForm : Form
    {//connection data
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NHJRKUO\ROBISQL;Initial Catalog=task;Persist Security Info=True;User ID=eusuntrobi; Password = 1234");
        string connectionString = @"Data Source=DESKTOP-NHJRKUO\ROBISQL;Initial Catalog=task;Persist Security Info=True;User ID=eusuntrobi; Password = 1234";

        public WorkerForm()
        {
            InitializeComponent();
            taskDataSet.Clear();
            workersBindingSource.AddNew();
        }

        private void WorkersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taskDataSet);

        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taskDataSet.workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.taskDataSet.workers);

        }
        //this button saves data into the table
        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            workersBindingSource.EndEdit();
            workersTableAdapter.Update(taskDataSet.workers);
            MessageBox.Show("The table has updated!");
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


        //this button deletes a row from all tables
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string deleteValue = textBoxSearch.Text.ToString();
            string query;

            query = string.Format("delete from salaries where workerid like {0}", deleteValue);
            CreateCommand(query, connectionString);

            query = string.Format("delete from positions where workerid like {0}", deleteValue);
            CreateCommand(query, connectionString);

            query = string.Format("delete from workers where workerid like {0}", deleteValue);
            CreateCommand(query, connectionString);


            MessageBox.Show("Worker has been removed!");
            Hide();
            WorkerForm newform = new WorkerForm();
            newform.ShowDialog(this);

        }
        //this function queries SQL to search for a worker with a given name
        public void searchData(string searchValue)
        {

            string query = "select * from workers where workername like '%" + searchValue + "%'";


            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dataTbl = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            dataAdapter.Fill(dataTbl);
            workersDataGridView.DataSource = dataTbl;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.ToString();
            searchData(searchValue);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            WorkerAddForm newform = new WorkerAddForm();
            newform.ShowDialog(this);

        }

        private void BtnEditWorker_Click(object sender, EventArgs e)
        {
            WorkerEditForm newform = new WorkerEditForm();
            newform.ShowDialog(this);
        }
    }
}
