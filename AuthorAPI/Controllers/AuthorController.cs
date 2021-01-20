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
	public class AuthorController : ControllerBase
	{
		private AuthorContext db;

		public AuthorController(AuthorContext context)
		{
			db = context;
		}

		[HttpGet("authors")]
		public async Task<ActionResult<List<Author>>> GetAuthors()
		{
			try
			{
				return Ok(await db.Authors.Include(a => a.Books).ToListAsync());
			} 
			catch(Exception e)
			{
				Console.WriteLine(e.StackTrace);
				return StatusCode(500, e.Message);
			}
		}

		[HttpPost("author")]
		public async Task<ActionResult> AddAuthor([FromBody] Author author)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			try
			{
				await db.Authors.AddAsync(author);
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
