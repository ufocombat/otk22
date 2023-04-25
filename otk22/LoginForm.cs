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
            if (loginTextBox.Text.Length<=0)
            {
                loginLabelError.Text = "¬ведите логин";
                loginLabelError.Visible = true;
                return;
            }
            else
            {
                loginLabelError.Visible = false;
            }

            //https://www.youtube.com/watch?v=HOdJUMlc4ZM

            string connectionString = "server=localhost; database=otk; uid=root;pwd=123456;";
            MySqlConnection con = new MySqlConnection(connectionString);

            try
            {
                con.Open();
                MessageBox.Show("OK");
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Cannot conext: {error.Message}");
            }

            this.Hide();
            ListForm listForm = new ListForm();
            listForm.Show();

        }
    }
}