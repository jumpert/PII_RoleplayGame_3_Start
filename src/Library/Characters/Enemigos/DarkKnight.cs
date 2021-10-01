using System.Collections.Generic;
namespace RoleplayGame
{
    public class DarkKnight: Enemigo
    {
        public DarkKnight(string name)
            :base(name)
        {
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }
        
    }
}