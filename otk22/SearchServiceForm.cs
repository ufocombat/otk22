using otk22.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otk22
{
    public partial class SearchServiceForm : Form
    {
        public SearchServiceForm()
        {
            InitializeComponent();
            serviceDataGridView.DataSource = MyDb.getAllServices();
        }

        private void SearchServiceForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 3)
            {
                serviceDataGridView.DataSource = MyDb.getServicesFilter(nameTextBox.Text);
            }
            else
            {
                serviceDataGridView.DataSource = MyDb.getAllServices();
            }
        }
    }
}
