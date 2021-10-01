using System.Collections.Generic;

namespace RoleplayGame
{
    public interface IMagicCharacter
    {
        
        void AddItem(IMagicalItem item);
        void RemoveItem(IMagicalItem item);
    }
}
