using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models
{
    [Table("tbl_Agenda")]
    public class Agenda
    {
        [Key]
        public int IDagenda { get; set; }
        [Display(Name ="Cita")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime FechaAgenda { get; set; }
        [ForeignKey("FK_UserAgenda")]
        [Display(Name = "Adoptante")]
        public Guid IDuser { get; set; }
        [Display(Name ="Adoptante")]
        public User FK_UserAgenda { get; set; }
        //asdasdasd
    }
}
