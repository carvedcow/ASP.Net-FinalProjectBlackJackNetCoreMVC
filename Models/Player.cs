using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackFinalProjectNetCoreMVC.Models
{
    public class Player
    {
        // values
        public int money { get; set; }
        public List<Card> hand { get; set; } = new List<Card>();
        public int score
        {
            get 
            {
                int score = 0;
                int aceCount = 0;

                foreach (Card c in hand)
                {
                    if (c.value == "A")
                    {
                        score += 11;
                        aceCount++;
                    }

                    else if (c.value == "10" || c.value == "J" || c.value == "Q" || c.value == "K")
                    {
                        score += 10;
                    }
                    else
                    {
                        score += int.Parse(c.value);
                    }
                }

                if (score > 21)
                {
                    while (aceCount > 0)
                    {
                        score -= 10;
                        aceCount--;
                        if (score <= 21) break;
                    }
                }
                return score;
            } 
        }

        // constructors
        public Player() { }
        public Player(int money) { this.money = money; }
    }
}
