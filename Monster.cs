using System.Collections.Generic;

namespace cards{
    public class Monster{
        public int health;
        public string name;

        public Monster(){
        this.health = 100;
        this.name = "The Tester Monster";
        }
        public void Attack(Player target){
            target.health -=10;
                }
        public void PlayerAttack(int damage){
                this.health -= damage;
                System.Console.WriteLine($"{this.name} is attacked for {damage}");
                }
    }
}