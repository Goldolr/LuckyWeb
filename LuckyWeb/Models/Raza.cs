using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Models
{
    [Table("tbl_Raza")]
    public class Raza
    {
        [Key]
        public Guid IDraza { get; set; }
        public String RazaMascota { get; set; }
    }
}
