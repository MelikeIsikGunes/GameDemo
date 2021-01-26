using GameDemo.Entities;
using GameDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class GameManager : IGameService
    {
        private double _gamePrice;
        public void ApplyCompaign(Compaign compaign, Game game)
        {
            _gamePrice = game.Price;
            game.Price -= game.Price * (compaign.Discount / 100);
            Console.WriteLine(game.Name + " oyunu " +_gamePrice+ " yerine " + game.Price + " TL");
        }
        
        public void SellGame(Game game, Gamer gamer)
        {
           
            if (game.UnitInStock>0)
            {
                Console.WriteLine(game.Name+" oyunu "+ gamer.FirstName+" " + gamer.LastName+" kişiye satıldı.");
                
            }
            else
            {
                Console.WriteLine(game.Name + " stokta yok.");
            }
            
        }
    }
}
