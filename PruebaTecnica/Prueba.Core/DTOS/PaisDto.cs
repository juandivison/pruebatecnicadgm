using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Core.DTOS
{
    public class PaisDto : BaseEntity
    {
        public string Nombre { get; set; }
        public string Alpha3Code { get; set; }
        public string Iso31662 { get; set; }
    }
}
