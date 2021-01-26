using GameDemo.Entities;
using GameDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class CompaignManager : ICompaignService
    {
        
        public void Add(Compaign compaign)
        {
            Console.WriteLine(compaign.Name+"  sisteme eklendi.");
        }
        

        public void Delete(Compaign compaign)
        {
            Console.WriteLine(compaign.Name + "  sistemden silindi.");
        }

        public void Update(Compaign compaign)
        {
            Console.WriteLine(compaign.Name + "  güncellendi.");
        }
    }
}
