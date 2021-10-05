using System.Collections.Generic;
namespace RoleplayGame
{
    public class Encounters {
        void doEncounter(List<Hero> heroes, List<Enemy> enemies)
        {
            // Lista de VPS iniciales
            List<int> heroesVPS = new List<int>();
            foreach (Hero hero in heroes)
            {
                heroesVPS.add(heroes.VP);
            }
            // Loop de turnos checkeando si alguno de los enemigos o alguno de los heroes estan vivos
            while (AreEnemiesAlive(enemies) && AreHeroesAlive(heroes))
            {
                //Atacan los enemigos
                for (int i = 0; i < enemies.length; i++)
                {
                    heroes[(i % heroes.length)].ReceiveAttack(enemies[i].AttackValue);
                    //Checkeo para los muertos
                    if (heroes[(i % heroes.length)].Health <= 0)
                    {
                        heroes.RemoveAt(i % heroes.length);
                        heroesVPS.RemoveAt(i % heroes.length);
                    }
                }
                //Atacan los heroes
                for (int i = 0; i < heroes.length; i++)
                {
                    for (int j = 0; enemies.length; i++)
                    {
                        enemies[j].ReceiveAttack(heroes[i].AttackValue);
                        //Checkeo para enemigos muertos
                        if (enemies[j].Health <= 0)
                        {
                            heroes[i].addVp(enemies[j]);
                            enemies.RemoveAt(enemies[j]);
                        }
                    }
                }
            }
            // Checkeo de curacion de VPs de heroes
            for (int i = 0; heroes.length; i++)
            {
                if (heroes[i] - heroesVPS[i] >= 5)
                {
                    heroes[i].Cure();
                }
            }
        }

// Checkea si los enemigos estan vivos
        bool AreEnemiesAlive(List<Enemy> enemies)
        {
            for (int i = 0; i < enemies.length ; i++)
            {
                if (enemies[i].Health > 0)
                {
                    return True;
                }
            }
            return False;
        }
// Checkeo si los heroes estan vivos
        bool AreHeroesAlive(List<Hero> heroes)
        {
            for (int i = 0; i < heroes.length ; i++)
            {
                if (heroes[i].Health > 0)
                {
                    return True;
                }
            }
            return False;
        }
    }
}
