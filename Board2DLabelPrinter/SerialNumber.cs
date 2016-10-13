using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Globalization;

using System.Net.NetworkInformation;
using Microsoft.Win32;

using BoardSerialData;

namespace Board2DLabelPrinter
{
    class SerialNumber
    {
        static SqlConnectionStringBuilder _constr = new SqlConnectionStringBuilder(Properties.Settings.Default.DBConnectionString);
        public static SqlConnectionStringBuilder ConnectionSB { get { return _constr; } set { _constr = value; } }

        public class Week_Year
        {
            public Week_Year(int week, int year)
            {
                Week = week;
                Year = year;
            }
            public int Week;
            public int Year;
        }

        /// <summary>
        /// Gets the week number based on database current date
        /// </summary>
        /// <returns>4 digit week + year string</returns>
        public static Week_Year GetWeekYearNumber()
        {
            int year = -1;
            int week = -1;
            using (SqlConnection con = new SqlConnection(ConnectionSB.ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select getdate()", con))
                {
                    DateTime date = (DateTime)cmd.ExecuteScalar();

                    week = DateTimeFormatInfo.CurrentInfo.Calendar.GetWeekOfYear(
                        date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);

                    year = DateTimeFormatInfo.CurrentInfo.Calendar.GetYear(date);


                }
                con.Close();
            }

            if (year < 0 || week < 0)
            {
                throw new Exception("Unable to determine week or year info");
            }

            int year_2digit = Convert.ToInt32(year.ToString().Substring(2));
            return new Week_Year(week, year_2digit);
        }

        public static string BuildSerial(int product_id, int serial_num, int week, int year)
        {
            string week_number = string.Format("{0:D2}{1}", week, year);

            string serial_number = string.Format("{0:D3}{1}", product_id, week_number);
            serial_number += string.Format("{0:D6}", serial_num);

            return serial_number;
        }

    }
}
