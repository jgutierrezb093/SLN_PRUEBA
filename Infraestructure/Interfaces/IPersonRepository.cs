using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Interfaces
{
	public interface IPersonRepository
	{
		Task<IEnumerable<SpGetPerson>> GetAllPersonsAsync();

		Task<IEnumerable<SpGetPerson>> GetPersonsAsync(long id);

		Task PostPersonAsync(string nombre, string identificacion, DateTime fechaNacimiento);
		Task PutPersonAsync(long id,string nombre, string identificacion, DateTime fechaNacimiento);

		Task DeletePersonsAsync(long id);
	}
}
