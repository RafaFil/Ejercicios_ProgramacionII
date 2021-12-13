using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(new Persona("Jonathan",19));
            Node n2 = new Node(new Persona("Joseph",20));
            Node n3 = new Node(new Persona("Jotaro",17));
            Node n4 = new Node(new Persona("Josuke",16));
            Node n5 = new Node(new Persona("Giovani Giorno",15));
            Node n6 = new Node(new Persona("Jolyne",19));
            Node n7 = new Node(new Persona("Johnny",19));
            Node n8 = new Node(new Persona("Josuke",19));
            Node n9 = new Node(new Persona("Parte 9",17));

            
            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n4.AddChildren(n8);
            n4.AddChildren(n9);


            // visitar el árbol aquí
            CalcularEdad VisitorEdad = new CalcularEdad();
            n1.Aceptar(VisitorEdad);
            Console.WriteLine(VisitorEdad.EdadTotal);

            HijoMayor VisitorMayor = new HijoMayor();
            n1.Aceptar(VisitorMayor);
            Console.WriteLine(VisitorMayor.Hijomayor.Name);

            NombreMaslargo VisitorLargo = new NombreMaslargo();
            n1.Aceptar(VisitorLargo);


        }
    }
}
