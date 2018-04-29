using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Luna_Bot.Modules
{
    public class Invite : ModuleBase<SocketCommandContext>

    {
        [Command("invite")]
        public async Task InviteAsync()
        {
            await Context.Message.DeleteAsync();
            await ReplyAsync("Come join me! https://discord.gg/GcSjQ3b");
        }
    }
}
