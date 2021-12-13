namespace Library
{
    public class HijoMayor : IVisitor
    {
        public Persona Hijomayor {get; private set;}

        public void Visitar(Node nodo)
        {
            if (nodo.Children.Count == 0)
            {
                if (this.Hijomayor == null)
                {
                    this.Hijomayor = nodo.Persona;
                }
                else
                {
                    if (nodo.Persona.Edad > this.Hijomayor.Edad)
                    {
                        this.Hijomayor = nodo.Persona;
                    }
                }
            }
            else
            {
                foreach (Node child in nodo.Children) 
                {
                    child.Aceptar(this);
                }
            }
        }
    }
}