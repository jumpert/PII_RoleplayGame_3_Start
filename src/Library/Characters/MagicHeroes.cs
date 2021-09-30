namespace RoleplayGame
{
    public abstract class MagicHeroes : MagicCharacter
    {
        protected int acumulaPV;

        public MagicHeroes(string name)
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