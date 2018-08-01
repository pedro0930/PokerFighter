using System.Collections.Generic;
using System;

namespace cards{
    public class Monster{
        Random rand = new Random();
        public int health;
        public string name;

        public Monster(){
        this.health = 100;
        this.name = "The Tester Monster";
        }
        public void attack(Player target){
            target.health -=10;
        this.name = "The Tester Monster";
        }
        public void Attack(Player target){
                int damage = rand.Next(5,15);
                target.health -= damage;
                System.Console.WriteLine($"{target.name} is attacked for {damage} damage!");
        }
        public void PlayerAttack(int damage){
                this.health -= damage;
                System.Console.WriteLine($"The {this.name} is attacked for {damage} damage!");

        }
    }
}