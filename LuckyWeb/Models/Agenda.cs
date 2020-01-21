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
        public DateTime FechaAgenda { get; set; }
        [ForeignKey("FK_UserAgenda")]
        public Guid IDuser { get; set; }
        public User FK_UserAgenda { get; set; }
    }
}
