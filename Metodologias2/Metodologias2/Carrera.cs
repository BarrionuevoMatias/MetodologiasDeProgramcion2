
using System;
using System.Collections.Generic;

namespace Metodologias2
{
	
	public class Carrera
	{
		private string nombre;
		private string duracion;
		private List<Materia> materias;
		public Carrera(string nombre,string duracion){
			this.nombre=nombre;
			this.duracion=duracion;
		}
		
		public void agregarMateria(Materia materia){
			this.materias.Add(materia);
		}
		
		public void bajaMateria(Materia materia){
			int index=0;
			bool final=false;
			
			while(!final){
				if(this.materias[index].Nombre==materia.Nombre){
					this.materias.RemoveAt(index);
					final=true;
				}
				if(index+1==this.materias.Count) final=true;
				index++;
			}
		}
		
		
		public string Nombre{
			get{
				return this.nombre;
			}
		}
	}
}
