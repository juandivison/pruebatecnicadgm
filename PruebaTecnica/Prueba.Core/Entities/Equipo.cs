using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Core.Entities
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombrePaisIso3 { get; set; } // (Codigo de 3 digitos ISO3) (Dropdown)        
        public int PaisId { get; set; }
        public int EstadoId { get; set; }
        public int JugadorId { get; set; }
        public virtual List<Jugador> Jugadores { get; set; }        
        public Pais Pais { get; set; }

    }
}
