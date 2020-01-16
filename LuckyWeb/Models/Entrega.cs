using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models
{
    [Table("tbl_Entrega")]
    public class Entrega
    {
        [Key]
        public int IDentrega { get; set; }
    }
}
