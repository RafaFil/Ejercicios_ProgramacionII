using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //ELEMENTOS
            Elemento DragonSlayer = new Elemento("Dragonslayer","Arma",0,250);
            Elemento Berserker = new  Elemento("Armadura de Berserker","Armadura",5000,0);
            Elemento Law = new Elemento("Law","Hechizo",1000,1000);
            Elemento Axe = new Elemento ("Axe","Arma",100,300);
            Elemento CapaInvisible = new Elemento ("CapaInvisible","Armadura",0,0);
            Elemento Kubikiribocho = new Elemento ("Kubikiribocho", "Arma", 100, 250);
            Elemento Jutsu = new Elemento ("Jutsu", "Hechizo",700,700);
            Law.AddHechizo(Law);
            Axe.AddHechizo(Axe);
            

            //PERSONAJES
            Wizard Gandalf = new Wizard("Gandalf",20,5,1);
            Enano Gimli = new Enano("Gimli",30,3,10);
            Wizard Meliodas = new Wizard("Meliodas",15,10,1);
            Wizard Kakashi = new Wizard("Kakashi", 40,2,10);
            Elves ElRafa = new Elves("ElRafa", 3,1,1);


            //JUEGO
            Gandalf.EquiparItem(DragonSlayer);
            Gandalf.EquiparItem(Axe);
            Gandalf.AtacarWizard(Meliodas);
            Meliodas.Curarse();
            Meliodas.EquiparItem(Berserker);
            Gandalf.QuirarItem(Axe);
            Gandalf.QuirarItem(DragonSlayer);
            Gandalf.AtacarWizard(Meliodas);

        }
    }
}
