
using System;
using System.Collections.Generic;

namespace Metodologias2
{
	
	public class Comision
	{
		private int numero;
		private Materia materia;
		private Aula aula;
		private string horario;
		private Profesor Profesor;
		private int capacidad;
		private List<Alumno> alumnos;
		public Comision(int numero, Materia materia, Aula aula, string horario,Profesor profesor, int capacidad){
			this.numero=numero;
			this.materia=materia;
			this.aula=aula;
			this.horario=horario;
			this.Profesor=profesor;
			this.capacidad=capacidad;
			this.alumnos=new List<Alumno>();
		}
		
		public string Materia{
			get{
				return materia.Nombre;
			}
		}
		
		public int Numero{
			get{
				return this.numero;
			}
		}
		
		public bool AltaAlumno(Alumno alum){
			if(capacidad<alumnos.Count){
				alumnos.Add(alum);
				return true;
			}
			else return false;
		}
		
		public void bajaAlumno(Alumno alum){
			int index=0;
			bool final=false;
			
			while(!final){
				if(this.alumnos[index].Dni==alum.Dni){
					this.alumnos.RemoveAt(index);
					final=true;
				}
				if(index+1==this.alumnos.Count) final=true;
				index++;
			}
		}
	}
}
