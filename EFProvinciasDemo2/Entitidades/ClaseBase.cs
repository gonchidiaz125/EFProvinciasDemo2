using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProvinciasDemo2.Entities
{
	public abstract class SimpleClaseBase
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public bool Activo { get; set; }

		public SimpleClaseBase()
		{
			Activo = true;
		}
	}

	// public class Usuario : SimpleClaseBase


	public class Usuario : SimpleClaseBase
	{
		public string Apellido { get; set; }
	}
	
	public abstract class ClaseBase : SimpleClaseBase
	{
		public int UsuarioAltaId { get; set; }
		public virtual Usuario UsuarioAlta { get; set; }

		public DateTime FechaAlta { get; set; }
		public int? UsuarioModificacionId { get; set; }
		public virtual Usuario UsuarioModificacion { get; set; }
		public DateTime? FechaModificacion { get; set; }

		public int? UsuarioBajaId { get; set; }
		public virtual Usuario UsuarioBaja { get; set; }
		public DateTime? FechaBaja { get; set; }

		public ClaseBase() : base()
		{
			FechaAlta = DateTime.Now;

		}
	}

	public class Localidad : ClaseBase
	{
		public int DepartamentoId { get; set; }
		public virtual Departamento Departamento { get; set; }
	}

	public class Departamento : ClaseBase
	{
		public int ProvinciaId { get; set; }

		public virtual Provincia Provincia { get; set; }

		public virtual List<Localidad> Localidades { get; set; }

		public Departamento() : base()
		{
			Localidades = new List<Localidad>();
		}
	}


	public class Provincia : ClaseBase
	{
		public virtual List<Departamento> Departamentos { get; set; }

		public Provincia() : base()
		{
			Departamentos = new List<Departamento>();
		}

	}

	public class Persona : ClaseBase
	{
		public string Apellido { get; set; }
		public DateTime FechaNacimiento { get; set; }
		public int Documento { get; set; }

		public int IdLocalidad { get; set; }
		public virtual Localidad Localidad { get; set; }

	}
}
