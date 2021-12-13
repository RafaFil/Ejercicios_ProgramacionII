using System;
using System.Collections;

/*En esta clase de Elve, Se utilizan los metodos TotalAtaque y Total Defensa, pues la clase es la experta de informacion (se utilzia el patron expert), lo mismo para metodos
Exclusivos como Curar o Curarse (tambien es el patron Expert pues la informacion esta contenida en la clase) */

namespace Program
{
    public class Elves
    {
        private string name; // Nombre del elfo

        private int life; // Vida 

        private int magic; // Magia

        private ArrayList items = new ArrayList();

        private int heal; // Curar a los demas

        public Elemento elemento {get; set;}

        public string Name
        {
            get { return this.name; }
            set {this.name = value; }
        }
        
        public int Life
        {
            get { return this.life; }
            set {this.life = value; }
        }

        public int Magic
        {
            get { return this.magic; }
            set {this.magic = value; }
        }

        public int Heal
        {
            get { return this.heal; }
            set {this.heal = value; }
        }

        private int saludInicial;
        public Elves (string name, int life, int magic, int heal)
        {
            this.Name = name;
            this.Life = life;
            this.Magic = magic;
            this.Heal = heal;

            saludInicial=life;
        }

        public void EquiparItem(Elemento elemento) 
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
            contadorAtaque = contadorAtaque + this.magic;
            return contadorAtaque;
        }
        private int contadorDefensa = 0;
        public int TotalDefensa()
        {
            foreach (Elemento elemento in items)
            {
                contadorDefensa = contadorDefensa + elemento.Defensa;
            }
            return contadorDefensa;
        }

        public void Curarse()
        {
            this.Life=saludInicial;
        }

        public void CurarAliadoElfo(Elves elve) //cura a una elfo
        {
            elve.Life=elve.Life+this.Heal;
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
