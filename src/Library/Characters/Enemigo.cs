namespace RoleplayGame
{
    public abstract class Enemigo : Character
    {
        protected int valorPV = 5;

        public Enemigo(string name)
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