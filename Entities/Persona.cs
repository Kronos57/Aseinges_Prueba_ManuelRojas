namespace Entities
{
    public class Persona
    {
        public string NumeroDocumento { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string CorreoElectronico { get; set; }

        public Persona()
        {

        }

        public Persona(string numeroDocumento, string nombre, string apellido, string direccion, string telefono, string correoElectronico)
        {
            this.NumeroDocumento = numeroDocumento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.CorreoElectronico = correoElectronico;
        }
    }
}
