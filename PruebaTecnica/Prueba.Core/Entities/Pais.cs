using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Core.Entities
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Alpha3Code { get; set; }
        public string Iso31662 { get; set; }
        public List<Equipo> Equipo { get; set; }
    }
}


