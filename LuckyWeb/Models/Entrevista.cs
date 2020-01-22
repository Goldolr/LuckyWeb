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
        public int IDagenda { get; set; }
        public Agenda FK_AgendaEntrevista { get; set; }
        [ForeignKey("FK_UserEntrevista")]
        public Guid IDuser { get; set; }
        public User FK_UserEntrevista { get; set; }
        public Boolean EstadoEntrevista { get; set; }
        public List<Agenda> Agendas { get; set; }
    }
}
