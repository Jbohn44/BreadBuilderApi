using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Interfaces
{
    public interface IFormula
    {
        public int FormulaId { get; set; }
        public string FormulaName { get; set; }
        public List<IIngredient> Ingredients { get; set; }
        public List<IFormulaInstructions> FormulaInstructions { get; set; }
    }
}
