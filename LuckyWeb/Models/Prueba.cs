using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models
{
    [Table("tbl_Prueba")]
    public class Prueba
    {
        [Key]
        public int IDprueba { get; set; }
        [Display(Name ="Prueba")]
        public Boolean EstadoPrueba { get; set; }
        [ForeignKey("FK_EntrevistaPrueba")]
        [Display(Name ="Aprobación entrevista")]
        public int IDentrevista { get; set; }
        [Display(Name = "Aprobación entrevista")]
        public Entrevista FK_EntrevistaPrueba { get; set; }
        public List<Entrevista> Entrevistas { get; set; }
    }
}
