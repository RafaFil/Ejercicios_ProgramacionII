using System;
using RoleplayGame;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de personajes:
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book);
            //Heroes
            Dwarf claudius = new Dwarf("Claudius");
            Archer gilgamesh = new Archer("Gilgamesh");
            Knight saber = new Knight("Saber");
            //Villanos
            DemonLieutenant astaroth = new DemonLieutenant("Astaroth",5);
            Sombras sombraGenerica = new Sombras("Generica",1);

            //Se crea el encuentro
            Encuentros encuentro = new Encuentros();
            encuentro.AddHeroe(claudius);   //Se añiaden los heroes
            encuentro.AddHeroe(gilgamesh);
            encuentro.AddHeroe(saber);
            encuentro.AddVillano(sombraGenerica);
            encuentro.AddVillano(astaroth); //se añiaden los villanos
            encuentro.AddHeroe(gandalf);
            encuentro.DoEncounter();
        }
    }
}
