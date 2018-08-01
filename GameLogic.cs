using System.Collections.Generic;
using System;

namespace cards{
    public class cards : Player{
         public List<Card> PlayerCardList = new List<Card>();
        public cards(string name) : base(name){
            PlayerCardList = PlayerHand;
        }

        public List<Card> DoubleCard = new List<Card>();
        public void Game(){
            for (int i = 0; i < PlayerCardList.Count; i++)
            {  
                var temp = PlayerCardList[i];
                
                
            }
        }
    }
}