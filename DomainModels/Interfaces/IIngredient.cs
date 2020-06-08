using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Interfaces
{
    public interface IIngredient
    {
        public int IngredientId { get; set; }
        public int IFormulaId { get; set; }
        public string IngredientName { get; set; }
        public IMeasurement Measurement { get; set; }
    }
}
