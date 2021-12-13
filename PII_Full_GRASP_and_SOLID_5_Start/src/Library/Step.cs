//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    // Modificada por OCP
    public class Step : BaseStep
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
            : base(time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public Equipment Equipment { get; set; }

        // Agregado por Expert
        public override double GetStepCost()
        {
            return
                (this.Input.UnitCost * this.Quantity) +
                (this.Equipment.HourlyCost * this.Time);
        }

        // Agregado por SRP
        public override string GetTextToPrint()
        {
            return $"{this.Quantity} de '{this.Input.Description}' " +
                $"usando '{this.Equipment.Description}' durante {this.Time}";
        }
    }
}