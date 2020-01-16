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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        [Display(Name = "Contraseña")]
        public string Contrasenia { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
