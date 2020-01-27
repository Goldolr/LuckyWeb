using LuckyWeb.Models.Respuestas;
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
        public Guid IDpreguntas { get; set; }
        public Boolean EstadoPreguntas { get; set; }

        [ForeignKey("FK_Respuesta1Pregunta")]
        [Display(Name = "¿Has adoptado anteriormente alguna mascota?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public Guid IDrespuesta1 { get; set; }
        [Display(Name = "¿Has adoptado anteriormente alguna mascota?")]
        public Respuesta1 FK_Respuesta1Pregunta { get; set; }

        [ForeignKey("FK_Respuesta2Pregunta")]
        [Display(Name = "¿Tienes más mascotas?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public Guid IDrespuesta2 { get; set; }
        [Display(Name = "¿Tienes más mascotas?")]
        public Respuesta2 FK_Respuesta2Pregunta { get; set; }

        [ForeignKey("FK_Respuesta3Pregunta")]
        [Display(Name = "¿Tienes hijos?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public Guid IDrespuesta3 { get; set; }
        [Display(Name = "¿Tienes hijos?")]
        public Respuesta3 FK_Respuesta3Pregunta { get; set; }

        [ForeignKey("FK_Respuesta4Pregunta")]
        [Display(Name = "¿Tienes un trabajo estable?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public Guid IDrespuesta4 { get; set; }
        [Display(Name = "¿Tienes un trabajo estable?")]
        public Respuesta4 FK_Respuesta4Pregunta { get; set; }

        [ForeignKey("FK_Respuesta5Pregunta")]
        [Display(Name = "¿Quién se va a encargar de la mascota?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public Guid IDrespuesta5 { get; set; }
        [Display(Name = "¿Quién se va a encargar de la mascota?")]
        public Respuesta5 FK_Respuesta5Pregunta { get; set; }

        [ForeignKey("FK_Respuesta6Pregunta")]
        [Display(Name = "¿Cuál es el horario disponible que tienes para la mascota?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public Guid IDrespuesta6 { get; set; }
        [Display(Name = "¿Cuál es el horario disponible que tienes para la mascota?")]
        public Respuesta6 FK_Respuesta6Pregunta { get; set; }

        [ForeignKey("FK_Respuesta7Pregunta")]
        [Display(Name = "¿Has considera lo que cuesta criar a una mascota?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public Guid IDrespuesta7 { get; set; }
        [Display(Name = "¿Has considera lo que cuesta criar a una mascota?")]
        public Respuesta7 FK_Respuesta7Pregunta { get; set; }

        [ForeignKey("FK_Respuesta8Pregunta")]
        [Display(Name = "¿Has adoptado anteriormente alguna mascota?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public Guid IDrespuesta8 { get; set; }
        [Display(Name = "¿Has adoptado anteriormente alguna mascota?")]
        public Respuesta8 FK_Respuesta8Pregunta { get; set; }

        [ForeignKey("FK_Respuesta9Pregunta")]
        [Display(Name = "¿Has adoptado anteriormente alguna mascota?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public Guid IDrespuesta9 { get; set; }
        [Display(Name = "¿Has adoptado anteriormente alguna mascota?")]
        public Respuesta9 FK_Respuesta9Pregunta { get; set; }

        [ForeignKey("FK_Respuesta10Pregunta")]
        [Display(Name = "¿Has adoptado anteriormente alguna mascota?")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public Guid IDrespuesta10 { get; set; }
        [Display(Name = "¿Has adoptado anteriormente alguna mascota?")]
        public Respuesta10 FK_Respuesta10Pregunta { get; set; }



        //[Display(Name = "¿Has adoptado anteriormente alguna mascota?")]
        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //public string Pregunta1 { get; set; }
        //[Display(Name = "¿Por qué deseas adoptar?")]
        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //public string Pregunta2 { get; set; }
        //[Display(Name = "¿Tienes más mascotas?")]
        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //public string Pregunta3 { get; set; }
        //[Display(Name = "¿Describe el lugar donde vives?")]
        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //public string Pregunta4 { get; set; }
        //[Display(Name = "¿Tienes hijos?")]
        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //public string Pregunta5 { get; set; }
        //[Display(Name = "¿Tamaño de su lugar de residencia?")]
        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //public string Pregunta6 { get; set; }
        //[Display(Name = "¿Tienes un trabajo estable?")]
        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //public string Pregunta7 { get; set; }
        //[Display(Name = "¿Quién se va a encargar de la mascota?")]
        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //public string Pregunta8 { get; set; }
        //[Display(Name = "¿Cuál es el horario disponible que tienes para la mascota?")]
        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //public string Pregunta9 { get; set; }
        //[Display(Name = "¿Has considera lo que cuesta criar a una mascota?")]
        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //public string Pregunta10 { get; set; }
    }
}
