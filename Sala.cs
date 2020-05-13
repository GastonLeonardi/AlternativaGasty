using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Sala
    {
        public string NumeroDeLaSala { get; set; }
        public Docente DocenteACargo { get; set; }
        public List<AlumnoHijo> ListaDeAlumnos { get; set; }

        public void BuscarAlumno(int numeroDeDocumento)
        {
            ListaDeAlumnos.Exists(x => x.NumeroDeDocumento == numeroDeDocumento);
        }// MetodoExtra
        
        public void AgrregarAlumno(AlumnoHijo alumno)
        {
            ListaDeAlumnos.Add(alumno);
        }
        public void BorrarAlmuno(int numeroDeDocumento)
        {
            ListaDeAlumnos.RemoveAll(x => x.NumeroDeDocumento == numeroDeDocumento);
        }
    }
}
