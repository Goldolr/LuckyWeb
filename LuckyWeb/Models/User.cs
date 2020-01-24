using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models
{
    [Table("tbl_User")]
    public class User
    {
        [Key]
        public Guid IdUser { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Correo { get; set; }
        [Display(Name = "Contraseña")]
        public string Contrasenia { get; set; }
        [Display(Name ="Fecha de Nacimiento")]
        [Required(ErrorMessage ="Este campo es obligatorio")]
        public DateTime FechaNacimiento { get; set; }
        public List<FormularioEncuesta> FormularioEncuestas { get; set; }
    }
}
