namespace RoleplayGame

{
    public class Hero: Character
    {
        public int VP {get; set;}
        public Hero (string name)
        :base (name)
        {

        }
        public void addvp (Enemy enemy)
        {
            this.VP += enemy.VP;
        }
    }

}