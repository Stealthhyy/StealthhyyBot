using Microsoft.EntityFrameworkCore;
using StealthhyyBot.DAL.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace StealthhyyBot.DAL
{
    public class RPGContext : DbContext
    {
        public RPGContext(DbContextOptions<RPGContext> options) : base(options) { }

        public DbSet<Item> Items { get; set;}
    }
}
