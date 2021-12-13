using System.Collections;

namespace RoleplayGame
{
    public class Archer : IPersonaje
    {
        private int health = 100;

        public Archer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        private ArrayList elementos = new ArrayList();

        public void AddElemento(IElemento elemento)
        {
            this.elementos.Add(elemento);
        }

        public void RemoveElemento(IElemento elemento)
        {
            this.elementos.Remove(elemento);
        }

        public int AttackValue
        {
            get
            {
                int AttackValueAUX=0;
                foreach (IElemento elemento in elementos)
                {
                    AttackValueAUX= AttackValueAUX + elemento.AttackValue;
                }
                return AttackValueAUX;
            }
        }
        
        public int DefenseValue
        {
            get
            {
                int DefenseValueAUX=0;
                foreach (IElemento elemento in elementos)
                {
                    DefenseValueAUX= DefenseValueAUX + elemento.DefenseValue;
                }
                return DefenseValueAUX;
            }
        }

        public int Health
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
        
        public int GetAttack()  //Metodo agregado por la interface IPersonaje
        {
            return this.AttackValue;
        }

        public void ReceiveAttack(IPersonaje personaje) //Metodo agregado por la interface IPersonaje
        {
            this.Health = this.Health - personaje.GetAttack();
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}