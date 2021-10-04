using System.Collections.Generic;
namespace RoleplayGame
{
    public class Encounters {
        void doEncounter(List<Hero> heroes, List<Enemy> enemies)
        {
            List<int> heroesVPS = new List<int>();
            foreach (Hero hero in heroes)
            {
                heroesVPS.add(heroes.VP);
            }
            while (AreEnemiesAlive(enemies) && AreHeroesAlive(heroes))
            {
                for (int i = 0; i < enemies.length; i++)
                {
                    heroes[(i % heroes.length)].ReceiveAttack(enemies[i].AttackValue);
                    if (heroes[(i % heroes.length)].Health <= 0)
                    {
                        heroes.RemoveAt(i % heroes.length);
                        heroesVPS.RemoveAt(i % heroes.length);
                    }
                }
                for (int i = 0; i < heroes.length; i++)
                {
                    for (int j = 0; enemies.length; i++)
                    {
                        enemies[j].ReceiveAttack(heroes[i].AttackValue);
                        if (enemies[j].Health <= 0)
                        {
                            heroes[i].addVp(enemies[j]);
                            enemies.RemoveAt(enemies[j]);
                        }
                    }
                }
            }
            for (int i = 0; heroes.length; i++)
            {
                if (heroes[i] - heroesVPS[i] >= 5)
                {
                    heroes[i].Cure();
                }
            }
        }

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
