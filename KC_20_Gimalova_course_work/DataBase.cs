using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace KC_20_Gimalova_course_work
{
    class DataBase
    {
        static string pathDB = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Database1.mdf");
        SqlConnection sqlConnection = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={pathDB};Integrated Security=True");

        //открывает связь с БД
        public void openConnection()
        {

            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        //закрывает связь с БД
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        //возвращает строку подключения
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
