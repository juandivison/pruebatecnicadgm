using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Prueba.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual List<Equipo> Equipos { get; set; }
    }
}
