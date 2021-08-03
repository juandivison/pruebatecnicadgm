using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Core.Entities
{
    public class Pais : BaseEntity
    {       
        public string Nombre { get; set; }
        public string Alpha3Code { get; set; }
        public string Iso31662 { get; set; }
        public virtual List<Equipo> Equipos { get; set; }
    }
}


