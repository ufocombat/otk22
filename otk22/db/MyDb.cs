﻿using MySql.Data.MySqlClient;
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

        public static DataTable getRoles()
        {
            MySqlConnection con = getSqlConnection();
            DataTable dataTable = new DataTable("roles");

            try
            {
                MySqlDataAdapter returnVal = new MySqlDataAdapter("SELECT * FROM roles", con);

                returnVal.Fill(dataTable);
                con.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show($"Cannot conext: {error.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }
    }
}