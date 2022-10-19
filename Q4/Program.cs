using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q4取得本月最後一天
			DateTime FirstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			DateTime nextMonth1 = FirstDay.AddMonths(1);
			DateTime lastDatOfMonth = nextMonth1.AddDays(-1);
			Console.WriteLine(lastDatOfMonth);
		}
	}
}
