using System.Collections.Generic;
namespace RoleplayGame
{
    public class KnightHeroe: Heroes
    {
        public KnightHeroe(string name)
            :base(name)
        {
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }
        
    }
}