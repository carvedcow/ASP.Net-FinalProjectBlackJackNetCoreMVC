using BlackJackFinalProjectNetCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackFinalProjectNetCoreMVC.ViewModels
{
    public class GameViewModel
    {
        // only contains information that needs to be passed over to the View Pages
        public Game game { get; set; }
        public Player player { get; set; }
        public Player dealer { get; set; }
    }
}
