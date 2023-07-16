using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchManager.Models
{
    internal class DBConnect
    {
        private Config config = new();
        public SqlConnection Cnn = new();
        public DBConnect()
        {
            try
            {
                Cnn = new SqlConnection(config.conStr);
                Cnn.Open();
            }
            catch
            {
            }

        }
    }
}
