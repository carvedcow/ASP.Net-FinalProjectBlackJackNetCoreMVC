using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackFinalProjectNetCoreMVC.Models
{
    public class Card
    {
        public string value { get; set; }
        public string suit { get; set; }

        public Card()
        {

        }

        public Card(string v, string s)
        {
            this.value = v;
            this.suit = s;
        }
    }
}
