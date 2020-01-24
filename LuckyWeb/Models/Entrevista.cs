using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models
{
    [Table("tbl_Entrevista")]
    public class Entrevista
    {
        [Key]
        public int IDentrevistas { get; set; }
        [ForeignKey("FK_AgendaEntrevista")]
        [Display(Name ="Fecha cita")]
        public int IDagenda { get; set; }
        [Display(Name = "Fecha cita")]
        public Agenda FK_AgendaEntrevista { get; set; }
        [ForeignKey("FK_UserEntrevista")]
        [Display(Name ="Adoptante")]
        public Guid IDuser { get; set; }
        [Display(Name = "Adoptante")]
        public User FK_UserEntrevista { get; set; }
        [Display(Name ="Aprobado")]
        public Boolean EstadoEntrevista { get; set; }
        public List<Agenda> Agendas { get; set; }
    }
}
