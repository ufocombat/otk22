using MySql.Data.MySqlClient;
using System.Data;
using otk22.db;
using otk22.models;

namespace otk22
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int errors = 0;

            if (loginTextBox.Text.Length <= 0)
            {
                loginLabelError.Text = "Введите логин";
                loginLabelError.Visible = true;
                errors++;
            }
            else
            {
                loginLabelError.Visible = false;
            }

            if (passwordTextBox.Text.Length <= 0)
            {
                passwordLabelError.Text = "Введите пароль";
                passwordLabelError.Visible = true;
                errors++;
            }
            else
            {
                passwordLabelError.Visible = false;
            }

            if (errors > 0)
            {
                return;
            }

            DataTable users = MyDb.getUsers(loginTextBox.Text, passwordTextBox.Text);

            if (users.Rows.Count < 1)
            {
                loginLabelError.Text = "Пользователь не найден, проверьте логин и пароль";
                loginLabelError.Visible = true;
                loginTextBox.Focus();
                return;
            }

            User user = new User()
            {
                login = (String)users.Rows[0]["login"],
                name  = (String)users.Rows[0]["name"],
                roleCode  = (String)users.Rows[0]["roleCode"],
                customerId = Convert.ToInt32(users.Rows[0]["customerId"])
            };

            DataTable roles = MyDb.getRole(user.roleCode);
            Boolean employee = Convert.ToBoolean(roles.Rows[0]["employee"]);

            this.Hide();

            if (employee)
            {
                ManagerForm listForm = new ManagerForm(this, user);
                listForm.Show();
            }
            else
            {
                ClientForm clientForm = new ClientForm(this, user);
                clientForm.Show();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}