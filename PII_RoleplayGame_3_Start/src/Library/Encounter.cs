/// <summary>
/// La idea seria crear dos tipos de Listas ("Almacen") de Heroes y Villanos. Cada vez que un Heroe o Villano
/// es agregado el contador aumenta en 1.
/// </summary>


using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class Encuentros
    {
        private List<Heroes> heroes = new List<Heroes>();
        private List<Villanos> villanos = new List<Villanos>();

        public int TotalVillanos {get; set;}
        public int TotalHeroes {get; set;}

        public void AddHeroe(Heroes heroe)  //Agrega Heroe y suma uno al total
        {
            this.heroes.Add(heroe);
            this.TotalHeroes++;
        }

        public void AddVillano(Villanos villano)    //Agrega Villano y suma uno al total
        {
            this.villanos.Add(villano);
            this.TotalVillanos++;
        }

        public void DoEncounter()
        {
            int numeroTurno=1;
            while (this.TotalHeroes > 0 && this.TotalVillanos >0)
            {
                Console.WriteLine
                ($" en este encuentro hay un total de {this.TotalHeroes} heroes y {this.TotalVillanos} villanos \n turno numero : {numeroTurno}");
                this.AtaqueEnemigo();
                this.RemoveHeroe();
                this.AtaqueHeroes();
                this.CheckCurarse();
                this.RemoveVillano();
                this.CheckeoJuego();
                numeroTurno++;
            }
        }

        public void AtaqueEnemigo() 
        /*Ataque Enemigo, cada enemigo ataca a un heroe a la vez, por eso luego incrementa el indice en 1.
        si el indice llega a ser igual al total de heroes-1 el indice se setea en 0 y vuelve a atacar al
        primer heroe*/
        {
            int indiceH=0;
            foreach (Villanos villano in this.villanos)
            {
                this.heroes[indiceH].ReceiveAttack(villano.AttackValue);
                Console.WriteLine($"{villano.Name} a lanzado su ataque contra {this.heroes[indiceH].Name}");
                if (this.TotalHeroes > 1 && indiceH < this.TotalHeroes-1)
                {
                    indiceH++;
                }
                else if (this.TotalHeroes >1 && indiceH == this.TotalHeroes-1)
                {
                    indiceH =0;
                }
            }
        }

        public void AtaqueHeroes()  //Ataque de heroes.
        {
            foreach (Heroes heroe in this.heroes)
            {
                foreach (Villanos villano in this.villanos)
                {
                    villano.ReceiveAttack(heroe.AttackValue);
                    if (villano.Health <= 0)
                    {
                        Console.WriteLine($"{villano.Name} fue destruido por {heroe.Name}");
                        heroe.AñiadirVP(villano);
                    }
                }
            }
        }
        public void CheckeoJuego()  //Checkea al final de cada ronda de ataque si hay un ganador o no
        {
            if (this.TotalHeroes < 1)
            {
                Console.WriteLine("Los hereoes han perdido");
            }
            else if (this.TotalVillanos < 1)
            {
                Console.WriteLine("Los villanos han ganado");
            }
            else
            {
                Console.WriteLine("El juego continua, la batalla no ha terminado");
            }
        }

        public void CheckCurarse()  //overflow aca
        {
            foreach (Heroes heroe in this.heroes)
            {
                if (heroe.VP <= 5)
                {
                    heroe.Cure();
                    Console.WriteLine($"{heroe.Name} se ha curado");
                }
            }
        }

        public void RemoveHeroe()   //remueve Heroe
        {
            foreach (Heroes heroe in this.heroes)
            {
                if (heroe.Health<=0)
                {
                    TotalHeroes--;
                    Console.WriteLine
                    ($"{heroe.Name} ya no puede continuar, Heroes restantes : {this.TotalHeroes}");
                }
            }
            this.heroes.RemoveAll(Heroes => Heroes.Health <= 0);
        }
        public void RemoveVillano() //Remueve Villano
        {
            foreach (Villanos villano in this.villanos)
            {
                if(villano.Health <= 0)
                {
                    TotalVillanos--;
                    Console.WriteLine
                    ($"{villano.Name} ha sido aniquilado, Villanos restantes {this.TotalVillanos}");
                }
            }
            this.heroes.RemoveAll(Villanos => Villanos.Health <= 0);
        }
    }
}
