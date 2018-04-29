using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmaryllisBot.Modules
{
    [Group("help")]
    public class Help : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task HelpAsync()
        {
            await Context.Message.DeleteAsync();

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Help", "Here are all my commands; if you want more info, type in the command after >help")
                .AddField("Promotion", "link")
                .AddField("Field3", "answer")
                .Color = (Color.Blue);

            await ReplyAsync("", false, builder.Build());
        }
        [Command ("link")]
        public async Task LinkAsync()
        {
            await Context.Message.DeleteAsync();

            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle(">link")
                .WithDescription("a nice link to let me travel to your server")
                .WithColor(Color.DarkGreen);
            await ReplyAsync("", false, builder.Build());

        }
    }
}
