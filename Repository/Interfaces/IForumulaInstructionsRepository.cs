using DomainModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IForumulaInstructionsRepository
    {
        public Task<List<IFormulaInstructions>> GetFormulaInstructions(int FormulaId);
        public Task<IFormulaInstructions> Save(IFormulaInstructions instructions);
    }
}
