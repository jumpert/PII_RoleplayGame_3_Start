using System.Collections.Generic;
using System;


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
            while (heroesLista != null && enemigoLista !=null)
            {
                int rondas = 1;
                int batallas = 0;
                while (true)
                {
                    if (enemigoLista.Capacity <= heroesLista.Capacity)
                    {
                        foreach (Heroes heroe in heroesLista)
                        {
                            heroe.ReceiveAttack(enemigoLista[batallas].AttackValue);
                            batallas ++;
                        }
                        foreach (Heroes heroe in heroesLista)
                        {
                            if (heroe.Health <= 0)
                            {
                                heroesLista.Remove(heroe);
                            }
                        }
                        batallas = 0;
                    }
                    else
                    {
                        foreach (Heroes heroe in heroesLista)
                        {
                            heroe.ReceiveAttack(enemigoLista[0].AttackValue);
                            heroe.ReceiveAttack(enemigoLista[batallas+1].AttackValue);
                            batallas ++;
                        }
                        foreach (Heroes heroe in heroesLista)
                        {
                            if (heroe.Health <= 0)
                            {
                                heroesLista.Remove(heroe);
                            }
                        }
                        batallas = 0;
                    }
                    rondas ++;
                    foreach (Heroes heroe in heroesLista)
                    {
                        enemigoLista[batallas].ReceiveAttack(heroe.AttackValue);
                        heroe.EstadoEnemigo(enemigoLista[batallas]);
                        if (heroe.AcumulaPV >=5)
                        {
                            heroe.Cure();
                        }
                        batallas ++;
                    }
                    rondas ++;

                }
                
            }
        }



    }
}