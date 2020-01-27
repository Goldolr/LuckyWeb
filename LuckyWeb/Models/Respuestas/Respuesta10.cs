using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models.Respuestas
{
    [Table("tbl_Respuesta10")]
    public class Respuesta10
    {
        [Key]
        public Guid IDrespuesta10 { get; set; }
        public string Respuesta { get; set; }
    }
}
