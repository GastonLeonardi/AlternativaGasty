using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public sealed class Docente : Persona
    {
        public bool Borrado {get{ return Borrado; } set{Borrado = false;}}

        public Docente(string nombreApellido, int numeroDeDocumento, DateTime fechaDeNacimiento) : base (nombreApellido, numeroDeDocumento, fechaDeNacimiento)
        {
            
        }
        
    }
}
