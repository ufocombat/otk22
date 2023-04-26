using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using otk22.db;
using otk22.models;

namespace otk22
{
    public partial class ClientForm : Form
    {
        public readonly User user;
        public readonly Form? loginForm;

        public ClientForm(Form loginForm, User user)
        {
            InitializeComponent();

            this.loginForm = loginForm;
            this.user = user;

            ordersGridView.DataSource = MyDb.getUserOrders(user.login);
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            Text = $"ОТК - Список заказов клиента - {user.name}";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
