namespace RoleplayGame
{
    public abstract class Heroes : Character
    {
        public int AcumulaPV;

        public Heroes(string name)
            :base(name)
        {

        }

        public int EstadoEnemigo(Enemigo personaje)
        {
            if (personaje.Health <= 0)
            {
                this.AcumulaPV += personaje.ValorPV;
            }
            return this.AcumulaPV;
        }
    }
}