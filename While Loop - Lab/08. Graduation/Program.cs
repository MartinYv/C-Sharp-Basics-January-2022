﻿using System;

namespace Loops
{
	class Program
	{
		static void Main(string[] args)
		{

			string name = Console.ReadLine();

			int grade = 1; //  the current grade of the student, e.g 1
			double sum = 0;
			int counter = 0; // counts the number of times the student has been excluded

			while (grade <= 12)
			{
				double yearlyGrade = double.Parse(Console.ReadLine()); // the yearly grade of the student, e.g 5.60

				if (yearlyGrade < 4)
				{
					counter++;
					if (counter == 2)
					{
						break;
					}

					continue;
				}

				sum += yearlyGrade;

				grade++;
			}


			double averageGrade = sum / 12;

			if (grade > 12)
			{
				Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
			}
			else
			{
				Console.WriteLine($"{name} has been excluded at {grade} grade");
			}

		}
	}
}