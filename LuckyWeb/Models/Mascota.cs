using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models
{
    [Table("tbl_Mascota")]
    public class Mascota
    {
        [Key]
        public Guid IdMascota { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string NombreMascota { get; set; }
        [Display(Name = "Edad")]
        [Range(0, 100, ErrorMessage = "La mascota debe tener una edad de cero años o mayor")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int EdadMascota { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Raza { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Esterilizado { get; set; }

        //------------Add field mascota------------//
        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //[Display(Name = "Edad")]
        //[ForeignKey("FK_EsterilizadoMascota")]
        //public Guid IDesterilizado { get; set; }
        //[Display(Name = "Edad")]
        //public Esterilizado FK_EsterilizadoMascota { get; set; }
        //------------End------------//

        [Display(Name ="Adoptado")]
        public Boolean Estado { get; set; }
        public List<FormularioEncuesta> FormularioEncuestas { get; set; }
    }
}
