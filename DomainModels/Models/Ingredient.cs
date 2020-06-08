using DomainModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Models
{
    public class Ingredient : IIngredient
    {
        public int IngredientId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string IngredientName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IFormulaId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMeasurement Measurement { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
