using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prueba.Core.Entities
{
    public class Estado : BaseEntity
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Key]
        //public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual List<Equipo> Equipos { get; set; }
    }
}
