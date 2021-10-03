using System.Collections.Generic;
using System;
using System.Text;


namespace RoleplayGame
{
    public class Encuentros
    {
        private List<Heroes>  heroesLista = new List<Heroes>();       
        private List<Enemigo> enemigoLista = new List<Enemigo>();
        

        public void AddHeroes(Heroes heroe)
        {
            this.heroesLista.Add(heroe);
        }

        public void AddEnemigo(Enemigo enemigo)
        {
            this.enemigoLista.Add(enemigo);
        }

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
                        foreach (Enemigo enemigo in enemigoLista)
                        {
                            batallas ++;
                            heroesLista[batallas-1].ReceiveAttack(enemigo.AttackValue);
                            reporte.Append($"El Heroe {heroesLista[batallas -1].Name} recibio un ataque de {enemigo.Name}.\n");
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
                    foreach (Heroes heroe in heroesLista)
                    {
                        reporte.Append($"-El Heroe {heroe.Name} atacó a:\n");
                        foreach (Enemigo enemigo in enemigoLista)
                        {
                            enemigo.ReceiveAttack(heroe.AttackValue);
                            heroe.EstadoEnemigo(enemigo);
                            reporte.Append($"--> {enemigo.Name}\n"); 
                            batallas ++;
                        }
                        if (heroe.AcumulaPV >=5)
                        {
                            heroe.Cure();
                            reporte.Append($"El Heroe {heroe.Name} obtuvo 5 VP y se curo.\n");
                        }
                        for (int i = 0; i < batallas; i++)
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
                    
                    if (enemigoLista.Count == 0 || heroesLista.Count == 0)
                    {
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