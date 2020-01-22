﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models
{
    [Table("tbl_FormularioEncuesta")]
    public class FormularioEncuesta
    {
        [Key]
        public int IDformularioEncuesta { get; set; }
        [ForeignKey("FK_UserFormularioEncuesta")]
        public Guid IDuser { get; set; }
        [Display(Name ="Nombre")]
        public User FK_UserFormularioEncuesta { get; set; }
        [ForeignKey("FK_MascotaFormularioEncuesta")]
        public Guid IDmascota { get; set; }
        [Display(Name = "Mascota")]
        public Mascota FK_MascotaFormularioEncuesta { get; set; }
        [ForeignKey("FK_PreguntaFormularioEncuesta")]
        public int IDpregunta { get; set; }
        public Pregunta FK_PreguntaFormularioEncuesta { get; set; }
    }
}
