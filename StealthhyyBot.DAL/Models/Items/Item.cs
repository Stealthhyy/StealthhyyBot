using System;
using System.Collections.Generic;
using System.Text;

namespace StealthhyyBot.DAL.Models.Items
{
    public class Item : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
