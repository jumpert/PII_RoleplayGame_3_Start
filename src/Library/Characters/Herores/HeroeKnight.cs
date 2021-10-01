using System.Collections.Generic;
namespace RoleplayGame
{
    public class HeroeKnight: Heroes
    {
        public HeroeKnight(string name)
            :base(name)
        {
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }
        
    }
}