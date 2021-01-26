﻿using GameDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    class Gamer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string NationalityId { get; set; }

    }
}
