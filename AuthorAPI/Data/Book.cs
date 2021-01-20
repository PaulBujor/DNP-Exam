using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorAPI.Data
{
	public class Book
	{
		[Key]
		public int ISBN { get; set; }
		[Required, MaxLength(40)]
		public string Title { get; set; }
		public int PublicationYear { get; set; }
		public int NumOfPages { get; set; }
		public string Genre { get; set; }
	}
}
