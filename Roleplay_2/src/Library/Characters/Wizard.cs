using System.Collections;

namespace RoleplayGame
{
    public class Wizard : IPersonaje
    {
        private int health = 100;

        public Wizard(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public SpellsBook SpellsBook { get; set; }

        public Staff Staff { get; set; }

        public int AttackValue
        {
            get
            {
                return SpellsBook.AttackValue + Staff.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return SpellsBook.DefenseValue + Staff.DefenseValue;
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

        public int GetAttack()
        {
            return this.AttackValue;
        }

        public void ReceiveAttack(IPersonaje personaje)
        {
            this.Health = this.Health - personaje.GetAttack();
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}