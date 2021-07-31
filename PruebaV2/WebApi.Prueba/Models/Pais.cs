using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Prueba.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Alpha3Code { get; set; }
        public string Iso31662 { get; set; }
        public virtual List<Equipo> Equipos { get; set; }
    }
}


