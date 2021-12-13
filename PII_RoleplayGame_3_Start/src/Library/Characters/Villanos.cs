namespace RoleplayGame
{
    public abstract class Villanos : Personaje
    {
        public int VP {get; set;}

        public Villanos(string name, int vp) : base(name)
        {
            this.VP=vp;
        }
    }
}