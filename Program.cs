using System;
using System.Collections.Generic;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up
            int discard = 0;
            System.Console.WriteLine("Please Input Player 1 name");
            string Player1Name = Console.ReadLine();
            System.Console.WriteLine("Player 1 is: " + Player1Name);
            Deck myDeck = new Deck();
            Player Player1 = new Player(Player1Name);
            Monster Monster1 = new Monster();
            myDeck.Shuffle(myDeck.DeckOfCards);
            for (int i = 0; i<5; i++){
                Player1.Draw(myDeck.DeckOfCards);
                }
            Player1.LookAtHand(Player1.PlayerHand);
            // Game starts below this line
            string PlayerCommand = "";
            System.Console.WriteLine("Welcome to Poker Quest!");
            while(Player1.health >= 0 && Monster1.health >= 0){
                // Target description
                if (Player1.health < 50){
                    System.Console.WriteLine("You are badly hurt!");
                }
                else if (Player1.health < 25){
                    System.Console.WriteLine("You are critically injured!");
                }
                if (Monster1.health > 90){
                    System.Console.WriteLine($"A terrifying {Monster1.name} stands before you. It's unhurt.");
                    }
                else if(Monster1.health < 70){
                    System.Console.WriteLine($"A terrifying {Monster1.name} stands before you. It's injured.");
                    }
                else if(Monster1.health < 30){
                    System.Console.WriteLine($"A terrifying {Monster1.name} stands before you. It's badly hurt.");
                    }
                else if(Monster1.health < 10){
                    System.Console.WriteLine($"A terrifying {Monster1.name} stands before you. It's on its last leg.");
                    }
                
                
                System.Console.WriteLine("Please input exact command for your action, you can 'draw' or 'discard' if you have card in hand, 'confirm' to play your hand. You can also 'quit' if you wish.");
                PlayerCommand = Console.ReadLine();
                if (PlayerCommand == "draw"){
                    Player1.Draw(myDeck.DeckOfCards);
                    }
                if (PlayerCommand == "discard"){
                    Player1.LookAtHand(Player1.PlayerHand);
                    System.Console.WriteLine("Select the card you want to discard by index");
                    string discardSelection = Console.ReadLine();
                    discard++;
                    }
                if (PlayerCommand == "look"){
                    Player1.LookAtHand(Player1.PlayerHand);
                    }
                if (PlayerCommand == "confirm"){
                    if(discard > 0){
                        for(int i = 0; i< discard;i++){
                            Player1.Draw(myDeck.DeckOfCards);
                        }
                    }
                    Monster1.PlayerAttack(Player1.AllCard());
                    Monster1.Attack(Player1);
                    for (int i = 0; i<5; i++){
                        Player1.Draw(myDeck.DeckOfCards);
                        }
                    }
                System.Console.WriteLine("Processed");
                System.Console.WriteLine("##################################");
                }
                if(Player1.health <= 0){
                    System.Console.WriteLine($"{Player1.name} killed! You lose :(");
                    }
                else if (Monster1.health <= 0){
                    System.Console.WriteLine($"{Player1.name} killed {Monster1.name}. You win!");
                }
            }
        }
}
