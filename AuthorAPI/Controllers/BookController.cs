using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthorAPI.Data;
using AuthorAPI.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthorAPI.Controllers
{
	[ApiController]
	public class BookController : ControllerBase
	{
		private AuthorContext db;

		public BookController(AuthorContext context)
		{
			db = context;
		}

		[HttpGet("books")]
		public async Task<ActionResult<List<Book>>> GetBooksAsync()
		{
			try
			{
				return Ok(await db.Books.ToListAsync());
			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
				return StatusCode(500, e.Message);
			}
		}

		[HttpPost("book/{id:int}")]
		public async Task<ActionResult> AddBookAsync([FromBody] Book book, [FromRoute] int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			try
			{
				Author author = await db.Authors.FirstOrDefaultAsync(a => a.Id == id);
				author.Books.Add(book);
				await db.SaveChangesAsync();
				return Ok();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
				return StatusCode(500, e.Message);
			}
		}

		[HttpDelete("book/{id:int}")]
		public async Task<ActionResult> DeleteBookAsync([FromRoute] int id)
		{
			try
			{
				db.Books.Remove(await db.Books.FirstOrDefaultAsync(b => b.ISBN == id));
				await db.SaveChangesAsync();
				return Ok();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
				return StatusCode(500, e.Message);
			}
		}
	}
}
