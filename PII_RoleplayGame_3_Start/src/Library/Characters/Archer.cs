/// <summary>
/// Se borra todo el codigo anterior, dejando solo el constructor.
/// Todas las demas propiedades y metodos estan inculidas en : Heroes
/// </summary>

using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer: Heroes
    {
        // se usa el "base(name)", porque 
        public Archer(string name) : base(name) 
        {
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }
    }
}