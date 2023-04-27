using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using otk22.models;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Xml.Linq;
using System.Configuration;

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
                MessageBox.Show($"Ошибка выполнения запроса: {error.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        //Работа с пользователями

        public static DataTable getUsers()
        {
            return getSelectTable($"SELECT * FROM users");
        }

        public static DataTable getUsers(String login, String password)
        {
            return getSelectTable($"SELECT * FROM users where login='{login}' and password='{password}'");
        }

        //Работа с услугами

        public static DataTable getServices()
        {
            return getSelectTable("SELECT * FROM services");
        }

        public static Service getServiceById(Int32 id)
        {
            var s = getSelectTable($"SELECT * FROM services where id={id}");

            return new Service()
            {
                id = Convert.ToInt32(s.Rows[0]["id"]),
                name = (String)s.Rows[0]["name"],
                price = Convert.ToInt32(s.Rows[0]["price"])
            };
        }

        //Работа с ролями

        public static DataTable getRoles()
        {
            return getSelectTable("SELECT * FROM roles");
        }

        public static DataTable getRole(String code)
        {
            return getSelectTable($"SELECT * FROM roles where code='{code}'");
        }

        //Работа с заказами

        public static DataTable getOrders()
        {
            return getSelectTable("SELECT * FROM orders");
        }

        public static DataTable getUsersOrders()
        {
            return getSelectTable("SELECT o.id, o.userLogin, s.name, o.discountPercent FROM orders o, services s where o.serviceId=s.id order by o.id");
        }

        public static DataTable getUserOrders(String login)
        {
            return getSelectTable($"SELECT o.id, o.status, s.name, o.discountPercent FROM orders o, services s where o.serviceId=s.id and userLogin='{login}'");
        }

        public static Order getOrderById(Int32 id)
        {
            var o = getSelectTable($"SELECT * FROM orders where id='{id}");

            return new Order()
            {
                id = Convert.ToInt32(o.Rows[0]["id"]),
                userLogin = (String)o.Rows[0]["userLogin"],
                serviceId = Convert.ToInt32(o.Rows[0]["serviceId"]),
                discountPercent = Convert.ToDecimal(o.Rows[0]["discountPercent"])
            };
        }

        public static Order getOrderViewById(Int32 id)
        {
            var o = getSelectTable($"SELECT * FROM orders o, services s where o.serviceId=s.id id='{id}");

            return new Order()
            {
                id = Convert.ToInt32(o.Rows[0]["id"]),
                userLogin = (String)o.Rows[0]["userLogin"],
                discountPercent = Convert.ToDecimal(o.Rows[0]["discountPercent"]),
                serviceId = Convert.ToInt32(o.Rows[0]["serviceId"]),
                amount = Convert.ToDecimal(o.Rows[0]["price"]),
            };
        }

        public static void insertOrder(Order order)
        {
            MySqlConnection con = getSqlConnection();
            MySqlCommand com = con.CreateCommand();

            com.CommandText = "insert into orders(serviceId,userLogin,discountPercent) VALUES(@serviceId,@userLogin,@discountPercent)";

            com.Parameters.AddWithValue("@serviceId", order.serviceId);
            com.Parameters.AddWithValue("@userLogin", order.userLogin);
            com.Parameters.AddWithValue("@discountPercent", order.discountPercent);

            try
            {
                com.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ошибка сохранения заказа: {error.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }
    }
}
