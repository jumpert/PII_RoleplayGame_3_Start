using System.Collections.Generic;
using System;
using System.Text;


namespace RoleplayGame
{
    public class Encuentros
    {
        // En las listas privadas es donde se almacenan los herores y los enemigos que formaran parte en el encuentro
        // se creo una lista independiente para cada uno, dependiendo del tipo
        private List<Heroes>  heroesLista = new List<Heroes>();       
        private List<Enemigo> enemigoLista = new List<Enemigo>();
        
        // Se crearon 2 metodos publicos para poder agregar los personajes al encuentro segun su tipo (enemigo/heroe)
        public void AddHeroes(Heroes heroe)
        {
            this.heroesLista.Add(heroe);
        }

        public void AddEnemigo(Enemigo enemigo)
        {
            this.enemigoLista.Add(enemigo);
        }

        //El metodo DoEncounters es el que realiza las acciones de los personajes segun se explicito en la letra del ejercicio
        // a su vez tiene un StringBuilder que permite ir visionando el transcurso del encuentro y va mostrando lo que se va ejecutando
        // hasta que el encuentro termina y marca que bando es el ganador del mismo
        public void DoEncounters()
        {
            bool seguir = true;

            StringBuilder reporte = new StringBuilder("Ronda 1:\n");
            while (heroesLista.Count != 0 && enemigoLista.Count != 0)
            {
                int rondas = 1;
                int batallas = 0;
                
                while (seguir)
                {
                    if (enemigoLista.Capacity <= heroesLista.Capacity )
                    {
                        batallas = 0;
                        foreach (Enemigo enemigo in enemigoLista)       //recorre la lista de enemigos para saber a quien le toca atacar
                        {
                            batallas ++;        //sirve de incremento para que vaya cambiando el heroe que es atacado
                            heroesLista[batallas-1].ReceiveAttack(enemigo.AttackValue);
                            reporte.Append($"El Heroe {heroesLista[batallas -1].Name} recibio un ataque de {enemigo.Name}.\n");
                        }
                        reporte.Append("- Estado de los Herores:\n");                        
                        foreach (Heroes heroe in heroesLista)       //consulta el estado de los herores, si alguno esta muerto ya no puede volver a participar del encuentro y es retirado de la lista
                        {
                            if (heroe.Health <= 0)
                            {
                                heroesLista.Remove(heroe);
                            }
                            reporte.Append($"--> {heroe.Name} tiene {heroe.Health} puntos de vida.\n");
                        }
                        
                    }
                    else
                    {
                        batallas = 0;
                        foreach (Heroes heroe in heroesLista)
                        {
                            batallas ++;
                            heroe.ReceiveAttack(enemigoLista[0].AttackValue);
                            heroe.ReceiveAttack(enemigoLista[batallas-1].AttackValue);
                            
                            reporte.Append($"El Heroe {heroe.Name} recibio el ataque de {enemigoLista[0].Name} y de {enemigoLista[batallas].Name}.\n");
                        }
                        reporte.Append("- Estado de los Herores:\n");
                        foreach (Heroes heroe in heroesLista)
                        {
                            if (heroe.Health <= 0)
                            {
                                heroesLista.Remove(heroe);
                            }
                            reporte.Append($"--> {heroe.Name} tiene {heroe.Health} puntos de vida.\n");
                        }
                    }
                    batallas = 0;
                    rondas ++;
                    reporte.Append($"Ronda {rondas}: \n");
                    foreach (Heroes heroe in heroesLista)           //recorre la lista de heroes para saber quien ataca
                    {
                        reporte.Append($"-El Heroe {heroe.Name} atacó a:\n");
                        foreach (Enemigo enemigo in enemigoLista)       //a diferencia del ataque de los enemigos, aca cada heroe ataca 1 vez a cada enemigo (por medio de recorrer la lista)
                        {
                            enemigo.ReceiveAttack(heroe.AttackValue);
                            heroe.EstadoEnemigo(enemigo);
                            reporte.Append($"--> {enemigo.Name}\n"); 
                            batallas ++;
                        }
                        if (heroe.AcumulaPV >=5)            // consulta si el heroe alcanzo los 5 pv para curarse
                        {
                            heroe.Cure();
                            reporte.Append($"El Heroe {heroe.Name} obtuvo 5 VP y se curo.\n");
                        }
                        for (int i = 0; i < batallas; i++)          //consulta el estado de los enemigos, para saber si ya a muerto y quitarlo de la lista de participantes
                        {
                            if (enemigoLista.Capacity != 0 && enemigoLista != null)
                            {
                                if (enemigoLista[i].Health <= 0 )
                                {
                                    enemigoLista.Remove(enemigoLista[i]);
                                    i--;
                                    batallas --;
                                }
                            }
                        }
                        batallas = 0;                       
                    }
                    
                    rondas ++;
                    
                    {
                    if (enemigoLista.Count == 0 || heroesLista.Count == 0 || rondas == 10)  //chequea que las listas no esten vacias (lo que indicaría que algun) bando ya perdio todos sus participantes, o que los turnos ya fueron 10 (que es el tope)
                        seguir = false;
                    }
                    

                }
                
            }
            if (heroesLista.Count == 0)
            {
                reporte.Append("\n### Finalizó el encuentro ###\n#  Los Enemigos vencieron.  #\n# Mal día para los herores. #\n#############################");
            }
            else if (enemigoLista.Count == 0)
            {
                reporte.Append("\n######### Finalizó el encuentro #########\n#\t  Los Heroes vencieron.  \t#\n# El bien siempre triunfa sobre el mal. #\n#########################################");
            }
            Console.WriteLine($"{reporte.ToString()}");
        }



    }
}