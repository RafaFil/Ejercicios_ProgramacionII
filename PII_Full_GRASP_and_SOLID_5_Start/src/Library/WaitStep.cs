//-------------------------------------------------------------------------------
// <copyright file="WaitStep.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    // Agregada por OCP
    public class WaitStep : BaseStep
    {
        public WaitStep(string descrption, int time)
            : base(time)
        {
            this.Description = descrption;
        }

        public string Description { get; set; }

        public override double GetStepCost()
        {
            return this.Time;
        }

        public override string GetTextToPrint()
        {
            return $"Esperando '{this.Description}' durante {this.Time}";
        }
    }
}