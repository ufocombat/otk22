using MySql.Data.MySqlClient;

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

            //https://www.youtube.com/watch?v=HOdJUMlc4ZM

            string connectionString = "server=localhost; database=otk; uid=root;pwd=123456;";
            MySqlConnection con = new MySqlConnection(connectionString);

            try
            {
                con.Open();
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Не удалось подключится к БД: {error.Message}");
            }

            this.Hide();
            ListForm listForm = new ListForm();
            listForm.Show();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}