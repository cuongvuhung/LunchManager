using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LunchManager.Models
{
    public class DatabaseConfig
    {
        public string conStr;
        public DatabaseConfig()
        {
            string dataSource = "Data Source = 10.36.0.36;";
            string catalog = "Initial Catalog = Cuongvh-LunchManager;";
            string user = "User ID = cuongvt;";
            string password = "Password = Abcd@12345;";
            string secure = "TrustServerCertificate=True;";
            conStr = dataSource + catalog + user + password + secure;
        }
    }
}
/*
FileStream fileStream = new("config.cfg", FileMode.OpenOrCreate);
StreamReader streamReader = new(fileStream);
string dataSource = streamReader.ReadLine() + "";
string catalog = streamReader.ReadLine() + "";
string user = streamReader.ReadLine() + "";
string password = streamReader.ReadLine() + "";
streamReader.Close();
*/


