using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_pages.model
{
	public class book
	{
		[Key]
		public int id { get; set; }

		[Required]
		public string name { get; set; }

		public string author { get; set; }

		public  string ISBN { get; set; }
	}
}
