
using System;
using System.Collections.Generic;

namespace Metodologias2
{
	
	public class Inscripcion
	{
		
		public bool inscribir(int numComision, int dni,List<Alumno> alumnos, List<List<Comision>> comiciones,Materia materia){
			Comision com=buscarComision(comiciones,numComision,materia.Nombre);
			
			if(com.AltaAlumno(buscarAlumon(alumnos,dni))) return true;
			else return false;
		}
		
		public void bajaInscripcion(int numComision, int dni,List<Alumno> alumnos, List<List<Comision>> comiciones,Materia materia){
			Comision com=buscarComision(comiciones,numComision,materia.Nombre);
			
			com.bajaAlumno(buscarAlumon(alumnos,dni));
		}
		
		private Comision buscarComision(List<List<Comision>> comiciones,int numComision,string nomMateria){
			foreach(Comision i in comiciones[numComision]){
				if(i.Materia==nomMateria) return i;
			}
			return null;
		}
		
		private Alumno buscarAlumon(List<Alumno> alumnos, int dni){
			foreach(Alumno i in alumnos){
				if(i.Dni==dni) return i;
			}
			
			return null;
		}
	}
}
