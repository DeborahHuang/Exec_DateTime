using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q3取得本月一日
			DateTime FirstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			Console.WriteLine(FirstDay);
		}
	}
}
