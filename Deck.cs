using System.Collections.Generic;
using System;

namespace cards{
    public class Deck{
        public List<Card> DeckOfCards = new List<Card>();
        public Deck(){
            for(int i = 1; i <= 13; i++){
                for (int j = 1; j <=4; j++){
                    if (j==1){
                        Card card = new Card("Spades", i);
                        this.DeckOfCards.Add(card);
                    }
                    else if (j==2){
                        Card card = new Card("Hearts", i);
                        this.DeckOfCards.Add(card);
                    }
                    else if (j==3){
                        Card card = new Card("Diamonds", i);
                        this.DeckOfCards.Add(card);
                    }
                    else if (j==4){
                        Card card = new Card("Clubs", i);
                        this.DeckOfCards.Add(card);
                   }
               }
           }
           System.Console.WriteLine("Cards Generated");
        }
        
        public Card Deal(List<Card> DeckOfCards){
            Card temp = DeckOfCards[0];
            DeckOfCards.RemoveAt(0);
            System.Console.WriteLine("Card dealt!");
            System.Console.WriteLine("It is a " + DeckOfCards[0].stringVal);
            return temp;
        }
        public void Reset(){
            DeckOfCards.Clear();
            for(int i = 1; i <= 13; i++){
                for (int j = 1; j <=4; j++){
                    if (j==1){
                        Card card = new Card("Spades", i);
                        this.DeckOfCards.Add(card);
                    }
                    else if (j==2){
                        Card card = new Card("Hearts", i);
                        this.DeckOfCards.Add(card);
                    }
                    else if (j==3){
                        Card card = new Card("Diamonds", i);
                        this.DeckOfCards.Add(card);
                    }
                    else if (j==4){
                        Card card = new Card("Clubs", i);
                        this.DeckOfCards.Add(card);
                   }
               }
           }
            System.Console.WriteLine("Deck reset!");
        }
        public void Shuffle(List<Card> DeckOfCards){
            System.Console.WriteLine("Shuffling deck...");
            Random rand = new Random();
            for (int i = 0; i < DeckOfCards.Count; i++){
                int index = rand.Next(DeckOfCards.Count);
                Card temp = DeckOfCards[i];
                DeckOfCards[i] = DeckOfCards[index];
                DeckOfCards[index] = temp;
            }
            System.Console.WriteLine("Deck shuffled!");
        }
    }
}
