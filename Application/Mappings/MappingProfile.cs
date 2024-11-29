using Application.Dtos;
using AutoMapper;
using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<SpGetPerson, GetPersonDto>();
			CreateMap<GetPersonDto, SpGetPerson>();
		}
	}
}
