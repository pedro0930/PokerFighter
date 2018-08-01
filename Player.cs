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
            if(PlayerHand.Count == 0){
                System.Console.WriteLine("You have no card!");
                }
            else{
                for (int i = 0; i < PlayerHand.Count; i++){
                    System.Console.WriteLine("Index: "+ i + " - "  + PlayerHand[i].stringVal);
                }            
            }
        }
        public void Select(string indexStr){
            int index = Int32.Parse(indexStr);
            Card temp = PlayerHand[index];
            PlayerHand.RemoveAt(index);
            PlayerSelection.Add(temp);
            }

        public int AllCard(){
            
            int Max = this.PlayerHand[0].val;
            for (int i = 0; i < this.PlayerHand.Count; i++)
            {
                if( this.PlayerHand[i].val > Max){
                    Max = this.PlayerHand[i].val;
                }
                
                for (int j = i+1; j < this.PlayerHand.Count; j++)
                {
                    if(this.PlayerHand[i].val == this.PlayerHand[j].val){
                        System.Console.WriteLine("Found Pair");
                        Card pair1 = this.PlayerHand[i];
                        this.PlayerHand.Clear();
                        return (pair1.val * 2);
                    }
                }
            }

            return Max;
        }


    }


}