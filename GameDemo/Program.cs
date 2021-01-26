using GameDemo.Interfaces;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncu Ekleme
            IGamerService gamerService = new GamerManager(new GamerCheckManager());
            IGamerCheckService gamerCheckService = new GamerCheckManager();
            Gamer gamer1 = new Gamer() 
            {
                Id = 1,
                FirstName = "Melike",
                LastName = "Işık",
                DateOfBirth = new DateTime(1996, 8, 10),
                NationalityId = "12345678910"
            };
            Gamer gamer2 = new Gamer()
            {
                Id = 2,
                FirstName = "Müge",
                LastName = "Işık",
                DateOfBirth = new DateTime(2000, 8, 13),
                NationalityId = "12345678910"
            };
            
            gamerService.Add(gamer1);
            gamerService.Add(gamer2);    
           
            
            gamerService.Delete(gamer1);  //Oyuncu Silme
            gamer2.FirstName = "Nimet Müge";
            gamerService.Update(gamer2);

            IGameService gameService = new GameManager();
            Game game1 = new Game()
            {
                Id = 1,
                Name = "Grand Theft Auto 5",
                Price = 152.10,
                Detail = "Grand Theft Auto serisinin beşinci oyunudur. Tüm GTAV hikayesi, GTA Online ve mevcut içerik ve yükseltmelerin tümünün yanı sıra GTA Online’da kendi suç imparatorluğunu kurmanın en kısa yolu Criminal Enterprise Başlangıç Paketi de bulunuyor.",
                UnitInStock = 1,
            };

            Game game2 = new Game()
            {
                Id = 2,
                Name = "The Sims 4",
                Price = 265,
                Detail = "The Sims 4, serinin önceki oyunları gibi yaşam simülasyonu oyunudur. Oyuncular bir Sim karakteri yaratırlar ve oyunda farklı Sim kişiliklerini keşfederek oyuna yön verirler. Simler daha önceki oyunlardan farklı olarak aynı anda iki fiziksel eylemi gerçekleştirebilir. Ayrıca Simlerin modları da oyun akışını değiştirebilir. Örneğin kızgın ya da heyecanlı bir Sim, verilen bir görevi daha hızlı yapar.",
                UnitInStock = 2,
            };

            //Kampanya ekleme

            ICompaignService compaignService = new CompaignManager();
            Compaign compaign1 = new Compaign()
            {
                Id = 1,
                Name = "Black Friday Compaign",
                Discount = 10,
            };

            Compaign compaign2 = new Compaign()
            {
                Id = 2,
                Name = "Happy New Year Compaign",
                Discount = 20,
            };

            compaignService.Add(compaign1);
            compaignService.Add(compaign2);

            gameService.ApplyCompaign(compaign1, game1);
            gameService.ApplyCompaign(compaign1, game2);

            gameService.SellGame(game1, gamer2);
            gameService.SellGame(game2, gamer2);
            gameService.SellGame(game1, gamer1);

        }
    }
}
