using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace cards{

    public class Player{
        public List<Card> PlayerHand = new List<Card>();
        public List<Card> PlayerSelection = new List<Card>();
        public string name;
        public int health;
    
    public Player(string name){
        this.name = name;
        this.health = 100;
        }
    public Card Draw(List<Card> DeckOfCards){
        Card temp = DeckOfCards[0];
        DeckOfCards.RemoveAt(0);
        PlayerHand.Add(temp);
        return temp;
        }
    public Card Discard(int index){
        if(index > PlayerHand.Count){
            System.Console.WriteLine("No card at index!");
            return null;
        }else{
            Card temp = PlayerHand[index];
            PlayerHand.RemoveAt(index);
            return temp;
        }
    }
    public void LookAtHand(List<Card> PlayerHand){
        System.Console.WriteLine("The following cards are in your hand");
        for (int i = 0; i < PlayerHand.Count; i++){
<<<<<<< HEAD
        System.Console.WriteLine("Index: "+ i + " - "  + PlayerHand[i].stringVal);
        // System.Console.WriteLine("The following cards are selected and will be played if you 'confirm'");

        
=======
            System.Console.WriteLine("Index: "+ i + " - "  + PlayerHand[i].stringVal);
>>>>>>> master
        }
            System.Console.WriteLine("The following cards are selected and will be played if you 'confirm'");
        for (int i = 0; i < PlayerSelection.Count; i ++){
            System.Console.WriteLine("Index: "+ i + " - "  + PlayerSelection[i].stringVal);
        }
        
    }
    public void Select(string indexStr){
        int index = Int32.Parse(indexStr);
        Card temp = PlayerHand[index];
        PlayerHand.RemoveAt(index);
        PlayerSelection.Add(temp);
        }
    public void AllCard(List<Card> AllCards){
        AllCards = PlayerSelection;

        for (int i = 0; i < AllCards.Count; i++)
        {
            for (int j = i; i < AllCards.Count; i++)
            {
                if(AllCards[i].val == AllCards[j].val){
                    System.Console.WriteLine("Found Double");
                }
            }
            
        }
        }
    }


}