using AuthorBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AuthorBlazor.Services
{
	public class AuthorService
	{
		private string URI = "https://localhost:44304";

		public async Task<List<Author>> GetAuthorsAsync()
		{
			HttpClient client = new HttpClient();
			string result = await client.GetStringAsync(URI + "/authors");
			return JsonSerializer.Deserialize<List<Author>>(result);
		}

		public async Task AddAuthorAsync(Author author)
		{
			HttpClient client = new HttpClient();

			StringContent content = new StringContent(
				JsonSerializer.Serialize(author),
				Encoding.UTF8,
				"application/json"
			);

			await client.PostAsync(URI + "/author", content);
		}
	}
}
