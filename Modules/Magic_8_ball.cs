using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace AmaryllisBot.Modules
{
    public class Magic_8_ball : ModuleBase<SocketCommandContext>
    {
        Random rand;
        string[] answers;

        [Command("8ball")]
        [Alias("8")]
        public async Task BallAsync([Remainder] string useless = null)
        {
            rand = new Random();
            answers = new string[]
            {
                "Outlook is good",
                "Absolutely",
                "Yes",
                "Negative",
                "Reply hazy, try again later",
                "Maybe",
                "Go for it",
                "Very Likely",
                "No",
                "No Doubt",
                "Impossible",
                "Outlook not so good",
                ":no_good:",
                ":thumbsup:",
                ":thumbsdown:",
                ":ok_hand:",
                ":thinking:"
            };
            int lies = rand.Next(answers.Length);
            string truth = answers[lies];
            await ReplyAsync(truth);
        }
    }
}
