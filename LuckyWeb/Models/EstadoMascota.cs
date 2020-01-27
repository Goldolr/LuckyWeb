using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models
{
    [Table("tbl_EstadoMascota")]
    public class EstadoMascota
    {
        [Key]
        public Guid IDestadoMascota { get; set; }
        public string Aprobacion { get; set; }
    }
}
