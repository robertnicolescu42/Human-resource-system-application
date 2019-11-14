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
    public partial class QueriesForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NHJRKUO\ROBISQL;Initial Catalog=task;Persist Security Info=True;User ID=eusuntrobi; Password = 1234");
        string connectionString = @"Data Source=DESKTOP-NHJRKUO\ROBISQL;Initial Catalog=task;Persist Security Info=True;User ID=eusuntrobi; Password = 1234";

        public QueriesForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                SqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "Select * from workers inner join salaries on workers.workerid = salaries.workerid where salary like " + textBox1.Text;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                con.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            {
                SqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "select * from workers inner join positions on workers.workerid = positions.workerid where position like '" + textBox2.Text + "'";
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                con.Close();
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select workers.workerid, workername, salary, position from workers inner join positions on workers.workerid = positions.workerid inner join salaries on workers.workerid = salaries.workerid order by salary desc";
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select workers.workerid, workername, salary, position from workers inner join positions on workers.workerid = positions.workerid inner join salaries on workers.workerid = salaries.workerid";
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();

        }
    }
}
