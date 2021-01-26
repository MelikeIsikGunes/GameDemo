using System;
using System.Collections.Generic;
using System.Text;


namespace GameDemo.Entities
{
    class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Detail { get; set; }
        public int UnitInStock { get; set; }

        //public int CompaignId { get; set; } //Foreing Key
    }
}
