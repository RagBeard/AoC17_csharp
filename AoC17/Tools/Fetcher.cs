using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Http;
using System.IO;

namespace AoC17.Tools
{
	// fetches input from the web
	public class Fetcher
	{
		public Fetcher()
		{			
		}

		public string FetchFrom(string url)
		{
			var request = WebRequest.Create(url);
			string responseFromServer = "";
			using (WebResponse response = request.GetResponse())	
			{
				Stream dataStream = response.GetResponseStream();

				using (StreamReader reader = new StreamReader(dataStream))
				{
					
					responseFromServer = reader.ReadToEnd();
					
				}
			}
			
			return responseFromServer;
		}

	}
}
