using System.Collections.Generic;

namespace cards{

    public class Player{
        public List<Card> PlayerHand = new List<Card>();
        public List<Card> PlayerSelection = new List<Card>();
        public string name;
    
    public Player(string name){
        this.name = name;
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
        System.Console.WriteLine("Index: "+ i + " - "  + PlayerHand[i].stringVal);
        System.Console.WriteLine("The following cards are selected and will be played if you 'confirm'");
        }
    }
    public void Select(int index){
        Card temp = PlayerHand[index];
        PlayerHand.RemoveAt(index);
        PlayerSelection.Add(temp);
        }
    }
}