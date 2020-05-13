using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Persona
    {
        public string NombreApellido { get; set; }
        public int NumeroDeDocumento { get; set; }
        public DateTime FechaDeNacimiento { get; set; } 

        public Persona(string nombreApellido, int numeroDeDocumento, DateTime fechaDeNacimiento)
        {
            NombreApellido = nombreApellido;
            NumeroDeDocumento = numeroDeDocumento;
            FechaDeNacimiento = fechaDeNacimiento;
        }
    }
}
