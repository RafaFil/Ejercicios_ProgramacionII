using System;
using System.Collections;

//En esta clase de Enano, Se utilizan los metodos TotalAtaque y Total Defensa, pues la clase es la experta de informacion (se utilzia el patron expert)

namespace Program
{
    public class Enano
    {
        public string Nombre {get;}
        private int salud;
        private int ataque;
        private int defensa;
        public Elemento elemento {get; set;}
        private ArrayList items = new ArrayList();

        private int saludInicial;
        public Enano(string nombre, int salud, int ataque, int defensa)
        {
            this.Nombre = nombre;
            this.Salud = salud;
            this.Ataque = ataque;
            this.Defensa = defensa;

            saludInicial=salud;
        }
        public int Salud
        {
            get
            {
                return this.salud;
            }
            set
            {
                if (value >= 0)
                {
                    this.salud = value;
                }
            }        
        }
        public int Ataque
        {
            get
            {
                return this.ataque;
            }
            
            set
            {
                if (value >= 0)
                {
                    this.ataque = value;
                }
            }
        }
        public int Defensa
        {
            get
            {
                return this.defensa;
            }
            
            set
            {
                if (value >= 0)
                {
                    this.defensa = value;
                }
            }
        }

        public void EquiparItem(Elemento elemento)  //funciona
        {
            this.items.Add(elemento);
        }

        public void QuirarItem(Elemento elemento) 
        {
            this.items.Remove(elemento);
        }
        
        private int contadorAtaque = 0;

        public int TotalAtaque()
        {
            foreach (Elemento elemento in items)
            {
                contadorAtaque = contadorAtaque + elemento.Ataque;
            }
            contadorAtaque = contadorAtaque + this.Ataque;
            return contadorAtaque;
        }

        private int contadorDefensa = 0;
        public int TotalDefensa()
        {
            foreach (Elemento elemento in items)
            {
                contadorDefensa = contadorDefensa + elemento.Defensa;
            }
            contadorDefensa=contadorDefensa+ this.Defensa;
            
            return contadorDefensa;
        }

        public void Curarse()
        {
            this.Salud=saludInicial;
        }

        public void AtacarElfo(Elves elve)
        {   
            if (elve.TotalDefensa() > this.TotalAtaque())
            {
                Console.WriteLine($"{elve.Name} Su defensa es muy poderosa, es imposible atacar");
            }
            else
            {
            elve.Life = elve.Life - this.TotalAtaque();
                if (elve.Life <= 0)
                {
                    Console.WriteLine("Mataste al objetivo");
                }
            }
        }
        public void AtacarEnano(Enano Enano)
        {   
            if (Enano.TotalDefensa() > this.TotalAtaque())
            {
                Console.WriteLine($"{Enano.Nombre} Su defensa es muy poderosa, es imposible atacar");
            }
            else
            {
            Enano.Salud = Enano.Salud - this.TotalAtaque();
                if (Enano.Salud <= 0)
                {
                    Console.WriteLine("Mataste al objetivo");
                }
            }
        }

        public void AtacarWizard(Wizard Wizard)
        {   
            if (Wizard.TotalDefensa() > this.TotalAtaque())
            {
                Console.WriteLine($"{Wizard.Nombre} Su defensa es muy poderosa, es imposible atacar");
            }
            else
            {
            Wizard.Salud = Wizard.Salud - this.TotalAtaque();
                if (Wizard.Salud <= 0)
                {
                    Console.WriteLine($"Mataste al objetivo, {Wizard.Nombre} ha sido enviado al reino de las sombras");
                }
            }
        }
    }
}
