﻿using System;
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
        public string NombreMascota { get; set; }
        [Display(Name = "Edad")]
        public int EdadMascota { get; set; }
        public string Raza { get; set; }
        [Required]
        public string Esterilizado { get; set; }
        [Display(Name ="Adoptado")]
        public Boolean Estado { get; set; }
        public List<FormularioEncuesta> FormularioEncuestas { get; set; }
    }
}
