namespace RoleplayGame
{
    public abstract class Enemigo : Character
    {

        // La clase enemigo es una clase derivada de Character, que tiene 2 cosas adicionales, que son el atributo valorPV y el metodo ValorPV para conocer cual es el valor
        protected int valorPV = 1;

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