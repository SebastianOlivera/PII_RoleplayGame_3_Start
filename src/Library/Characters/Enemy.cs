
namespace RoleplayGame

{
    public class Enemy: Character
    {
        public int VP {get; set;}
        public Enemy (string name, int vp)
        :base (name)
        {
            //Vps Enemigos
            this.VP = vp;
        }
    }
}
 