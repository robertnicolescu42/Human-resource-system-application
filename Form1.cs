using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4_IDE_coursework
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void BtnWorkers_Click(object sender, EventArgs e)
        {
            WorkerForm newform = new WorkerForm();
            newform.ShowDialog(this);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            WorkerAddForm newform = new WorkerAddForm();
            newform.ShowDialog(this);
        }
    }
}
