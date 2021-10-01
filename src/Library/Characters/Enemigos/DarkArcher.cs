using System.Collections.Generic;
namespace RoleplayGame
{
    public class DarkArcher: Enemigo
    {
        public DarkArcher(string name)
            :base(name)
        {
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }  
    }
}