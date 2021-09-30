namespace RoleplayGame
{
    public abstract class MagicEnemigo : MagicCharacter
    {
        protected int valorPV = 5;

        public MagicEnemigo(string name)
            :base(name)
        {

        }

        public int ValorPV
        {
            get
            {
                return this.valorPV;
            }
        }
    }
}