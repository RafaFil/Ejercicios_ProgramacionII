using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }

        public double GetProductionCost()
        {
            double SumInsumos =0;
            double SumEquipment=0;
            double Total =0;
            foreach (Step step in steps)
            {
                SumInsumos= SumInsumos + Convert.ToDouble(step.Input.UnitCost);
                SumEquipment=SumEquipment+ (Convert.ToDouble(step.Equipment.HourlyCost) * Convert.ToDouble(step.Time));
            }
            Total = SumInsumos+SumEquipment;
            return Total;
        }

    }
}

/* se utilizo el patron expert pues el que posee toda la informacion necesaria para aplicar el 
GetProductionCost es la clase recipe*/