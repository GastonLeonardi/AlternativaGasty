using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public  class Institucion
    {
        public string NombreDeLaInstitucion { get; set; }
        public string Identificador { get; set; }
        public List<Sala> ListaDeSalas { get; set; }
        public List<Padre> ListaDePadres { get; set; }
        public Director DirectorDeLaInstitucion { get; set; }


        public Sala BuscarSala(string numeroDeLaSala)
        {
            return ListaDeSalas.Find(x => x.NumeroDeLaSala == numeroDeLaSala);
        }
        public void EncontrarAlmuno(int numeroDeDocumento)
        {
            foreach (var item in ListaDeSalas)
            {
                item.BorrarAlmuno(numeroDeDocumento);  
            }

            /*Otra Opcion
            foreach (var item in ListaDeSalas)
            {
                item.ListaDeAlumnos.Exists(x => x.NumeroDeDocumento == numeroDeDocumento);
            }*/

        }
        public void AgregarPadre(Padre padre, AlumnoHijo hijo)
        {
            if (ListaDePadres.Exists(x=> x.NumeroDeDocumento == padre.NumeroDeDocumento) == false)
            {
                padre.AgregarHijo(hijo);
                ListaDePadres.Add(padre);
            }
            else
            {
                ListaDePadres.Find(x => x.NumeroDeDocumento == padre.NumeroDeDocumento).AgregarHijo(hijo);
            }
           
        }
    }
}
