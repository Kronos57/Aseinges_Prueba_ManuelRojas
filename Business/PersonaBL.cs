using Data;
using Entities;
using System.Collections.Generic;

namespace Business
{
    public class PersonaBL
    {
        public List<Persona> Consulta(string numeroDocumento = null)
        {
            PersonaDAL personaDAL = new PersonaDAL();
            List<Persona> personas = personaDAL.ConsultarPersona(numeroDocumento);

            return personas;
        }
    }
}
