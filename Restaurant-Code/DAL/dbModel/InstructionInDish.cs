using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InstructionInDish
    {
        [Key]
        [Column(Order = 1)]
        public int InstructionID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int DishID { get; set; }

        [Key]
        [Column(Order = 3)]
        public int Step { get; set; }
    }
}
