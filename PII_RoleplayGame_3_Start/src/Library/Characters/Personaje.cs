/// <summary>
/// Se define una clase abstracta personaje, es una clase sin instancias. Su proposito es que sea heredada de
/// los otros 4 personajes del juego (Archer, Dwarf, Knight, Wizard)
/// Se implementa la interfaz ICharacter (por lo que a la clase abstracta se le agregan todos las properties
/// de dicha clase). Las restantes justificaciones estan en el codigo.
/// </summary>

using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class Personaje : ICharacter
    {
        private int health = 100;   //Todos tienen salud 100

        protected List<IItem> items = new List<IItem>();  
        //Todos tienen un inventario, protected para que las subclases puedan acceder a la property

        public string Name { get; set; } // por ICharacter

        protected Personaje(string name)    
        //Declarado Protected para que las sublases puedan acceder al metodo.
        {
            this.Name=name;
        }

        public void AddItem(IItem item) //Por Icharacter
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item) //Por Icharacter
        {
            this.items.Remove(item);
        }

        public virtual int AttackValue 
        //El metodo se declara virtual porque sufre modificaciones en la clase Wizard
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public virtual int DefenseValue
        //El metodo se declara virtual porque sufre modificaciones en la clase Wizard
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public int Health 
        // por ICharacter
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void Cure()  //Por Icharacter
        {
            this.Health = 100;
        }

        public void ReceiveAttack(int power)    //Por Icharacter
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

    }
}