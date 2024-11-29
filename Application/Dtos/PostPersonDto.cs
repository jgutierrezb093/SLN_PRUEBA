using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
	public class PostPersonDto
	{
		public string Nombre { get; set; }=string.Empty;
		public bool Activo { get; set; }
		public DateTime FechaNacimiento { get; set; }
		public string Identificacion { get; set; } = string.Empty;

	}
}
