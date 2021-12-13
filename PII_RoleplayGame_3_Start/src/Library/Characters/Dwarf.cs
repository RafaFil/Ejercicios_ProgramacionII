/// <summary>
/// Se borra todo el codigo anterior, dejando solo el constructor.
/// Todas las demas propiedades y metodos estan inculidas en : Personaje
/// </summary>

using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf: Heroes
    {
        public Dwarf(string name): base(name)
        {
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }
    }
}