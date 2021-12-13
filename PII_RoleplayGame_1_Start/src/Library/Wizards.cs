using System;
using System.Collections;

/*En esta clase de Wizard, Se utilizan los metodos TotalAtaque y Total Defensa, pues la clase es la experta de informacion (se utilzia el patron expert), lo mismo para metodos
Exclusivos como Aprender Magia o Curarse (tambien es el patron Expert) */
namespace Program
{
    public class Wizard
    {
        //declaro variables privadas y públicas
        private int salud;
        private int defensa;
        private int magia;
        private ArrayList items = new ArrayList();

        public string Nombre {get;}

        public int Salud
        {
            set
            {
                this.salud = value;
            }
            get
            {
                return this.salud;
            }
        }
        public int Defensa
        {
            set 
            {
                this.defensa = value;
            }
            get 
            {
                return this.defensa;
            }
        }
        public int Magia
        {
            set
            {
                this.magia = value;
            }
            get
            {
                return this.magia;
            }
        }

        private int saludInicial;
    //el constructor
        public Wizard(string nombre, int salud, int defensa, int magia) 
        {
            this.Nombre=nombre;
            this.Salud=salud;
            this.Defensa=defensa;
            this.Magia=magia;

            saludInicial=salud;

        }

        public Elemento elemento{ get; set; }

        public void AprenderMagia() 
        {
            this.magia = this.magia + 1;
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
            contadorAtaque = contadorAtaque + this.Magia;
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
            Wizard.salud = Wizard.Salud - this.TotalAtaque();
                if (Wizard.Salud <= 0)
                {
                    Console.WriteLine($"Mataste al objetivo, {Wizard.Nombre} ha sido enviado al reino de las sombras");
                }
            }
        }
    }
}
