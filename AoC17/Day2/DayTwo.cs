using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC17.Day2
{
	public class DayTwo
	{

		public DayTwo()	{	}

		//making this public for the sake of unit testing.
		public int CalcRow(List<int> row)
		{
			//return diff of highest and lowest in row

			var min = row.Min();
			var max = row.Max();

			return max - min;
		}

		public int GetChecksum(List<int>[] input)
		{
			var sum = 0;
			
			foreach (var row in input)
			{
				sum += CalcRow(row);
			}

			return sum;
		}
	}
}
