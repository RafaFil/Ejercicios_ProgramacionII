namespace RoleplayGame
{
    public class Bow : IElemento
    {
        public int AttackValue 
        {
            get
            {
                return 15;
            } 
        }
        public int DefenseValue {
            get{
                return 0;
            }
        }
    }
}