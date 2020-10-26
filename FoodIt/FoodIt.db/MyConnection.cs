using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodIt.db
{
    public class MyConnection
    {
        public static SqlConnection GetMyConnection()
        {
            string strConnection = "server=.;database=FoodIt;uid=sa;pwd=123456";
            SqlConnection cnn = new SqlConnection(strConnection);
            return cnn;
        }
    }
}
