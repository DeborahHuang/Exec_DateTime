using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q5列出指定年份的每一個星期日

			int year = 2022;
			DateTime firstDay = new DateTime(year, 1, 1);
			int months = (int)DateTime.Now.Month;
			int days = (int)DateTime.Now.Day;

			DayOfWeek weekDay = firstDay.DayOfWeek;
			int W = Convert.ToInt32(weekDay);
			DateTime sunday = firstDay.AddDays(1);

			for (int i = 1; i <= 365; i += 7)
			{
				Console.WriteLine(sunday.AddDays(i));
			}
		}
	}
}
