using Data.Models;
using DomainModels.Interfaces;
using DomainModels.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repos
{
    public class FormulaRepository : IFormulaRepository
    {
        private Context _context;

        public FormulaRepository(Context context)
        {
            _context = context;
        }
      

        public async Task<IFormula> Get(int formulaId)
        {
            var formula = await _context.Formulas.FirstOrDefaultAsync(f => f.FormulaId == formulaId);
            return Map(formula);
        }

        public async Task<IFormula> Save(IFormula formula)
        {
            var f = new Data.Models.Formula();
            return Map(f);
        }

        public Task Delete(int formulaId)
        {
            throw new NotImplementedException();
        }

        private IFormula Map(Data.Models.Formula formula)
        {
            List<IFormulaInstructions> formulaInstructions = new List<IFormulaInstructions>();
            List<IIngredient> ingredients = new List<IIngredient>();

            foreach(var fi in formula.FormulaInstructions)
            {
                formulaInstructions.Add(new DomainModels.Models.ForumulaInstructions 
                {
                    FormulaId = fi.FormulaId,
                    FormulaInstructionsId = fi.FormulaInstructionId,
                    Instruction = fi.Instructions
                    
                });
            }

            foreach(var i in formula.Ingredients)
            {
                ingredients.Add(new DomainModels.Models.Ingredient
                {
                    IFormulaId = i.FormulaId,
                    IngredientId = i.IngredientId,
                    IngredientName = i.IngredientName,
         
                });
            }

            return new DomainModels.Models.Formula
            {
                FormulaId = formula.FormulaId,
                FormulaName = formula.FormulaName,
                Ingredients = ingredients,
                FormulaInstructions = formulaInstructions
            };
        }
    }
}
