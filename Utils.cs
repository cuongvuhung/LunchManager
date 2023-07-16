using System.Security.Cryptography;
using System.Text;

namespace LunchManager
{
    public class Utils
    {
        public Utils()
        {
        }

        public static string Hash(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            byte[] hashBytes = null;
            // SHA
            hashBytes = SHA256.HashData(bytes);
            return Convert.ToHexString(hashBytes);
        }
        public static DateTime StringToDate(string text)
        {
            DateTime dateTime;
            int thisday = Convert.ToInt32(text.Split('/')[0]);
            int thismonth = Convert.ToInt32(text.Split('/')[1]);
            int thisyear = Convert.ToInt32(text.Split('/')[2]);
            dateTime = new DateTime(thisyear, thismonth, thisday);
            return dateTime;
        }
        public static string DateToString(DateTime dateTime)
        {
            int thisday = dateTime.Day;
            int thismonth = dateTime.Month;
            int thisyear = dateTime.Year;
            return thisday +"/" + thismonth +"/" + thisyear;
        }
    }
}
