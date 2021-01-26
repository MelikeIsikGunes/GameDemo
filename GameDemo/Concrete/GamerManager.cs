using GameDemo.Entities;
using GameDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "  kişisinin kimlik bilgileri doğrulandı.");
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "  sisteme eklendi.");
            }
            else
            {
                throw new Exception("Not a valid person"); //Geçerli bir kişi değil.
            }

            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "  sistemden silindi.");
        }
     
        public void Update(Gamer gamer)
        {   
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "  güncellendi.");
        }
    }
}
