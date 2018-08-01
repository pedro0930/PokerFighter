using System;
using System.Collections.Generic;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up
            System.Console.WriteLine("Please Input Player 1 name");
            string Player1Name = Console.ReadLine();
            System.Console.WriteLine("Player 1 is: " + Player1Name);
            Deck myDeck = new Deck();
            Player Player1 = new Player(Player1Name);
            myDeck.Shuffle(myDeck.DeckOfCards);
            for (int i = 0; i<=13; i++){
                Player1.Draw(myDeck.DeckOfCards);
                }
            // Game starts below this line
            string PlayerCommand = "";
            while(PlayerCommand != "quit"){
                System.Console.WriteLine("Please input exact command for your action, you can 'draw' or 'discard' if you have card in hand.");
                PlayerCommand = Console.ReadLine();
                if (PlayerCommand == "draw"){
                    Player1.Draw(myDeck.DeckOfCards);
                    }
                if (PlayerCommand == "discard"){
                    string discardSelection = Console.ReadLine();
                    System.Console.WriteLine("Please input exact command for your action, you can 'draw' or 'discard' if you have card in hand.");
                    PlayerCommand = Console.ReadLine();
                    }
                if (PlayerCommand == "look"){
                    Player1.LookAtHand(Player1.PlayerHand);
                }
                System.Console.WriteLine("Shit happened");
                System.Console.WriteLine("Please input exact command for your action, you can 'draw' or 'discard' if you have card in hand.");
                PlayerCommand = Console.ReadLine();
                }
            }
        }
        
    }

