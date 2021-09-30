using System.Collections.Generic;
namespace RoleplayGame
{
    public class DwarfHeroe: Heroes
    {
        public DwarfHeroe(string name)
            :base(name)
        {
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }
    }
}