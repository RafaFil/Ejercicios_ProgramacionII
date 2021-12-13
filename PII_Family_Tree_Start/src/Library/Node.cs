using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {

        private List<Node> children = new List<Node>();

        public Persona Persona {get; private set;}

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Persona persona)
        {
            this.Persona=persona;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Aceptar(IVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }
}
