using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AoC17.Tools;

namespace AoC17.Day2
{
	class Program
	{


		public static void Main()
		{
			CodeInput ci = CodeInput.Instance;
			string input1 = "5 1 9 5";
			string input2 = "7 5 3";
			string input3 = "2 4 6 8";



			var result = ci.GetList(input3, ' ');

			//Console.WriteLine(result[1]);

			Console.Read();

		}
	}
	
}
