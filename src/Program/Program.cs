using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Dwarf Gimli = new Enemy("Gimli", 2);
            Knight Sauron = new Enemy("Sauron", 3);
            Archer Legolas = new Enemy("Legolas", 0);

            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Wizard gandalf = new Hero("Gandalf");
            gandalf.AddItem(book);

            List<Hero> heores = new List<Hero>();
            heroes.add(Gandalf);
            
            List<Enemy> enemies = new List<Enemy>();
            enemies.add(Gimli);
            enemies.add(Sauron);
            enemies.add(Legolas);

            doEncounter(heroes, enemies);

            Console.WriteLine(heroes[0].name);
        }
    }
}
