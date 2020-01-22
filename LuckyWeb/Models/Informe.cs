using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models
{
    [Table("tbl_Informe")]
    public class Informe
    {
        [Key]
        public int IDinforme { get; set; }
        public string Detalle { get; set; }
        [ForeignKey("FK_PruebaInforme")]
        public int IDprueba { get; set; }
        public Prueba FK_PruebaInforme { get; set; }
    }
}
