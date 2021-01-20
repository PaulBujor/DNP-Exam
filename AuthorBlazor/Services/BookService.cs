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
	public class BookService
	{
		private string URI = "https://localhost:44304";

		public async Task<List<Book>> GetBooksAsync()
		{
			HttpClient client = new HttpClient();
			string result = await client.GetStringAsync(URI + "/books");
			return JsonSerializer.Deserialize<List<Book>>(result);
		}

		public async Task AddBookAsync(int authorId, Book book)
		{
			HttpClient client = new HttpClient();

			StringContent content = new StringContent(
				JsonSerializer.Serialize(book),
				Encoding.UTF8,
				"application/json"
			);

			await client.PostAsync(URI + "/book/" + authorId, content);
		}

		public async Task DeleteBookAsync(int bookId)
		{
			HttpClient client = new HttpClient();

			await client.DeleteAsync(URI + "/book/" + bookId);
		}
	}
}
