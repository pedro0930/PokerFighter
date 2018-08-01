using System;
using System.Collections.Generic;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up
            int round = 1;
            System.Console.WriteLine("Please Input Player 1 name");
            string Player1Name = Console.ReadLine();
            System.Console.WriteLine("Player 1 is: " + Player1Name);
            Deck myDeck = new Deck();
            Player Player1 = new Player(Player1Name);
            Monster Monster1 = new Monster();
            myDeck.Shuffle(myDeck.DeckOfCards);
            for (int i = 0; i<=13; i++){
                Player1.Draw(myDeck.DeckOfCards);
                }
            Player1.LookAtHand(Player1.PlayerHand);
            // Game starts below this line
            string PlayerCommand = "";
            string PlayerSelect = "";
            while(PlayerCommand != "quit"){
                if (Player1.health < 50){
                    System.Console.WriteLine("You are badly hurt!");
                }
                else if (Player1.health < 25){
                    System.Console.WriteLine("You are critically injured!");
                }
                if (Monster1.health > 90){
                    System.Console.WriteLine($"A terrifying {Monster1.name} stands before you. It's unhurt.");
                    }
                else if(Monster1.health > 90){
                    System.Console.WriteLine($"A terrifying {Monster1.name} stands before you. It's injured.");
                    }
                else if(Monster1.health > 90){
                    System.Console.WriteLine($"A terrifying {Monster1.name} stands before you. It's badly hurt.");
                    }
                else if(Monster1.health > 90){
                    System.Console.WriteLine($"A terrifying {Monster1.name} stands before you. It's on its last leg.");
                    }
                System.Console.WriteLine("Please input exact command for your action, you can 'draw' or 'discard' if you have card in hand.");
                PlayerCommand = Console.ReadLine();
                if (PlayerCommand == "draw"){
                    Player1.Draw(myDeck.DeckOfCards);
                    }
                if (PlayerCommand == "discard"){
                    string discardSelection = Console.ReadLine();
                    System.Console.WriteLine("Please input exact command for your action, you can 'draw' or 'select' cards you want to play. You can also 'look' at your hand. ");
                    PlayerCommand = Console.ReadLine();
                    }
                if (PlayerCommand == "look"){
                    Player1.LookAtHand(Player1.PlayerHand);
                    }
                if (PlayerCommand == "select"){
                    System.Console.WriteLine("Input the index of the card you want to select");
                    PlayerSelect = Console.ReadLine();
                    Player1.Select(PlayerSelect);
                    }
                System.Console.WriteLine("Processed");
                System.Console.WriteLine("##################################");
                }
            }
        }
}
