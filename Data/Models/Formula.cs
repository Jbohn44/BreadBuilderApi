using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class Formula
    {
        [Key]
        public int FormulaId { get; set; }
        public string FormulaName { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<FormulaInstruction> FormulaInstructions { get; set; }

    }
}
