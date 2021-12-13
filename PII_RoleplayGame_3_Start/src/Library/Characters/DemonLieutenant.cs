namespace RoleplayGame
{
    public class DemonLieutenant : Villanos
    {
        public DemonLieutenant(string name, int vp) : base(name,vp)
        {
            this.AddItem(new Longinus());
            this.AddItem(new DemonArmor());
        }
    }
}