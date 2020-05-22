using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Interfaces
{
    public interface IFormulaInstructions
    {
        public int FormulaInstructionsId { get; set; }
        public int FormulaId { get; set; }
        public List<string> Instruction { get; set; }

    }
}
