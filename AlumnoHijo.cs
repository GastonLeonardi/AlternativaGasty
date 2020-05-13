using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public sealed class AlumnoHijo : Persona
    {
        public Institucion InstitucionPerteneciente { get; set; }
        public bool Borrado { get{return Borrado;} set {Borrado = false;}}

        public AlumnoHijo(Institucion institucion, string nombreApellido, int numeroDeDocumento, DateTime fechaDeNacimiento) : base (nombreApellido, numeroDeDocumento, fechaDeNacimiento)
        {
            InstitucionPerteneciente = institucion;
        }
    }
}
