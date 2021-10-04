namespace RoleplayGame
{
    public abstract class Heroes : Character
    {

        // La clase Heroes hereda de la clase Character y tiene algunas particularidades como, el AcumulaPV y EstadoEnemigo
        // AcumulaPV es el atributo para almacenar los PV que gana y EstadoEnemigo, es el metodo que se cerciora de que el enemigo que ataco el personaje este vivo y en el caso contrario suma los pv del enemigo
        
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