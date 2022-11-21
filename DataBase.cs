using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MessariT15.CustomControls.RJControls;

namespace MessariT15
{
    internal class DataBase
    {
        public static string Login;
        public static string Password;
        
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DOM\SQLEXPRESS;Initial Catalog=Briefcase;Integrated Security=True");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) ;    
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open);
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return sqlConnection; 
        }
        static class DataBank
        {
            public static string Login;
            public static string Password;
            
        }

    }
}
