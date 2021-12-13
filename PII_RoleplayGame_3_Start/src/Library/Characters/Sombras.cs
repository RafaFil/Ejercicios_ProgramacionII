namespace RoleplayGame
{
    public class Sombras : Villanos
    {
        public Sombras(string name, int vp) : base(name,vp)
        {
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }
    }
}