using System.Collections.Generic;
namespace RoleplayGame
{
    public class HeroeDwarf: Heroes
    {
        public HeroeDwarf(string name)
            :base(name)
        {
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }
    }
}