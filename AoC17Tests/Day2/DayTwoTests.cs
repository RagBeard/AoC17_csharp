using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoC17.Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AoC17.Tools;

namespace AoC17.Day2.Tests
{
	[TestClass()]
	public class DayTwoTests
	{
		DayTwo dt = new DayTwo();
		CodeInput ci = CodeInput.Instance;

		[TestMethod()]
		public void CalcRowTest()
		{
			string input1 = "5 1 9 5";
			var row = ci.GetList(input1, ' ');

			int result = dt.CalcRow(row);
			int want = 8;

			Assert.AreEqual(want, result);
		}

		[TestMethod()]
		public void GetChecksumTest()
		{
			string input1 = "5 1 9 5";
			string input2 = "7 5 3";
			string input3 = "2 4 6 8";

			var row1 = ci.GetList(input1, ' ');
			var row2 = ci.GetList(input2, ' ');
			var row3 = ci.GetList(input3, ' ');

			List<int>[] inputMatrix = { row1, row2, row3 };


			int result = dt.GetChecksum(inputMatrix);
			int want = 18;

			Assert.AreEqual(want, result);
		}

		[TestMethod()]
		public void GetSecondChecksumTest()
		{
			string input1 = "5 9 2 8";
			string input2 = "9 4 7 3";
			string input3 = "3 8 6 5";

			var row1 = ci.GetList(input1, ' ');
			var row2 = ci.GetList(input2, ' ');
			var row3 = ci.GetList(input3, ' ');

			List<int>[] inputMatrix = { row1, row2, row3 };


			int result = dt.GetSecondChecksum(inputMatrix);
			int want = 9;

			Assert.AreEqual(want, result);
		}
	}
}