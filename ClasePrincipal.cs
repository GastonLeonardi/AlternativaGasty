using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClasePrincipal
    {
        private static ClasePrincipal InstanciaSingleton;
        public static ClasePrincipal ObtenerIntanciaSingleton()
        {
            if (InstanciaSingleton == null)
            {
                InstanciaSingleton = new ClasePrincipal();
            }
            return InstanciaSingleton;
        } // Obtener Unica Instancia

        private List<Institucion> ListaDeInstitucines { get; set; }

        public ClasePrincipal()
        {
            ListaDeInstitucines = new List<Institucion>();
        }

        //ABM Director
        public void Agregar(string identificadorDeLaInstitucion, Director director)
        {
            BuscarInstitucionEnLista(identificadorDeLaInstitucion).DirectorDeLaInstitucion = director;
        }
        public void Borrar(string identificadorDeLaInstitucion)
        {
            BuscarInstitucionEnLista(identificadorDeLaInstitucion).DirectorDeLaInstitucion.Borrado = true;
        }
        public void Modificar(int numeroDeDocumento)
        {
        }//Todo : Terminar El modificar De Director

        //AGM Docente
        public void Agregar(string identificadorDeLaInstitucion, string numeroDeLaSala, Docente docente)
        {
            BuscarInstitucionEnLista(identificadorDeLaInstitucion).BuscarSala(numeroDeLaSala).DocenteACargo = docente; // Busca la institucion y la sala por medio de los identificadores y luego agrrega al docente.
        }
        public void Borrar(string identificadorDeLaInstiucion, string numeroDeLaSala)
        {
            BuscarInstitucionEnLista(identificadorDeLaInstiucion).BuscarSala(numeroDeLaSala).DocenteACargo.Borrado = true;
        }
        public void Modificar(string idetificadorDeLaIntitucion, string numeroDeLaSala)
        {
        }//Todo : Terminar El modificar De Docente

        //AGM Alumno
        public void Agregar(string identificadorDeLaInstitucion, string numeroDeLaSala, AlumnoHijo almuno, Padre padre)
        {
            BuscarInstitucionEnLista(identificadorDeLaInstitucion).AgregarPadre(padre, almuno); //Agrega El padre con su hijo a la lista
            BuscarInstitucionEnLista(identificadorDeLaInstitucion).BuscarSala(numeroDeLaSala).AgrregarAlumno(almuno);// Agrega el alumno a la sala

        }
        public void Borrar(string identificadorDeLaInstitucion, int numeroDeDocumento)
        {
            BuscarInstitucionEnLista(identificadorDeLaInstitucion).EncontrarAlmuno(numeroDeDocumento);
        }
        public void Modificar()
        {
        }//Todo : Terminar El modificar De Almunos

        public Institucion BuscarInstitucionEnLista(string identificadorDeLaInstitucion)
        {
            return ListaDeInstitucines.Find(x => x.Identificador == identificadorDeLaInstitucion);
        }

    }
}
