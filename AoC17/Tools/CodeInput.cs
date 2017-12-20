using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC17.Tools
{
	public class CodeInput
	{
		private static CodeInput instance;

		private CodeInput() { }

		public static CodeInput Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new CodeInput();
				}
				return instance;
			}
		}

		public List<int> GetList(string input, char separator)
		{
			var result = new List<int>();

			try
			{
				result = input.Split(separator).Select(int.Parse).ToList();
			}
			catch
			{
				throw;
			}

			return result;
		}

	}
}
