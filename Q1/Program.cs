using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q1計算三天後 DVD 應歸還時間
			DateTime borrowDate = DateTime.Today;
			DateTime returnDate = borrowDate.AddDays(3);
			Console.WriteLine($"歸還日期為{returnDate}");
		}
	}
}
