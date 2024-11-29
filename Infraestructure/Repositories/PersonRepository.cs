using Infraestructure.Context;
using Infraestructure.Entities;
using Infraestructure.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
	public class PersonRepository : IPersonRepository
	{
		private readonly PruebaContext _pruebacontext;

		public PersonRepository(PruebaContext pruebacontext )
		{
			_pruebacontext = pruebacontext;
		}
		public Task DeletePersonsAsync(long id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<SpGetPerson>> GetAllPersonsAsync()
		{
			return await _pruebacontext.SpGetPerson.FromSqlRaw("EXEC SP_GET_PERSON").ToListAsync();
		}

		public async Task<IEnumerable<SpGetPerson>> GetPersonsAsync(long id)
		{
			return await _pruebacontext.SpGetPerson.FromSqlRaw("EXEC SP_GET_PERSON @Id"
				,new SqlParameter("@Id",id) ).ToListAsync();
		}

		public async Task PostPersonAsync(string nombre, string identificacion, string fechaNacimiento)
		{ 
			await _pruebacontext.Database.ExecuteSqlRawAsync(
				"EXEC SP_POST_PERSON @Nombre, @Identificacion, @FechaNacimiento",
				new SqlParameter("@Nombre", nombre),
				new SqlParameter("@Identificacion", identificacion),
				new SqlParameter("@FechaNacimiento", fechaNacimiento)
				);
		}

		public async Task PutPersonAsync(long id,string nombre, string identificacion, string fechaNacimiento)
		{
			await _pruebacontext.Database.ExecuteSqlRawAsync(
				"EXEC SP_PUT_PERSON @Id, @Nombre, @Identificacion, @FechaNacimiento",
				new SqlParameter("@Id", id),
				new SqlParameter("@Nombre", nombre),
				new SqlParameter("@Identificacion", identificacion),
				new SqlParameter("@FechaNacimiento", fechaNacimiento)
				);
		}
	}
}
