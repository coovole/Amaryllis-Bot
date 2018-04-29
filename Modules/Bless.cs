using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace AmaryllisBot.Modules
{
    public class Bless : ModuleBase<SocketCommandContext>
    {
        [Command("bless", RunMode = RunMode.Async)]
        public async Task Blessing([Remainder]string Dab)
        {
            await Context.Message.DeleteAsync();
            await Context.Channel.SendMessageAsync($"{Dab} has just been blessed");
            await Context.Channel.SendFileAsync("Dab/50093-full.png");
        }
    }
}
