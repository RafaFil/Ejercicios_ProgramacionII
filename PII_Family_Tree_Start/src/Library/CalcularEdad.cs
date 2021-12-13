namespace Library
{
    public class CalcularEdad : IVisitor
    {
        public int EdadTotal {get; private set;}

        public void Visitar(Node node)
        {
            this.EdadTotal =node.Persona.Edad+ this.EdadTotal;
            foreach (Node child in node.Children)
            {
                this.Visitar(child);
            }
        }
    }
}