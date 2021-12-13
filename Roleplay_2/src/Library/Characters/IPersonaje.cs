using System;

namespace RoleplayGame
{
    public interface IPersonaje
    {
        int GetAttack();

        void ReceiveAttack(IPersonaje personaje);
    }
}