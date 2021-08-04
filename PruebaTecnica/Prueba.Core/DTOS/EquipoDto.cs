using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Core.DTOS
{
    public class EquipoDto : BaseEntity
    {
        public string Nombre { get; set; }        
        public int PaisId { get; set; }
        public int EstadoId { get; set; }
        public int JugadorId { get; set; }
    }
}
