﻿using GameDemo.Entities;
using GameDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true; //Hep doğruymuş gibi gösterdim
        }


    }
}
