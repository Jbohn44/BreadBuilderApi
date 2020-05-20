using DomainModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IFormulaRepository
    {
        public Task<IFormula> Get(int formulaId);
        public Task<IFormula> Save(IFormula formula);
        public Task Delete(int formulaId);
    }
}
