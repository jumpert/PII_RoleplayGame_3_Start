using System.Collections.Generic;
namespace RoleplayGame
{
    public class ArcherHeroe: Heroes
    {
        public ArcherHeroe(string name)
            :base(name)
        {
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }

        
    }
}