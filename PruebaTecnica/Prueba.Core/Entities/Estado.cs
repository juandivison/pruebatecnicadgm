using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Core.Entities
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Equipo> Equipo { get; set; }
    }
}
