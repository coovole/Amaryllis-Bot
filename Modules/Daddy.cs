using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace AmaryllisBot.Modules
{
    public class Daddy : ModuleBase<SocketCommandContext>
    {
        Random rand;
        
        string[] Dad;

        [Command("daddy")]
        [Alias("dad")]
        public async Task DaddyAsync([Remainder] string yes = null)
        {
            await Context.Message.DeleteAsync();
            rand = new Random();
            Dad = new string[]
            {
                "Images/200px-Taric_2.jpg",//0
                "Images/Graves_5.jpg",//1
                "Images/santa_braum_by_yy6242-dapgald.jpg",//2
                "Images/OWRwZCZ.png"//3
            };
            int randomPic = rand.Next(Dad.Length);
            string DaddyPic = Dad[randomPic];
            if (yes == null)
            {
                await Context.Channel.SendMessageAsync($"Who's Daddy's princess? {Context.User.Mention} is :smirk:");
                await Context.Channel.SendFileAsync(DaddyPic);
            }
            else
            {
            await Context.Channel.SendMessageAsync($"Who's Daddy's princess? {yes} is :smirk:");
            await Context.Channel.SendFileAsync(DaddyPic);
            }

        }
    }
}
