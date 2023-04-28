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
using Mysqlx;
using otk22.db;
using otk22.models;

namespace otk22
{
    public partial class ManagerForm : Form
    {
        public readonly User user;
        public readonly Form? loginForm;
        private Int32 orderId = -1;

        public ManagerForm(Form loginForm, User user)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.user = user;

            ordersGridView.DataSource = MyDb.getUsersOrders();
        }

        private void разлогинитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm!.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            Text = $"ОТК - Список заказов - Менеджер - {user.name}";
            statusStrip.Items["stripLogin"].Text = $"login: {user.login}";
        }

        private void ordersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orderId = Convert.ToInt32(ordersGridView.Rows[e.RowIndex].Cells[0].Value);
        }

        private void refreOrdersList()
        {
            ordersGridView.DataSource = MyDb.getUsersOrders();
        }

        private void новыйЗаказToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(user);

            if (orderForm.ShowDialog(this) == DialogResult.OK)
            {
                refreOrdersList();
            }

            orderForm.Dispose();
        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(user, orderId);

            if (orderForm.ShowDialog(this) == DialogResult.OK)
            {
                refreOrdersList();
            }

            orderForm.Dispose();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyDb.deleteOrderById(orderId);
            refreOrdersList();
        }
    }
}
