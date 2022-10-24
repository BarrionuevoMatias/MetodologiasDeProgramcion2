
using System;

namespace Metodologias2
{
	
	public class Aula
	{
		private int numero;
		private int capacidad;
		public Aula(int numero, int capacidad){
			this.numero=numero;
			this.capacidad=capacidad;
		}
		
		public int Numero{
			get{
				return this.numero;
			}
		}
	}
}
