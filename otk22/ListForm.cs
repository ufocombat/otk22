using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using otk22.db;

namespace otk22
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
            rolesGridView.DataSource = MyDb.getRoles();
        }

        private void разлогинитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
