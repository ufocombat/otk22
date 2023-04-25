using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otk22.db
{
    class MyDb
    {
        

        public static MySqlConnection getSqlConnection()
        {
            string connectionString = "server=localhost; database=otk; uid=root;pwd=123456;";
            MySqlConnection con = new MySqlConnection(connectionString);

            try
            {
                con.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ошибка подключения к БД: {error.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return con;
        }

        public static DataTable getSelectTable(String select)
        {
            MySqlConnection con = getSqlConnection();
            DataTable dataTable = new DataTable("table");

            try
            {
                MySqlDataAdapter returnVal = new MySqlDataAdapter(select, con);

                returnVal.Fill(dataTable);
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Cannot conext: {error.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        public static DataTable getUsers(String login, String password)
        {
            return getSelectTable($"SELECT * FROM users where login='{login}' and password='{password}'");
        }

        public static DataTable getOrders()
        {
            return getSelectTable("SELECT * FROM orders");
        }

        public static DataTable getUsersOrders()
        {
            return getSelectTable("SELECT o.id, s.name, o.discountPercent FROM orders o, services s where o.serviceId=s.id");
        }

        public static DataTable getUserOrders(String login)
        {
            return getSelectTable($"SELECT o.id, s.name, o.discountPercent FROM orders o, services s where o.serviceId=s.id and userLogin='{login}'");
        }

        public static DataTable getRoles()
        {
            return getSelectTable("SELECT * FROM roles");
        }

        public static DataTable getRole(String code)
        {
            return getSelectTable($"SELECT * FROM roles where code='{code}'");
        }
    }
}
