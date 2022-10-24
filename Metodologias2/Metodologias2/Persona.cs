
using System;

namespace Metodologias2
{
	
	public class Persona
	{
		private string nombre;
		private string apellido;
		private int dni;
		public Persona(string nombre, string apellido, int dni){
			this.nombre=nombre;
			this.apellido=apellido;
			this.dni=dni;
		}
		
		public int Dni{
			get{
				return this.dni;
			}
		}
	}
}
