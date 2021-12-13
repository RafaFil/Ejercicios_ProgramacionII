namespace RoleplayGame
{
    public abstract class Heroes : Personaje
    {
        private int vp = 0;

        public int VP
        {
            get
            {
                return this.vp;
            }
            set
            {
                this.vp=value;
            }
        }

        public Heroes(string name) : base(name)
        {
        }

        public void AñiadirVP(Villanos villano)
        {
            this.VP= this.VP+villano.VP;
        }
    }
}
