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
        }
    }
}