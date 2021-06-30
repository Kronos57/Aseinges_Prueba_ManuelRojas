using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class PersonaDAL
    {
        public List<Persona> ConsultarPersona(string numeroDocumento = null) {

            List<Persona> personasList = new List<Persona>();

            personasList.Add(new Persona("80457488", "Armando", "Casas", "Cra 58 # 65-27", "4157845", "armandoc@gmail.com"));
            personasList.Add(new Persona("52487412", "Camila", "Fajardo", "Cra 7 # 45-12", "2748526", "camilafaj@gmail.com"));
            personasList.Add(new Persona("80415231", "Pedro", "Gutierrez", "Calle 72 # 11-27", "3457841", "pedrogut@gmail.com"));
            personasList.Add(new Persona("50234789", "Mariana", "Gómez", "Diag 24b # 18-85", "7112592", "marigomez@gmail.com"));
            personasList.Add(new Persona("51235114", "Juliana", "Saavedra", "Transv 24 # 17-56", "2524071", "juli.saavedra@gmail.com"));

            if (!string.IsNullOrEmpty(numeroDocumento))
            {
                personasList = personasList.Where(x => x.NumeroDocumento == numeroDocumento).ToList();
            }

            return personasList;
        }
    }
}
