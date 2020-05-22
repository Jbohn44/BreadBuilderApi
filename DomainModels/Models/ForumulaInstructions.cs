using DomainModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Models
{
    public class ForumulaInstructions : IFormulaInstructions
    {
        public int FormulaInstructionsId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int FormulaId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        // think about making Instructions a dictionary
        public List<string> Instruction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
