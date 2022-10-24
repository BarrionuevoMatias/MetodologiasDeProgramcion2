
using System;
using System.Collections.Generic;

namespace Metodologias2
{
	
	public class Instituto
	{
		private string nombre;
		private List<Carrera> carreras;
		private List<Alumno> alumnos;
		private List<Profesor> profesores;
		private List<Aula> aulas;
		private List<List<Comision>> comiciones;
		private Inscripcion inscripcion=new Inscripcion();
		
		public Instituto(string nombre){
			this.nombre=nombre;
			this.alumnos=new List<Alumno>();
			this.profesores=new List<Profesor>();
			this.carreras=new List<Carrera>();
			this.aulas=new List<Aula>();
			this.comiciones=new List<List<Comision>>();
		}
		
		public bool inscribirAlumno(int numComision,int dni,Materia materia){
			if(inscripcion.inscribir(numComision,dni,alumnos,comiciones,materia)) return true;
			else return false;
		}
		
		public void bajaAlumnoComision(int numComision,int dni,Materia materia){
			inscripcion.bajaInscripcion(numComision,dni,alumnos,comiciones,materia);
		}
		
		public void altaAlumno(Alumno alum){
			this.alumnos.Add(alum);
		}
		
		public void bajaAlumno(int dni){
			int index=0;
			bool final=false;
			
			while(!final){
				if(this.alumnos[index].Dni==dni){
					this.alumnos.RemoveAt(index);
					final=true;
				}
				if(index+1==this.alumnos.Count) final=true;
				index++;
			}
		}
		
		public void altaProfesor(Profesor profe){
			this.profesores.Add(profe);
		}
		
		public void bajaProfesor(int dni){
			int index=0;
			bool final=false;
			
			while(!final){
				if(this.profesores[index].Dni==dni){
					this.profesores.RemoveAt(index);
					final=true;
				}
				
				if(index+1==this.alumnos.Count) final=true;
				index++;
			}
		}
		
		public void altaCarrera(Carrera carrera){
			this.carreras.Add(carrera);
		}
		
		public void bajaCarrera(string nombre){
			int index=0;
			bool final=false;
			
			while(!final){
				if(this.carreras[index].Nombre==nombre){
					this.carreras.RemoveAt(index);
					final=true;
				}
				
				if(index+1==this.carreras.Count) final=true;
				index++;
			}
		}
		
		public void altaAula(Aula aula){
			this.aulas.Add(aula);
		}
		
		public void BajaAula(int numero){
			int index=0;
			bool final=false;
			
			while(!final){
				if(this.aulas[index].Numero==numero){
					this.aulas.RemoveAt(index);
					final=true;
				}
				
				if(index+1==this.aulas.Count) final=true;
				index++;
			}
		}
		
		public void AltaComision(int numero,int capacidad, Profesor profe, string horario, Aula aula, Materia mat){
			if(comiciones.Count <= numero) comiciones[numero]= new List<Comision>();
			
			Comision com=new Comision(numero,mat,aula,horario,profe,capacidad);
			comiciones[numero].Add(com);
		}
		
		
		
	}
}
