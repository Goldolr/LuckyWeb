using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models.Respuestas
{
    [Table("tbl_Respuesta2")]
    public class Respuesta2
    {
        [Key]
        public Guid IDrespuesta2 { get; set; }
        public string Respuesta { get; set; }
    }
}
