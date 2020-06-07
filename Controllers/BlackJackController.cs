using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackJackFinalProjectNetCoreMVC.Models;
using BlackJackFinalProjectNetCoreMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BlackJackFinalProjectNetCoreMVC.Controllers
{
    public class BlackJackController : Controller
    {
        // static game and deck for the session
        public static Game game = new Game();

        // GET BET
        public IActionResult BlackJackBet()
        {
            // ff no more money
            if (game.player.money <= 0)
            {
                @ViewData["Message"] = "Game Over.";
            }

            // return vm
            GameViewModel gvm = CreateGameViewModel(game);
            return View(gvm);
        }

        // POST BET
        [HttpPost]
        public IActionResult BlackJackBet(int bet, string action)
        {
            // Start Over available if no more money
            if (action == "startover")
            {
                game = new Game();
                GameViewModel gvm = CreateGameViewModel(game);
                return View(gvm);
            }

            else if (action == "bet")
            {
                game.player.money -= bet;
                game.bet = bet;
                return RedirectToAction("BlackJackGame");
            }
            else
            {
                //return vm in case something breaks
                GameViewModel gvm = CreateGameViewModel(game);
                return View(gvm);
            }

        }

        // GET GAME
        public IActionResult BlackJackGame()
        {
            // Create a new Deck
            game.newShuffledDeck();

            // Deal the first cards
            game.firstDeal();

            // return vm
            GameViewModel gvm = CreateGameViewModel(game);
            return View(gvm);
        }

        // POST GAME
        [HttpPost]
        public IActionResult BlackJackGame(string action)
        {
            // Restart Button Pressed, only available at the end of a round
            if (action == "restart")
            {
                game.clearRound();
                return RedirectToAction("BlackJackBet");
            }

            // hit button pressed
            if (action == "hit")
            {
                game.hitPlayer();
            }

            // stand button pressed
            if (action == "stand")
            {
                @ViewData["Message"] = game.standPlayer();
            }

            //return vm
            GameViewModel gvm = CreateGameViewModel(game);
            return View(gvm);
        }


        // View Model contains an copy of the current game
        private static GameViewModel CreateGameViewModel(Game game)
        {
            return new GameViewModel
            {
                player = game.player,
                dealer = game.dealer,
                game = game
            };
        }
    }
}