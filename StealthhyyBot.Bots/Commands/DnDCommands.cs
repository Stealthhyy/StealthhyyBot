using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Interactivity.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StealthhyyBot.DAL;
using StealthhyyBot.Bots;

namespace StealthhyyBot.Commands
{
    public class DnDCommands : BaseCommandModule
    {
        [Command("respondmessage")]
        public async Task RespondMessage(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel);

            await ctx.Channel.SendMessageAsync(message.Result.Content);
        }

        [Command("respondreaction")]
        public async Task RespondReaction(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            var message = await interactivity.WaitForReactionAsync(x => x.Channel == ctx.Channel);

            await ctx.Channel.SendMessageAsync(message.Result.Emoji);
        }

        [Command("additem")]
        public async Task AddItem(CommandContext ctx, string name)
        {
            //await _contex
        }
    }
}
