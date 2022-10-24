
using System;

namespace Metodologias2
{
	
	public class Alumno:Persona
	{
		private int legajo;
		
		public Alumno(string nombre, string apellido, int dni, int legajo):base(nombre,apellido,dni){
			this.legajo=legajo;
		}
	}
}
