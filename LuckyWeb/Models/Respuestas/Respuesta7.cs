using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models.Respuestas
{
    [Table("tbl_Respuesta7")]
    public class Respuesta7
    {
        [Key]
        public Guid IDrespuesta7 { get; set; }
        public string Respuesta { get; set; }
    }
}
