using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoC17.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC17.Tools.Tests
{
	[TestClass()]
	public class CodeInputTests
	{
		CodeInput ci = CodeInput.Instance;
		string input = "";

		[TestMethod()]
		public void GetListTest()
		{
			Assert.Fail();
		}


		[ExpectedException(typeof(FormatException))]
		[TestMethod()]
		public void GetListFormatTest()
		{
			input = "2 3 4 b";

			var result = ci.GetList(input, ' ');
		}

		[ExpectedException(typeof(NullReferenceException))]
		[TestMethod()]
		public void GetListNullRefTest()
		{
			input = null;

			var result = ci.GetList(input, ' ');
		}

	}
}