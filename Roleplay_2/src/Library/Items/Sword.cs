namespace RoleplayGame
{
    public class Sword :IElemento
    {
        public int AttackValue 
        {
            get
            {
                return 20;
            } 
        }
        public int DefenseValue
        {
            get{
                return 0;
            }
        }
    }
}