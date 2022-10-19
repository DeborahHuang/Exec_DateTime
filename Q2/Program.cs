using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q2計算圖書下個月歸還時間
			DateTime borrowDate = DateTime.Today;
			DateTime returnDate = borrowDate.AddMonths(1);
			Console.WriteLine($"歸還日期為{returnDate}");
		}
	}
}
