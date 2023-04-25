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

namespace otk22
{
    public partial class ListForm : Form
    {
        DataTable dt = new DataTable("users");

        public ListForm()
        {
            InitializeComponent();
            GetUsers();
        }

        private void GetUsers()
        {
            string connectionString = "server=localhost; database=otk; uid=root;pwd=123456;";
            MySqlConnection con = new MySqlConnection(connectionString);

            try
            {
                con.Open();

                //MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter returnVal = new MySqlDataAdapter("SELECT * FROM roles", con);
                
                returnVal.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Cannot conext: {error.Message}");
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void разлогинитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

    }
}
