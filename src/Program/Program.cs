using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Pruebas individuales de personajes, equipos y metodos.
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            HeroeWizard gandalf = new HeroeWizard("Gandalf");
            gandalf.AddItem(book);

            DarkDwarf gimli = new DarkDwarf("Gimli");

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Puntos de victoria: {gandalf.EstadoEnemigo(gimli)}");

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {gimli.Health}");

            /* Aquí comienza la parte de los encuentros, se crea una instancia de la clase Encuentros 
            Se procede a agregar algunos personajes, a los cuales se les van a colocar algunbos equipos para aumentar sus poderes
            y se va a iniciar un encuentro.*/

            Encuentros guerra = new Encuentros();
            //Heroes leonidas y merlin
            HeroeKnight leonidas = new HeroeKnight("Leonidas");
            leonidas.AddItem(new Armor());
            leonidas.AddItem(new Sword());

            HeroeWizard merlin = new HeroeWizard("Merlin");
            merlin.AddItem(book);
            merlin.AddItem(new Helmet());

            //Enemigos komodo y ancestro
            DarkArcher komodo = new DarkArcher("Komodo");
            
            DarkDwarf ancestro = new DarkDwarf("Ancestro");
            ancestro.AddItem(new Shield());

            //Agregando heroes y enemigos al encuentro.
            guerra.AddEnemigo(komodo);
            guerra.AddEnemigo(ancestro);

            guerra.AddHeroes(leonidas);
            guerra.AddHeroes(merlin);

            // Hora de batallar
            guerra.DoEncounters();

        }
    }
}
