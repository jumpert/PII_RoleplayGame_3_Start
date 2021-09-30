namespace RoleplayGame
{
    public abstract class Heroes : Character
    {
        protected int acumulaPV;

        public Heroes(string name)
            :base(name)
        {

        }

        public void MatarEnemigo(Enemigo personaje)
        {
            if (personaje.Health <= 0)
            {
                this.acumulaPV += personaje.ValorPV;
            }
        }


    }
}