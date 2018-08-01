namespace cards{
    public class Card{
        public string stringVal {get;set;}
        public string suit {get;set;}
        public int val {get;set;}

        public Card (string suit, int val){
            this.suit = suit;
            this.val = val;
            if(val == 1){
                this.stringVal = ($"Ace of {suit}");               
            }
            else if(val == 11){
                this.stringVal = ($"Jack of {suit}");               
            }
            else if(val == 12){
                this.stringVal = ($"Queen of {suit}");               
            }
            else if(val == 13){
                this.stringVal = ($"King of {suit}");               
            }
            else{
            this.stringVal = ($"{val} of {suit}");
            }
        }
    }
}
    