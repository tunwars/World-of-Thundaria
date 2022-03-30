using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{

			{

				bool exit = false;
				int roomLocation = 0;

				// Arrays
				//string[] rooms = new string[5] { "WeaponRoom", "SpyRoom", "LookoutRoom", "CatRoom", "DarkRoom" };
				string[] weapons = new string[4] { "BattleAx", "Numbchucks", "Shank", "Sword" };
				string[] potions = new string[2] { "Health", "man" };
				string[] treasure = new string[3] { "Gold", "Silver", "Platinum" };

				// Lists
				List<string> items = new List<string> { "thunder tank", "book of omens", "thunder cycle" };
				List<string> mobs = new List<string> { "burbels", "mumrah", "mutants", "lunataks" };
				//Load file //
				// example from docs.microsoft.com, hot-to/parse-strings-using-split
				//String text = System.IO.File.ReadAllText("d:\\sample.txt");
				String text = System.IO.File.ReadAllText("d:\\rooms.txt");
				//System.Console.WriteLine("File is " + text);
				string[] rooms = text.Split(',');
				System.Console.WriteLine("Has: " + rooms);				//Main menu

				while (exit == false)
				{

					Console.WriteLine($"You are in -{rooms[roomLocation]}");
					Console.WriteLine("1. Display Rooms");
					Console.WriteLine("2. Display Weapons");
					Console.WriteLine("3. Display Potions");
					Console.WriteLine("4. Display Treasures");
					Console.WriteLine("5. Display Items");
					Console.WriteLine("6. Display Mobs");
					Console.WriteLine("7. Exit");
					Console.Write("Enter a choice > ");
					string input = Console.ReadLine();


					switch (input.ToLower())
					{
						case "1":
							foreach (string value in rooms)
							{
								Console.WriteLine(value);
							}
							break;
						case "2":
							foreach (string value in weapons)
							{
								Console.WriteLine(value);
							}
							break;
						case "3":
							foreach (string value in potions)
							{
								Console.WriteLine(value);
							}
							break;
						case "4":
							foreach (string value in treasure)
							{
								Console.WriteLine(value);
							}
							break;
						case "5":
							foreach (string value in items)
							{
								Console.WriteLine(value);
							}
							break;
						case "6":
							foreach (string value in mobs)
							{
								Console.WriteLine(value);
							}
							break;
						case "rooms":
							foreach (string value in rooms)
							{
								Console.WriteLine(value);
							}
							break;
						case "weapons":
							foreach (string value in weapons)
							{
								Console.WriteLine(value);
							}
							break;
						case "potions":
							foreach (string value in potions)
							{
								Console.WriteLine(value);
							}
							break;
						case "treasure":
							foreach (string value in treasure)
							{
								Console.WriteLine(value);
							}
							break;
						case "items":
							foreach (string value in items)
							{
								Console.WriteLine(value);
							}
							break;
						case "mobs":
							foreach (string value in mobs)
							{
								Console.WriteLine(value);
							}
							break;
						case "n":
							//TODO
							break;
						case "s":
							//TODO
							break;
						case "7":
							exit = true;
							break;
						default:
							//TODO
							break;
					}
				}
			}
		}
	}
}
