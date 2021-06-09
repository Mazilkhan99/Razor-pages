using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_pages.model
{
	public class dbclass : DbContext
	{
		public dbclass(DbContextOptions<dbclass> options) : base(options)
		{

		}

		public DbSet<book> Book { get; set; }
	}
}
