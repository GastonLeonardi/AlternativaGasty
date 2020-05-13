using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public sealed class Director : Persona
    {
        public bool Borrado {get{ return Borrado;} set{ Borrado = false;}}
        public Director(string nombreApellido, int dNI, DateTime fechaDeNacimiento) : base (nombreApellido, dNI, fechaDeNacimiento)
        {

        }
    }
}
