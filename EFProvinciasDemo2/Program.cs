// See https://aka.ms/new-console-template for more information
using EFProvinciasDemo2.Entities;
using EFProvinciasDemo2.Repositorios;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

Console.WriteLine("Hola Mundo!");


// ImprimirProvincia("Córdoba");
// ImprimirProvincia("santa Fe");
// CrearUnaProvincia("Mendoza");

//var departamentos = new List<string>();
//departamentos.Add("Junin");
//departamentos.Add("Juan Martín de Pueyrredon");
//CrearUnaProvinciaConDepartamentos("San Luis", departamentos);

// CrearUnaProvinciaDepartamentoLocalidad("Corrientes", "San Cosme", "Yapeyu");

ImprimirProvincias();

ImprimirProvinciaConSusDepartaementos("Córdoba");
ImprimirProvinciaConSusDepartaementos("Brasil");

ImprimirProvinciaConDeptosMasLocalidades("Córdoba");


void CrearUnaProvinciaDepartamentoLocalidad(string nombreProvincia, string nombreDepartamento, string nombreLocalidad)
{
	using (var dbContext = new MiDbContext())
	{
		var usuarioAlta = dbContext.Usuarios.First(u => u.Id == 1);

		var provincia = new Provincia()
		{
			Nombre = nombreProvincia,
			Activo = true,
			FechaAlta = DateTime.Now,
			UsuarioAlta = usuarioAlta
		};
		
		var departamento = new Departamento()
		{
			Nombre = nombreDepartamento,
			Activo = true,
			FechaAlta = DateTime.Now,
			UsuarioAlta = usuarioAlta
			// No hace falta definirle la provincia, ya que en la proxima linea asocio este departamento a la provincia que lo contiene
			// Provincia = provincia
		};
		provincia.Departamentos.Add(departamento);

		var localidad= new Localidad()
		{
			Nombre = nombreLocalidad,
			Activo = true,
			FechaAlta = DateTime.Now,
			UsuarioAlta = usuarioAlta
			// No hace falta definirle el departamento
		};
		departamento.Localidades.Add(localidad);

		dbContext.Add(provincia);
		dbContext.SaveChanges();
	}
}

void CrearUnaProvinciaConDepartamentos(string nombre, List<string> departamentos)
{
	using (var dbContext = new MiDbContext())
	{
		var usuarioAlta = dbContext.Usuarios.First(u => u.Id == 1);

		var provincia = new Provincia()
		{
			Nombre = nombre,
			Activo = true,
			FechaAlta = DateTime.Now,
			UsuarioAlta = usuarioAlta
		};

		foreach (var item in departamentos)
		{
			var departamento = new Departamento()
			{
				Nombre = item,
				Activo = true,
				FechaAlta = DateTime.Now,
				UsuarioAlta = usuarioAlta
				// No hace falta definirle la provincia, ya que en la proxima linea asocio este departamento a la provincia que lo contiene
				// Provincia = provincia
			};
			provincia.Departamentos.Add(departamento);
		}

		dbContext.Add(provincia);
		dbContext.SaveChanges();
	}
}

void ImprimirProvincias()
{
	Console.WriteLine("Imprimiendo listado de provincias");
	Console.WriteLine("");

	using (var dbContext = new MiDbContext())
	{
		// Include sirve para hacer como un LEFT JOIN a departamentos
		// ThenInclude es para hacer un LEFT JOIN de departamentos a localidades
		var provincias = dbContext.Provincias.ToList();

		foreach (var unaProvincia in provincias)
		{
			Console.WriteLine(unaProvincia.Nombre);
		}
	}
	Console.WriteLine("");
}

void ImprimirProvinciaConSusDepartaementos(string nombre)
{
	using (var dbContext = new MiDbContext())
	{
		var provincia = dbContext.Provincias
			.Include(p => p.Departamentos)
			.FirstOrDefault(p => p.Nombre == nombre);

		if (provincia != null)
		{
			Console.WriteLine($"Imprimiendo departamentos de {nombre}");
			
			foreach (var depto in provincia.Departamentos)
			{
				Console.WriteLine($"  {depto.Nombre}");
			}
			Console.WriteLine("");
		}
		else
		{
			Console.WriteLine($"No se encontró la provincia de {nombre}");
			Console.WriteLine("");
		}
	}
}

void ImprimirProvinciaConDeptosMasLocalidades(string nombreProvincia)
{
	Console.WriteLine("Imprimiendo una provincia");
	Console.WriteLine("");

	using (var dbContext = new MiDbContext())
	{
		// Include sirve para hacer como un LEFT JOIN a departamentos
		// ThenInclude es para hacer un LEFT JOIN de departamentos a localidades
		var cordoba = dbContext.Provincias
			.Include(p => p.Departamentos)
			.ThenInclude(d => d.Localidades)
			.First(p => p.Nombre == nombreProvincia);


		Console.WriteLine($"Departamentos de {nombreProvincia}");
		foreach (var d in cordoba.Departamentos)
		{
			Console.WriteLine(d.Nombre);

			foreach (var l in d.Localidades)
			{
				Console.WriteLine($"    {l.Nombre}");
			}
		}
	}
	Console.WriteLine("");
}

void CrearUnaProvincia(string nombre, bool activo = true)
{
	using (var dbContext = new MiDbContext())
	{
		var usuarioAlta = dbContext.Usuarios.First(u => u.Id == 1);

		var provincia = new Provincia()
		{
			Nombre = nombre,
			Activo = activo,
			FechaAlta = DateTime.Now,
			UsuarioAlta = usuarioAlta
		};

		dbContext.Add(provincia);
		dbContext.SaveChanges();
	}
}

