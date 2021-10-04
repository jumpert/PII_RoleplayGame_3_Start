using System.Collections.Generic;

namespace RoleplayGame
{
    public interface IMagicCharacter
    {
        // con esta interface se crean los personajes magos tanto enemigos como herores,
        // ya que lo unico distinto que tienen son los metodos de equiparse articulos magicos
        
        void AddItem(IMagicalItem item);
        void RemoveItem(IMagicalItem item);
    }
}
