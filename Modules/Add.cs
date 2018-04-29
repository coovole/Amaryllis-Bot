using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace AmaryllisBot.Modules
{
    public class Add : ModuleBase<SocketCommandContext>
    {
        [Command("link")]
        public async Task LinkAsync()
        {
            await Context.Message.DeleteAsync();
            await ReplyAsync("Add me at: https://discordapp.com/api/oauth2/authorize?client_id=439656759297179663&permissions=8&scope=bot");
        }
    }
}
