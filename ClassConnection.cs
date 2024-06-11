using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanyaDiplom
{
    internal class ClassConnection
    {
        static public SqlConnection GetConnection()
        {
            var connect = new SqlConnection(@""); //Строку подключения хуйни сюда

            connect.Open();
            return connect;
        }
    }
}
