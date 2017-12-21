using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AoC17.Tools
{
	public class CodeInput
	{
		private static CodeInput instance;

		private Fetcher fetcher = new Fetcher();

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

		//Doesnt work for AoC input files because it's behind authentication...
		private List<int> GetListFromWeb(string url, string input, char separator)
		{
			var result = new List<int>();


			try
			{
				var asdf = fetcher.FetchFrom(url);

				result = input.Split(separator).Select(int.Parse).ToList();
			}
			catch
			{
				throw;
			}

			return result;
		}

		//returns a list of values from a <separator> separated string of values in <input>
		public List<int> GetList(string input, char separator)
		{
			var result = new List<int>();

			try
			{
				//handles empty strings (when separator repeats)
				result = input.Split(separator).Where(s => s.Length > 0).Select(int.Parse).ToList();
			}
			catch
			{
				throw;
			}

			return result;
		}

		//returns an array of lists, containing values from a <separator> separated string of values in <input>
		public List<int>[] GetMatrix(string [] input, char separator)
		{

			List<int>[] result = new List<int>[input.Length];
			
			try
			{
				int i = 0;
				foreach (var str in input)
				{
					result[i] = GetList(str, separator);
					i++;
				}
				
			}
			catch
			{
				throw;
			}

			return result;
		}
	}
}
