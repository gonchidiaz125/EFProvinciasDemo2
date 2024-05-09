using EFProvinciasDemo2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProvinciasDemo2.Repositorios
{
	public class MiDbContext : DbContext
	{
		public DbSet<Provincia> Provincias { get; set; }
		public DbSet<Departamento> Departamentos { get; set; }
		public DbSet<Localidad> Localidades { get; set; }
		public DbSet<Persona> Personas { get; set; }

		public DbSet<Usuario> Usuarios { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder
				.UseSqlServer("Server=localhost;Database=EFProvinciasDemo2;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
		}

	}
}
