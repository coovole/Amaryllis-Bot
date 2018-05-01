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
                .AddField("link", "Creates a link that you can use to invite me to your server")
                .AddField("invite", "Generates a link that you can use to join my server!")
                .AddField("daddy", "Daddy's home :heart_eyes:")
                .AddField("delete", "It deletes")
                .AddField("8ball", "__***Amaryllis knows all***__")
                .Color = (Color.Blue);

            await ReplyAsync("", false, builder.Build());
        }
        [Command ("link")]
        public async Task LinkAsync()
        {
            await Context.Message.DeleteAsync();

            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle(">link")
                .WithDescription("A nice link to let me travel to your server. Make sure you give me all the perms so you can use me to my full potential!")
                .WithColor(Color.DarkGreen);
            await ReplyAsync("", false, builder.Build());
        }
        [Command ("invite")]
        public async Task InviteAsync()
        {
            await Context.Message.DeleteAsync();

            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle(">invite")
                .WithDescription("An invite to my own personal discord server. Join to add suggestions, get updates quick, and to just have some fun :confetti_ball:")
                .WithColor(Color.DarkPurple);
            await ReplyAsync("", false, builder.Build());
        }
        [Command ("daddy")]
        public async Task DaddyAsync()
        {
            await Context.Message.DeleteAsync();

            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle(">daddy")
                .WithDescription("Are you ready for Daddy? :wink: Add a mention after the command to give Daddy a princess! >dad works as well btw")
                .WithColor(Color.DarkMagenta);
            await ReplyAsync("", false, builder.Build());
        }
        [Command ("delete")]
        public async Task DeleteAsync()
        {
            await Context.Message.DeleteAsync();

            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle(">delete")
                .WithDescription("It deletes messages. Enter how many messages you wish to delete after >delete. Beware the purge :fearful: ***disclaimer, you need the manage messages permission to be able to use this command**")
                .WithColor(Color.DarkRed);
            await ReplyAsync("", false, builder.Build());
        }
        [Command("8ball")]
        public async Task BallAsync()
        {
            await Context.Message.DeleteAsync();

            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle(">8ball")
                .WithDescription("The Great Oracle Amaryllis will answer all of your divine questions. >8 works just as fine. All you have to do is type >8 and ask a simple question")
                .WithColor(Color.Teal);
            await ReplyAsync("", false, builder.Build());
        }
    }
}
