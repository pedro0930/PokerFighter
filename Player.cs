using System.Collections.Generic;

namespace cards{

    public class Player{
        public List<Card> PlayerHand = new List<Card>();
        public string name;
    
    public Player(string name){
        this.name = name;
    }
    public Card Draw(List<Card> DeckOfCards){
        Card temp = DeckOfCards[0];
        DeckOfCards.RemoveAt(0);
        PlayerHand.Add(temp);
        System.Console.WriteLine("Player hand is currently: "+ PlayerHand.Count);
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
    public void LookAtHand(){
        System.Console.WriteLine();
    }
    }
}