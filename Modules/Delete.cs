using System;
using System.Reflection;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using AmaryllisBot;
using AmaryllisBot.Modules;
using System.Collections.Generic;

namespace AmaryllisBot.Modules
{
    public class Delete : ModuleBase<SocketCommandContext>
    {
        [Command("delete"), RequireUserPermission(Discord.GuildPermission.ManageMessages)]
        public async Task PurgeAsync(int amount)
        {
            var messages = await Context.Channel.GetMessagesAsync(amount + 1).Flatten();

            await Context.Channel.DeleteMessagesAsync(messages);
            await ReplyAsync($"Deleted {amount} messages!");
        }
    }
}
