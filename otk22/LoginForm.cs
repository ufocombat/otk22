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

        private Boolean IsLoginValid()
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

            return errors == 0;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (!IsLoginValid())
            {
                return;
            }

            DataTable users = MyDb.getUsers(loginTextBox.Text, passwordTextBox.Text);
            //DataTable users = MyDb.getUsers("admin", "1");

           

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

            passwordTextBox.Text = String.Empty;
            

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

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
           loginTextBox.Focus();
        }

        private void showPassword()
        {
           passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
           pasVisOffButton.Visible = passwordTextBox.UseSystemPasswordChar;
           pasVisOnButton.Visible = !passwordTextBox.UseSystemPasswordChar;
        }

        private void pasVisOnButton_Click(object sender, EventArgs e)
        {
            showPassword();
        }

        private void passCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            showPassword();
        }
    }
}