﻿using System;

namespace _11._Fruit_Shop
{
	class Program
	{
		static void Main(string[] args)
		{
			//плод, ден, количество

			string fruit = Console.ReadLine();
			string day = Console.ReadLine();
			double quantity = double.Parse(Console.ReadLine());

			/// плод banana apple orange grapefruit kiwi pineapple grapes
			/// цена 2.50   1.20  0.85     1.45    2.70    5.50     3.85
			double price = 0;

			switch (day)
			{
				case "Monday":
				case "Tuesday":
				case "Wednesday":
				case "Thursday":
				case "Friday":

					switch (fruit)
					{
						case "banana":
							price = 2.50;
							break;
						case "apple":
							price = 1.20;
							break;
						case "orange":
							price = 0.85;
							break;
						case "grapefruit":
							price = 1.45;
							break;
						case "kiwi":
							price = 2.70;
							break;
						case "pineapple":
							price = 5.50;
							break;
						case "grapes":
							price = 3.85;
							break;
						default:
							Console.WriteLine("error");
							break;
					}
					break;

				case "Saturday":
				case "Sunday":
					switch (fruit)
					{
						case "banana":
							price = 2.70;
							break;
						case "apple":
							price = 1.25;
							break;
						case "orange":
							price = 0.90;
							break;
						case "grapefruit":
							price = 1.60;
							break;
						case "kiwi":
							price = 3;
							break;
						case "pineapple":
							price = 5.60;
							break;
						case "grapes":
							price = 4.20;
							break;
						default:
							Console.WriteLine("error");
							break;
					}
					break;
			}
			double total = price * quantity;
			if (total != 0)
			{
				Console.WriteLine($"{total:f2}");
			}
		}
	}
}


