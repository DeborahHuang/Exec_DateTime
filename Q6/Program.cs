using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q6根據日期, 傳回今天是本月的上旬, 中旬或下旬
			DateTime today = DateTime.Today;
			int dt=(int)today.Day;

			if (dt >= 1 && dt <= 10)
			{
				Console.WriteLine("今天是本月上旬");
			}
			else if (dt > 10 && dt <= 20)
			{
				Console.WriteLine("今天是本月中旬");
			}
			else 
			{
				Console.WriteLine("今天是本月下旬");
			}
		}
	}
}
