﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AuthorBlazor.Data
{
	public class Author
	{
		[Key]
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[Required, MaxLength(15)]
		[JsonPropertyName("firstName")]
		public string FirstName { get; set; }

		[Required, MaxLength(15)]
		[JsonPropertyName("lastName")]
		public string LastName { get; set; }

		[JsonPropertyName("books")]
		public List<Book> Books { get; set; }
	}
}
