using System;
using System.Collections;

/*En esta clase se aplica el patron expert pues el unico metodo que es el de agregar algo al libro de Hechizo se utiliza con los elementos que posee elementos, sea desde
identificar el tipo asi como agregarlo o removerlo*/

namespace Program
{
    public class Elemento
    {
        private string name; // variables publicas y privadas
        private string type;
        private int defensa;
        private int ataque;

        public string Name
        {
            get {return this.name;}
            set {this.name = value;}
        }
        public string Type
        {
            get {return this.type;}
            set {this.type = value;}
        }
        public int Defensa
        {
            get {return this.defensa;}
            set {this.defensa=value;}
        }
        public int Ataque
        {
            get {return this.ataque;}
            set {this.ataque = value;}
        }

        public Elemento(string name, string type, int defensa, int ataque)  //constructor
        {
            this.Name = name;
            this.Type = type;   
            this.Defensa = defensa;
            this.Ataque = ataque;
        }

        private ArrayList libroHechizos = new ArrayList();
        public ArrayList LibroHechizos
        {
            get {return this.libroHechizos;}
            set {this.libroHechizos = value;}
        }

        public void AddHechizo(Elemento elemento)  // añade Hechizo al libro de hechizos
        {
            if (this.type=="Hechizo")
            {
                this.libroHechizos.Add(elemento);
                Console.WriteLine($"Se ha añadido {this.name} al libro de hechizos");
            }
            else
            {
                Console.WriteLine($"{this.name} no es un hechizo, imposible añiadir");
            }
        }

        public void RemoveHechizo(Elemento elemento)   // Remueve un hechizo
        {
            if (this.type=="Hechizo")
            {
                this.libroHechizos.Remove(elemento);
            }
            else
            {
                Console.WriteLine($"{this.name} no es un hechizo, imposible remover");
            }
        }
    }
}
