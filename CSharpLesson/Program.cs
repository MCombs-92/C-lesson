﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson
{
	class Program
	{
		struct gamer
		{
			public string name;
			public int favnbr;
		}

		static void Main(string[] args)
		{
			int a = 20;
			int b = a + 144;


			int x = 23 * 37;
			int y = x - 41;
			int z = y / 7;
			string aStr = a.ToString();


			string name = "Mitchell";
			int days = 6;
			string stuff = "My name is" + " " + name + ", " + "I've been in bootcamp for" + " " + days.ToString() + " " + "days.";

			int day = 365;
			int year = 25;
			int Incompleteyeartwo = 4 + 31 + 30 + 31 + 31 + 28 + 31 + 30 + 29;
			int Incompleteyearone = 4 + 31 + 30 + 31;

			int life = day * year + Incompleteyeartwo;

			Console.WriteLine(life);

			int[] frames = new int[10];
			frames[0] = 30;
			frames[1] = 17;
			frames[2] = 10;
			frames[3] = 15;
			frames[4] = 26;
			frames[5] = 7;
			frames[6] = 28;
			frames[7] = 20;
			frames[8] = 6;
			frames[9] = 4;


			int game = 0;
			foreach (int frm in frames) {
				game = game + frm;
			}

			Console.WriteLine(game);

			string[] names = {
				"Greg", "Michael", "Dan", "Anna" ,"Marcus",
				"Foster","Jermaine","Mitchell","Jonathan","Larry",
				"William"
			};

			foreach (string aname in names) {
				Console.WriteLine("Hi " + aname);
			}

			string[] myInfo = { "Mitchell Combs", "Cleves, OH", "mitch.combs.92@gmail.com" };

			foreach (string Me in myInfo) {
				Console.WriteLine(Me);
			}

			gamer ken;
			ken.name = "Ken";
			ken.favnbr = 7;

			gamer nick;
			nick.name = "Nick";
			nick.favnbr = 13;

			gamer[] gamers = { ken, nick };

			foreach(gamer gmr in gamers) {
				Console.WriteLine("{0} Fav nbr is {1}", gmr.name, gmr.favnbr);
			}


			//Console.Write("Enter a number from 1 to 10:");
			//string response = Console.ReadLine();
			//Console.WriteLine(response);

			// c# if statement example

			//Console.Write("Enter 100, 200, or 300: ");
			//string ansxxx = Console.ReadLine();
			//int xxx = int.Parse(ansxxx);
			//string color = "red";
			//if(xxx == 100) {
			//	Console.WriteLine("xxx is equal to 100");
			//	if(color == "red") {
			//		Console.WriteLine("color is red");
			//	} else {
			//		if (color == "yellow") {
			//			Console.WriteLine("color is yellow");
			//		} else {
			//			if (color == "green") {
			//				Console.WriteLine("color is green");
			//			} else {
			//				Console.WriteLine("color is something else");
			//			}
			//		}
			//	}
			//} else {
			//	if(xxx == 200) {
			//		Console.WriteLine("x is equal to 200");
			//	} else {
			//		if (xxx == 300) {
			//			Console.WriteLine("xxx is equal to 300");
			//		} else {
			//			Console.WriteLine("xxx is not 100,200, or 300");
			//		}
			//	}
			//}

			//  while loop example, always create a way to eventually make the loop statement false //
			int idx = 0;
			while(idx < 50) {
				if (idx % 2 == 0) {
					Console.WriteLine("The index {0} is even", idx);
				}
				if (idx % 3 == 0) {
					Console.WriteLine("The index {0} is div by 3", idx);
				}
				if (idx % 7 == 0) {
					Console.WriteLine("The index {0} is div by 7", idx);
				}
				idx++;
			}

			
		}
	}
}
