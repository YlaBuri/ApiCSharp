using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
	[Table("person")]
	public class Person
	{
		[Column("id")]
		public long Id { get; set; }

		[Column("first_name")]
		public String FirstName { get; set; }

		[Column("last_name")]
		public String LastName { get; set; }

		[Column("address")]
		public String Address { get; set; }

		[Column("gender")]
		public String Gender { get; set; }
	}
}
