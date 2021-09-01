﻿using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using StealthhyyBot.Commands;
using DSharpPlus.Interactivity;
using DSharpPlus.Interactivity.Extensions;

namespace StealthhyyBot.Bots
{
    class Bot
    {
        public DiscordClient _client { get; private set; }

        public InteractivityExtension _interactivity { get; private set; }

        public CommandsNextExtension _commands { get; private set; }

        public async Task RunAsync()
        {
            var json = string.Empty;

            using (var fs = File.OpenRead("stealthhyyBotConfig.json"))
            {
                using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                {
                    json = await sr.ReadToEndAsync().ConfigureAwait(false);
                }
            }

            var configJson = JsonConvert.DeserializeObject<ConfigJson>(json);

            var config = new DiscordConfiguration
            {
                Token = configJson.Token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                MinimumLogLevel = LogLevel.Debug
            };

            _client = new DiscordClient(config);

            _client.Ready += OnClientReady;

            _client.UseInteractivity(new InteractivityConfiguration
            {

            });



            var commandsConfig = new CommandsNextConfiguration
            {
                StringPrefixes = new string[] { configJson.Prefix },
                EnableMentionPrefix = true,
                EnableDms = false,
                DmHelp = true,
            };

            _commands = _client.UseCommandsNext(commandsConfig);

            _commands.RegisterCommands<DnDCommands>();

            await _client.ConnectAsync();

            await Task.Delay(-1);
        }

        private Task OnClientReady(DiscordClient c, ReadyEventArgs e)
        {
            return Task.CompletedTask;
        }
    }
}