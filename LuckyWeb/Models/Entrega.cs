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
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Detalle { get; set; }
        [ForeignKey("FK_InformeEntrega")]
        [Display(Name ="Informe")]
        public int IDinforme { get; set; }
        [Display(Name = "Informe")]
        public Informe FK_InformeEntrega { get; set; }

    }
}
