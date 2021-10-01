using System.Collections.Generic;
namespace RoleplayGame
{
    public class DarkDwarf : Enemigo
    {
        public DarkDwarf(string name)
            :base(name)
        {
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }
    }
}