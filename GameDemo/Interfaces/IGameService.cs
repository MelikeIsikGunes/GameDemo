using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Interfaces
{
    interface IGameService
    {
        void SellGame(Game game, Gamer gamer);
        void ApplyCompaign(Compaign compaign, Game game);
    }
}
