using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q7根據不同時間, 傳回不同問安方式
			DateTime now = DateTime.Now;
			int hour= Convert.ToInt32(DateTime.Now.Hour);

			if (hour >= 00 && hour < 12)
			{
				Console.WriteLine("早安");
			}
			else if (hour >= 12 && hour <= 18)
			{
				Console.WriteLine("午安");
			}
			else 
			{
				Console.WriteLine("晚安");
			}
		}
	}
}
