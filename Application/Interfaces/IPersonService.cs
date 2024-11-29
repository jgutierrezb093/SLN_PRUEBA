using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
	public interface IPersonService
	{
		Task<IEnumerable<GetPersonDto>> GetAllPersonAsync();

		Task<IEnumerable<GetPersonDto>> GetPersonAsync(long id);

		Task PostPersonAsync(PostPersonDto postPersonDto);

		Task DeletePersonAsync(long id);
		Task PutPersonAsync(PostPersonDto postPersonDto,long id);

	}
}
