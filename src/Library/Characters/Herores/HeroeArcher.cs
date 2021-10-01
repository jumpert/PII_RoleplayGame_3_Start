using System.Collections.Generic;
namespace RoleplayGame
{
    public class HeroeArcher: Heroes
    {
        public HeroeArcher(string name)
            :base(name)
        {
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }

        
    }
}