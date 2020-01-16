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
    }
}
