using Discord;
using Discord.Commands;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DiscordBot1.Modules
{
	public class Test : ModuleBase<SocketCommandContext>
	{

		[Command("List")]
		public async Task List()
		{
			await Context.Channel.SendMessageAsync("drop\n" +
				"Hi\n" +
				"Bee\n" +
				"Tendies\n" +
				"Gabe\n" +
				"Pleasure\n" +
				"WrongNeighborhood\n" +
				"Phoon\n" +
				"Compliment\n" +
				"VP\n" +
				"BigBrain\n" +
				"bbq\n" +
				"Version\n" +
				"Tyler1\n" +
				"Tyler2\n" +
				"ILoveYou\n" +
				"Wednesday\n" +
				"Blyat\nBBC\n" +
				"tunaktunak\n" +
				"Plup\n" +
				"itsinmycode\n" +
				"wise\n" +
				"sand");
		}

		[Command("drop")]
		public async Task drops()
		{
			Random random = new Random();
			int randomNumber = random.Next(0, 1001);
			if (randomNumber <= 1)
			{
				await Context.Channel.SendMessageAsync("[You have just received one (1) StatTrak\u2122 Gut Knife Rust Coat!!!!!!!!!!!!!!!!!!!!!!!]");
			}
			else if (2 <= randomNumber && randomNumber <= 10)
			{
				await Context.Channel.SendMessageAsync("[You have just received one (1) Souvenir AWP Dragon Lore]!!!!!!!!!");
			}
			else if (11 <= randomNumber && randomNumber <= 200)
			{
				await Context.Channel.SendMessageAsync("[You have just received one (1) StatTrak\u2122 AK-47 Bloodsport]");
			}

			else if (200 < randomNumber && randomNumber < 600)
			{
				await Context.Channel.SendMessageAsync("[You have just received one (1) StatTrak\u2122 Sawed-Off Zander]");
			}

			else if (600 <= randomNumber && randomNumber <= 1000)
			{
				await Context.Channel.SendMessageAsync("[You have just received one (1) M4A1-S Boreal Forest]");
			}
		}

		[Command("Hi")]
		public async Task Hi()
		{
			await Context.Channel.SendMessageAsync("Hello", true);
		}

		[Command("Bee")]
		public async Task Bee()
		{
			await Context.Channel.SendMessageAsync("According to all known laws of aviation, there is no way that a bee should be able to fly. Its wings are too small to get its fat little body off the ground. The bee, of course, flies anyways. Because bees don't care what humans think is impossible.", true);
		}

		[Command("Tendies")]
		public async Task Tendies()
		{
			await Context.Channel.SendMessageAsync("REEEEEEEEEEE!", true);
		}

		[Command("Gabe")]
		public async Task Gabe()
		{
			await Context.Channel.SendMessageAsync("Bork Bork Bork", true);
		}

		[Command("Pleasure")]
		public async Task Pleasure()
		{
			await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=5u3iv8AT8G8");
		}

		[Command("WrongNeighborhood")]
		public async Task WrongNeighborhood()
		{
			await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=4feUSTS21-8");
		}

		[Command("Phoon")]
		public async Task Phoon()
		{
			await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=SNvDUO42Hys");
			await Context.Channel.SendMessageAsync("Enjoy your video, Ethan.", true);
		}

		//[command("phoon")]
		//public async task phoon(iuser x)
		//{
		//	await context.channel.sendmessageasync("https://youtu.be/snvduo42hys");
		//	await context.channel.sendmessageasync(x.username);
		//	if (x.username == "eroy#3698")
		//	{
		//		await context.channel.sendmessageasync("enjoy your video, ethan.", true);
		//	}
		//}

		[Command("Compliment")]
		public async Task Compliment()
		{
			await Context.Channel.SendMessageAsync("You are so smart, beautiful, and inspiring!", true);
		}

		[Command("VP")]
		public async Task VP()
		{
			await Context.Channel.SendMessageAsync("TACO has more talent in one pinky than that entire team", true);
		}

		[Command("BigBrain")]
		public async Task BigBrain()
		{
			await Context.Channel.SendMessageAsync("You must be talking about my boy, Taco", true);
		}

		[Command("BBQ")]
		public async Task BBQ()
		{
			await Context.Channel.SendMessageAsync("http://oi63.tinypic.com/15rms6p.jpg");
		}

		[Command("Wise")]
		public async Task Wise()
		{
			await Context.Channel.SendMessageAsync("This command has been disabled because it is too much power for one person to have.", true);
			//	await Context.Channel.SendMessageAsync("https://i.imgur.com/e9Hua8i.png");
			//	await Context.Channel.SendMessageAsync("Did you ever hear the tragedy of Darth Plagueis The Wise? I thought not. It’s not a story the Jedi would tell you. It’s a Sith legend. Darth Plagueis was a Dark Lord of the Sith, so ", true);
			//	await Context.Channel.SendMessageAsync("powerful and so wise he could use the Force to influence the midichlorians to create life… He had such a knowledge of the dark side that he could even keep the ones he cared about from ", true);
			//	await Context.Channel.SendMessageAsync("dying. The dark side of the Force is a pathway to many abilities some consider to be unnatural. He became so powerful… the only thing he was afraid of was losing his power, which ", true);
			//	await Context.Channel.SendMessageAsync("eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. Ironic. He could save others from death, but not ", true);
			//	await Context.Channel.SendMessageAsync("himself.", true);
		}

		[Command("Tyler1")]
		public async Task Tyler1()
		{
			await Context.Channel.SendMessageAsync("<:T1:400092034318336001><:T2:400092081948721154>\n<:T3:400092093470605312><:T4:400092104220475392>");
		}

		[Command("Tyler2")]
		public async Task Tyler2()
		{
			await Context.Channel.SendMessageAsync("<:DOIT:280471015744733184>");
		}

		[Command("Iloveyou")]
		public async Task ILoveYou()
		{
			await Context.Channel.SendMessageAsync("I am a bot incapable of love!", true);
		}

		[Command("Wednesday")]
		public async Task Wednesday()
		{
			DateTime today = DateTime.Today;

			if (today.DayOfWeek == DayOfWeek.Wednesday)
			{
				await Context.Channel.SendMessageAsync("It is Wednesday, my dudes!", true);

				Random random = new Random();
				int randomNumber = random.Next(0, 12);
				if (randomNumber == 0)
				{
					await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=csqJK8wwaHw");
				}

				else if(randomNumber == 1)
				{
					await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=YSDAAh6Lps4");
				}

				else if (randomNumber == 2)
				{
					await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=Oct2xKMGOno");
				}
				else if (randomNumber == 3)
				{
					await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=fyJGKEswuSc");
				}
				else if (randomNumber == 4)
				{
					await Context.Channel.SendMessageAsync("https://youtube.com/watch?v=hzGQSlrB1_o");
				}
				else if (randomNumber == 5)
				{
					await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=szqNmefKXxc");
				}
				else if (randomNumber == 6)
				{
					await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=JHO61_wDC30");
				}
				else if (randomNumber == 7)
				{
					await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=M1qDwf6RHaI");
				}
				else if (randomNumber == 8)
				{
					await Context.Channel.SendMessageAsync("https://youtu.be/Y_xlWdgi1ew");
				}
				else if (randomNumber == 9)
				{
					await Context.Channel.SendMessageAsync("https://youtu.be/SePVlroq6AI?t=2s&o=0");
				}
				else if (randomNumber == 10)
				{
					await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=7aTtNNjIyi4");
				}
				else if (randomNumber == 11)
				{
					await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=nUKQThJiDL0");
				}
				else if (randomNumber == 12)
				{
					await Context.Channel.SendMessageAsync("https://youtu.be/TMYlifKHakc");
				}


			}
			
			else
			{
				await Context.Channel.SendMessageAsync("Today is not Wednesday.");
			}

		}

		[Command("Blyat")]
		public async Task Blyat()
		{
			await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=QiFBgtgUtfw");
		}

		[Command("itsinmycode")]
		public async Task itsinmycode()
		{
			await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=iXj_GDktXaA");
		}

		[Command("bbc")]
		public async Task BBC()
		{
			await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=V5NUBAwvUlU");
		}

		[Command("tunaktunak")]
		public async Task tunaktunak()
		{
			await Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=vTIIMJ9tUc8");
		}

		[Command("plup")]
		public async Task plup()
		{
			await Context.Channel.SendMessageAsync("This channel is now property of the Plup Club\u2122");
		}

		[Command("sand")]
		public async Task sand()
		{
			await Context.Channel.SendMessageAsync("I don't like sand. It's coarse and rough and irritating and it gets everywhere.", true);
		}

		[Command("gamedesign")]
		public async Task gamedesign()
		{
			await Context.Channel.SendMessageAsync("minus nuke plus canals", true);
		}

		[Command("Version")]
		public async Task Version()
		{
			await Context.Channel.SendMessageAsync("1.1");
		}
	}
}
