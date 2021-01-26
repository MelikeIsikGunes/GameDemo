using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Interfaces
{
    interface ICompaignService
    {
        void Add(Compaign compaign);
        void Delete(Compaign compaign);
        void Update(Compaign compaign);
        

    }
}
