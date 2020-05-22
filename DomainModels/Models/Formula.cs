using DomainModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Models
{
    public class Formula : IFormula
    {
        public int FormulaId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IIngredient> Ingredients { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FormulaName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IFormulaInstructions> FormulaInstructions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
