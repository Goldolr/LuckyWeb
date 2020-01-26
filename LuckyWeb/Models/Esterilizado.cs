using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models
{
    [Table("tbl_Esterilizado")]
    public class Esterilizado
    {
        [Key]
        public Guid IDesterilizad { get; set; }
        public string EstadoEsterilizado { get; set; }
    }
}
