using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Interfaces
{
    public interface IIngredient
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
    }
}
