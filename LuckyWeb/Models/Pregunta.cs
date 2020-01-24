using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models
{
    [Table("tbl_Pregunta")]
    public class Pregunta
    {
        [Key]
        public int IDpreguntas { get; set; }
        [Display(Name = "¿Has adoptado anteriormente alguna mascota?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Pregunta1 { get; set; }
        [Display(Name = "¿Por qué deseas adoptar?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Pregunta2 { get; set; }
        [Display(Name = "¿Tienes más mascotas?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Pregunta3 { get; set; }
        [Display(Name = "¿Describe el lugar donde vives?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Pregunta4 { get; set; }
        [Display(Name = "¿Tienes hijos?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Pregunta5 { get; set; }
        [Display(Name = "¿Tamaño de su lugar de residencia?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Pregunta6 { get; set; }
        [Display(Name = "¿Tienes un trabajo estable?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Pregunta7 { get; set; }
        [Display(Name = "¿Quién se va a encargar de la mascota?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Pregunta8 { get; set; }
        [Display(Name = "¿Cuál es el horario disponible que tienes para la mascota?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Pregunta9 { get; set; }
        [Display(Name = "¿Has considera lo que cuesta criar a una mascota?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Pregunta10 { get; set; }
    }
}
