using System.Collections.Generic;

namespace cards{
    public class Monster{
        public int health;
        public string name;

        public Monster(){
        this.health = 100;

        this.name = "The Tester Monster";
        }
        public void attack(Player target){
            target.health -=10;
<<<<<<< HEAD

=======
>>>>>>> a98ebf0bf64bf094a24e3370ad973a03b2358966
        }
    }
}