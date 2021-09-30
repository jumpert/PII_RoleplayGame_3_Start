using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class MagicCharacter: Character
    {
        protected List<IMagicalItem> magicalItems = new List<IMagicalItem>();
        
        public MagicCharacter(string name)
            :base(name)
        {

        }
        public void AddItem(IMagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public void RemoveItem(IMagicalItem item)
        {
            this.magicalItems.Remove(item);
        }
    }
}
