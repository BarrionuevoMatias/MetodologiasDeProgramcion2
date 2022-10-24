
using System;

namespace Metodologias2
{
	
	public class Materia
	{
		private string nombre;
		private string codigo;
		private string programa;
		public Materia(string nombre, string codigo,string programa){
			this.nombre=nombre;
			this.codigo=codigo;
			this.programa=programa;
		}
		
		public string Nombre{
			get{
				return this.nombre;
			}
		}
	}
}
