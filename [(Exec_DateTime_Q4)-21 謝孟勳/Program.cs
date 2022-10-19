using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Exec_DateTime_Q4__21_謝孟勳
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            int year = today.Year;
            int month = today.Month;

            DateTime lastday = new DateTime(year, month, 1);
            lastday = lastday.AddMonths(1);
            lastday = lastday.AddDays(-1);
            Console.WriteLine(lastday);
        }
    }
}
