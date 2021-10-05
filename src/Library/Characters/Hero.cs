namespace RoleplayGame

{
    public class Hero: Character
    {
        public int VP {get; set;}
        public Hero (string name)
        :base (name)
        {
            this.VP = 0;
        }
        public void addVp (Enemy enemy)
        { //Conteo de Vps
            this.VP += enemy.VP;
        }
    }

}