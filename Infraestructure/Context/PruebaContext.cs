using Infraestructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Context
{
	
	public class PruebaContext : DbContext
	{
		public virtual DbSet<SpGetPerson> SpGetPerson { get; set; }
		public PruebaContext(DbContextOptions<PruebaContext> options) : base(options) { }
	}
}
