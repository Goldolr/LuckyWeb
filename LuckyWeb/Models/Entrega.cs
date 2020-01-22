using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models
{
    [Table("tbl_Entrega")]
    public class Entrega
    {
        [Key]
        public int IDentrega { get; set; }
        public Boolean Estado { get; set; }
        public string Detalle { get; set; }
        [ForeignKey("FK_InformeEntrega")]
        public int IDinforme { get; set; }
        public Informe FK_InformeEntrega { get; set; }

    }
}
