/// <summary>
/// Se borra todo el codigo anterior, dejando solo el constructor.
/// Todas las demas propiedades y metodos estan inculidas en : Personaje
/// </summary>

using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight: Heroes
    {
        public Knight(string name) : base(name)
        {
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }
    }
}