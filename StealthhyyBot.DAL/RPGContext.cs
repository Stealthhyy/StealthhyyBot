using Microsoft.EntityFrameworkCore;
using StealthhyyBot.DAL.Models.Items;
using StealthhyyBot.DAL.Models.Profiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace StealthhyyBot.DAL
{
    public class RPGContext : DbContext
    {
        public RPGContext(DbContextOptions<RPGContext> options) : base(options) { }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ProfileItem> ProfileItems { get; set; }
    }
}
