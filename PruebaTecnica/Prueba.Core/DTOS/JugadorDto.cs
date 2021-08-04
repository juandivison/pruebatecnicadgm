using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Core.DTOS
{
    public class JugadorDto : BaseEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string Pasaporte { get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public int IdEquipo { get; set; }
        public int EstadoId { get; set; }  //(Activo, Cancelado, Agente Libre)
    }
}
