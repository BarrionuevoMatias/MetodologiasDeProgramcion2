
using System;

namespace Metodologias2
{
	
	public class Profesor:Persona
	{
		private string area;
		public Profesor(string nombre, string apellido, int dni, string area):base(nombre,apellido,dni){
			this.area=area;
		}
	}
}
