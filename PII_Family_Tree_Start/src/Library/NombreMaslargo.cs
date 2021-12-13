namespace Library
{
    public class NombreMaslargo : IVisitor
    {
        string resultado="";
        string Resultado {
            get{
                return this.resultado;
            }
            set{
                this.resultado = value;
            }
        }

        public  void  Visitar(Node node)
        {
            if (this.Resultado.Length <= node.Persona.Name.Length) 
            {
                this.Resultado = node.Persona.Name;
            }
            foreach (Node child in node.Children)
            {
                child.Aceptar(this);
            } 
        }
    }
}