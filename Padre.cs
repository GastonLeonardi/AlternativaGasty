using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public sealed class Padre : Persona
    {
        public List<AlumnoHijo> ListaDeHijos;

        public void AgregarHijo(AlumnoHijo hijo)
        {

            if (ListaDeHijos.Exists(x => x.NumeroDeDocumento == hijo.NumeroDeDocumento) == false)
            {
                ListaDeHijos.Add(hijo);
            }
            
        }

        public Padre(string nombreApellido, int numeroDeDocumento, DateTime fechaDeNacimineto) : base(nombreApellido, numeroDeDocumento , fechaDeNacimineto)
        {

        }
    }
}
