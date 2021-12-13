namespace RoleplayGame
{
    public class Axe: IElemento
    {
        public int AttackValue 
        {
            get
            {
                return 25;
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