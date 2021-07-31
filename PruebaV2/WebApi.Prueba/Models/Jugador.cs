using System.Collections.Generic;

namespace WebApi.Prueba.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string Pasaporte { get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public int IdEquipo { get; set; }
        public int EstadoId { get; set; }  //(Activo, Cancelado, Agente Libre)
        public virtual List<Equipo> Equipos { get; set; }
        public Estado Estado { get; set; }
    }
}
