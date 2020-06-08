using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class Context : DbContext
    {
        public DbSet<Formula> Formulas { get; set; }
        public DbSet<FormulaInstruction> FormulaInstructions { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Measurement> Measurements { get; set; }


    }
}
