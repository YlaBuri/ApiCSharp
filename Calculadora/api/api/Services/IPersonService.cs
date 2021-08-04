using api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
	public interface IPersonService
	{
		Person Create(Person person);

		Person FindById(long Id);

		Person Update(Person person);

		void Delete(long Id);

		List<Person> FindAll();
	}
}
