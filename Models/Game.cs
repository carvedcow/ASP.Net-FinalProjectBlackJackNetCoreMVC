using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackFinalProjectNetCoreMVC.Models
{
    // Game status outcomes
    public enum Status
    {
        gameOn,
        gameOff,
        playerWin,
        houseWin,
        draw,
        blackjack
    }
    public class Game
    {
        // values
        public Player player { get; set; } = new Player(500);
        public Player dealer { get; set; } = new Player();
        public List<Card> deck { get; set; }
        public int bet { get; set; }
        public Status status { get; set; } = Status.gameOn;
        public List<string> values { get; set; } = new List<string>
        {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K",
            "A"
        };

        public List<string> suits { get; set; } = new List<string>
        {
            "S",
            "D",
            "H",
            "C"
        };

        // methods

        public void newShuffledDeck()
        {
            deck = new List<Card>();
            

            // add cards to deck
            for (int i = 0; i < values.Count; i++)
            {
                for (int j = 0; j < suits.Count; j++)
                {
                    deck.Add(new Card(values[i], suits[j]));
                }
            }

            Random rng = new Random();
            int n = deck.Count;

            // shuffle
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }

        // draw card from top of deck
        public Card dealCard(List<Card> d)
        {
            Card card = d.First();
            d.RemoveAt(0);
            return card;
        }

        // game start
        public void firstDeal()
        {
            player.hand.Add(dealCard(deck));
            player.hand.Add(dealCard(deck));
            dealer.hand.Add(dealCard(deck));
        }

        // player hits
        public void hitPlayer()
        {
            //if (player.score < 21)
            player.hand.Add(dealCard(deck));
            if (player.score >= 21)
                standPlayer();
        }

        public void hitDealer()
        { 
            while (dealer.score < 17)
                dealer.hand.Add(dealCard(deck));
        }

        // player stands
        public string standPlayer()
        {
            if (player.score == 21 && player.hand.Count() == 2)
            {
                // deal card to dealer
                hitDealer();

                if (dealer.score == 21 && dealer.hand.Count() == 2)
                {
                    // Player Loses
                    status = Status.houseWin;
                    return Message(status);
                }
                else
                {
                    player.money += (int)(2.5 * bet);
                    status = Status.blackjack;
                    return Message(status);
                }
            }



            if (player.score > 21)
            {
                status = Status.houseWin;
                return Message(status);
            }
            else
            {
                hitDealer();

                if (dealer.score > 21)
                {
                    // Player wins
                    player.money += (2 * bet);
                    status = Status.playerWin;
                    return Message(status);
                }

                if (dealer.score > player.score)
                {
                    // Player loses
                    status = Status.houseWin;
                    return Message(status);
                }

                else if (dealer.score == player.score)
                {
                    // Draw
                    player.money += bet; // players original Bet
                    status = Status.draw;
                    return Message(status);
                }

                else
                {
                    // Player wins
                    player.money += (2 * bet);
                    status = Status.playerWin;
                    return Message(status);
                }
            }
            

        }
        public void clearRound()
        {
            newShuffledDeck();
            dealer.hand.Clear();
            player.hand.Clear();
            bet = 0;
            status = Status.gameOn;
        }

        private static string Message(Status status)
        {
            switch (status)
            {
                case Status.playerWin:
                    return "You Win";
                case Status.houseWin:
                    return "You Lose";
                case Status.blackjack:
                    return "BlackJack!";
                case Status.draw:
                    return "Draw";
                default:
                    return "";
            }
        }

    }
}
