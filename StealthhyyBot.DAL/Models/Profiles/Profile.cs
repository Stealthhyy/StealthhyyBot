﻿using StealthhyyBot.DAL.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace StealthhyyBot.DAL.Models.Profiles
{
    public class Profile : Entity
    {
        public ulong DiscordId { get; set; }
        public ulong GuildId { get; set; }
        public int Gold { get; set; }
        public int Xp { get; set; }
        public int Level => Xp / 100;

        public List<ProfileItem> Items { get; set; } = new List<ProfileItem>();
    }
}
