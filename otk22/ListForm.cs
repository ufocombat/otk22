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
using otk22.models;

namespace otk22
{
    public partial class ListForm : Form
    {
        public readonly User user;

        public ListForm(User user)
        {
            InitializeComponent();
            this.user = user;

            ordersGridView.DataSource = MyDb.getUsersOrders();
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

        private void ListForm_Load(object sender, EventArgs e)
        {
            Text = $"ОТК - Список заказов. Администратор - {user.name}";
        }
    }
}
