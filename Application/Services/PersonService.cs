using Application.Dtos;
using Application.Interfaces;
using AutoMapper;
using Infraestructure.Entities;
using Infraestructure.Interfaces;
using Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
	public class PersonService : IPersonService
	{
		private readonly IPersonRepository _personrepository;
		private readonly IMapper _mapper;
		
		public PersonService(IPersonRepository personrepository, IMapper mapper)
		{
			_personrepository = personrepository;
			_mapper = mapper;
		}

		public Task DeletePersonAsync(long id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<GetPersonDto>> GetAllPersonAsync()
		{
			IEnumerable<SpGetPerson> people = await _personrepository.GetAllPersonsAsync();
			return _mapper.Map<IEnumerable<GetPersonDto>>(people);
 
		}

		public async Task<IEnumerable<GetPersonDto>> GetPersonAsync(long id)
		{
			IEnumerable<SpGetPerson> person = await _personrepository.GetPersonsAsync(id);
			return _mapper.Map<IEnumerable<GetPersonDto>>(person);
		}

		public async Task PostPersonAsync(PostPersonDto postPersonDto)
		{

			await _personrepository.PostPersonAsync(
				postPersonDto.Nombre, postPersonDto.Identificacion, postPersonDto.FechaNacimiento);

		}
	 
		public async Task PutPersonAsync(PostPersonDto postPersonDto, long id)
		{
			await _personrepository.PutPersonAsync(id,
				postPersonDto.Nombre, postPersonDto.Identificacion, postPersonDto.FechaNacimiento);
		}
	}
}
