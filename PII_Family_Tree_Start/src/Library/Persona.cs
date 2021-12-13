using System;

namespace Library
{
    public class Persona
    {
        public string Name {get;}
        public int Edad {get;}

        public Persona (string name, int edad)
        {
            this.Name=name;
            this.Edad=edad;
        }
    }
}