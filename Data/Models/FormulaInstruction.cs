using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Data.Models
{
    public class FormulaInstruction
    {
        [Key]
        public int FormulaInstructionId { get; set; }
        public int FormulaId { get; set; }
        public List<string> Instructions { get; set; }
    }
}
