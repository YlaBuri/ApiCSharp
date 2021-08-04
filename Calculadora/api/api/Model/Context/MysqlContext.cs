﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model.Context
{
	public class PostgreContext: DbContext
	{
		public PostgreContext()
		{
				
		}

		public PostgreContext(DbContextOptions<PostgreContext> options): base(options)
		{

		}

		public DbSet<Person> Persons { get; set; }
	}
}
