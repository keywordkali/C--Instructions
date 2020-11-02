using System;
using System.Collections.Generic;
using product_manager;

namespace wizard_inventory
{

	class Program
	{
		private static List<string> items = new List<string>();
		static void Main(string[] args)
		{

			Console.WriteLine("Welcome to the Wizard Inventory App!");


			initializeItems1();

			String command = "";
			while (!command.Equals("Exit"))
			{
				displayMenu();
				command = MyConsole.getString("Command: ");
				switch (command)
				{
					case "Show":
						// show item
						for (int i = 0; i < items.Count; i++)
						{
							Console.WriteLine(i + 1 + ". " + items[i]);
						}
                        Console.WriteLine();
						break;

					case "Grab":
						// grab item / add item, but max of 4
						if (items.Count >= 4)
						{
							Console.WriteLine("You can't carry anymore items. Please drop one first");
						}
						else
						{
							String name = MyConsole.getString("Name: ");
							items.Add(name);
							Console.WriteLine(name + "was added.");

						}
						break;

					case "Edit":
						// edit item - prompt for item # ( not the index!)

						String item = findItem();
						int idx = items.IndexOf(item);
						String newName = MyConsole.getLine("Updated name: ");
						items[idx] = newName;
						Console.WriteLine("Item #" + (idx + 1) + "was updated.");

						break;

					case "Drop":
						// drop item
						int itemNumber = MyConsole.GetInt("Number:", 1, items.Count);
						item = items[itemNumber - 1];
						items.Remove(item);
						Console.WriteLine(item + "was removed.");

						break;

					case "Exit":
						// exit
						break;

				}

			}
			Console.WriteLine("Bye!");

		}

		private static void initializeItems1()
		{
			items.Add("wooden staff");
			items.Add("wizard hat");
			items.Add("cloth shoes");

		}

		private static void displayMenu()
		{
			String menu = "Command Menu:" + "Show- all items\n" + "Grab- (add) an item\n" + "Edit- an item\n"
					+ "Drop- an item\n" + "Exit - Exit app\n";

			Console.WriteLine(menu);
        }
		
		
			private static String findItem()
			{

				int itemNumber = MyConsole.GetInt("Number: ", 1, items.Count);
				String item = items[itemNumber - 1];
				return item;
			}

			private static String findItem1()
			{
			int itemNbr = GetIntWithinRange("Number: ", 1, items.Count);
			String item = items[itemNbr - 1];
			return item;
		}

        private static int GetIntWithinRange(string v1, int v2, int count)
        {
            throw new NotImplementedException();
        }

        public static String GetRequiredString(String prompt)
		{
			String str = "";
			Boolean isValid = false;
			while (!isValid)
			{
				Console.WriteLine(prompt);
				str = Console.ReadLine();
				if (str.Equals(""))
				{
					Console.WriteLine("Invalid Entry.. this field is required!");
				}
				else
				{
					isValid = true;
				}
			}

			return str;
		}
		public static int GetInt(String prompt)
		{
			int nbr = 0;
			while (true)
			{
				try
				{
					Console.WriteLine(prompt);
					nbr = int.Parse(Console.ReadLine());
					break;
				}
				catch (Exception)
				{
					Console.WriteLine("Error!  Invalid integer.  Try again.\n");
					Console.ReadLine();
					continue;
				}
			}
			return nbr;
		}
		
	}
	}

	

