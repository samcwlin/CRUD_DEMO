using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CRUD_DEMO.Helps;
using CRUD_DEMO.Model;
using Newtonsoft.Json;

namespace CRUD_DEMO.Services
{
	class DataService
	{

		private HttpClient GetClient()
		{
			HttpClient client = new HttpClient(new HttpClientHandler());
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			return client;
		}
		public async Task<IEnumerable<Books>> GetTravelExpensesAsync()
		{
			using (HttpClient client = GetClient())
			{
				var fooStr = $"{AppData.AllBooksUrl}";
				HttpResponseMessage httpResponseMessage = await client.GetAsync(fooStr);
				httpResponseMessage.EnsureSuccessStatusCode();
				string content = await httpResponseMessage.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<IEnumerable<Books>>(content);
			}
		}
	}
}
