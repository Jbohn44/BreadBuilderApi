using DomainModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IIngredientRepository
    {
        public Task<IIngredient> Get(int ingredientId);
        public Task<IIngredient> Save(IIngredient ingredient);
        public Task Delete(int ingredientId);
    }
}
