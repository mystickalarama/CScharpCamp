using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region If Else

			//Console.Write("Please enter password: ");
			//string password;
			//password = Console.ReadLine();

			//if (password == "redline")
			//{
			//	Console.WriteLine("Correct");
			//}
			//else
			//{
			//	Console.WriteLine("Wrong password");
			//}

			//string capital, country;
			//Console.Write("Enter the capital: ");
			//capital = Console.ReadLine();

			//Console.Write("Enter the country: ");
			//country = Console.ReadLine();

			//if (capital == "Tokyo" & country == "Japan")
			//{
			//	Console.WriteLine("Correct");
			//}

			//		 else
			//{
			//	Console.WriteLine("Wrong");
			//}

			//int number;
			//Console.Write("Enter the number: ");
			//number = int.Parse(Console.ReadLine());
			//if (number == 5)
			//{
			//	Console.WriteLine("Correct");
			//}

			//else
			//{
			//	Console.WriteLine("Wrong");
			//}

			//int exam1, exam2, exam3, average;
			//string result = "Error";

			//Console.Write("Exam 1: ");
			//exam1 = int.Parse(Console.ReadLine());
			//Console.Write("Exam 2: ");
			//exam2 = int.Parse(Console.ReadLine());
			//Console.Write("Exam 3: ");
			//exam3 = int.Parse(Console.ReadLine());

			//average = (exam1 + exam2 + exam3) / 3;
			//Console.WriteLine("Average of exams: " + average);

			//if (average >= 0 & average < 50)
			//{
			//	result = "Bad";
			//}
			//if (average >= 50 & average < 70)
			//{
			//	result = "Normal";
			//}
			//if (average >= 70 & average < 85)
			//{
			//	result = "Good";
			//}
			//if (average >= 85)
			//{
			//	result = "Exellent";
			//}

			//Console.Write("Result: " + result);

			//string city;
			//Console.Write("Please enter a city: ");
			//city = Console.ReadLine();

			//if (city == "Kyoto" | city=="Hokkaido" | city=="Tokyo" | city=="Fukushima")
			//{
			//	Console.WriteLine("City avaible");
			//}
			//         else
			//         {
			//	Console.WriteLine("City not avaible");
			//         }

			//Console.Write("Please enter username: ");
			//string username = Console.ReadLine();

			//if (username != "admin")
			//{
			//	Console.WriteLine("Wrong username");
			//}
			//else
			//{
			//	Console.WriteLine("Konnichiha");
			//}

			#endregion

			#region Mod Operations

			//int number;
			//number = 32;
			//int result = number % 5;
			//Console.WriteLine(result);

			//Console.Write("Please enter first number: ");
			//int number1 = int.Parse(Console.ReadLine());

			//Console.Write("Please enter second number: ");
			//int number2 = int.Parse(Console.ReadLine());

			//int result = number1 % number2;
			//Console.Write("Mod of first number: " + result);

			//Console.Write("Please enter number: ");
			//int number = int.Parse(Console.ReadLine());

			//if (number % 2 == 0)
			//{
			//	Console.WriteLine("This number is even");
			//}
			//else
			//{
			//	Console.WriteLine("This number is odd");
			//}

			//Console.Write("Please enter your team's first letter: ");
			//char team = char.Parse(Console.ReadLine());

			//if (team == 'g' | team == 'G')
			//{
			//	Console.WriteLine("Galatasaray");
			//}
			//if (team == 'f' | team == 'F')
			//{
			//	Console.WriteLine("Fenerbahçe");
			//}
			//if (team == 'b' | team == 'B')
			//{
			//	Console.WriteLine("Beşiktaş");
			//}

			#endregion

			#region Decision structures with char variables

			//Console.WriteLine("***** C# Training Camp Restaurant *****");
			//Console.WriteLine();
			//Console.WriteLine("-------------------");
			//Console.WriteLine("1-Main Dishes");
			//Console.WriteLine("2-Soups");
			//Console.WriteLine("3-Pizzas");
			//Console.WriteLine("4-Beverages");
			//Console.WriteLine("5-Desserts");
			//Console.WriteLine("-------------------");

			//string menuItem;

			//Console.WriteLine("Please select category: ");
			//menuItem = Console.ReadLine();

			//if (menuItem == "1")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("---------- Main Dishes ----------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Chicken with curry sauce");
			//	Console.WriteLine("2-Fries Platter");
			//	Console.WriteLine("3-Bean rice");
			//	Console.WriteLine("4-Baked loaf");
			//	Console.WriteLine("5-Eggplant moussaka");
			//	Console.WriteLine();
			//	Console.WriteLine("---------- Main Dishes ----------");
			//}
			//if (menuItem == "2")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("---------- Soups ----------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Lentil soup");
			//	Console.WriteLine("2-Ezogelin soup");
			//	Console.WriteLine("3-Chicken soup");
			//	Console.WriteLine();
			//	Console.WriteLine("---------- Soups ----------");
			//}
			//if (menuItem == "3")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("---------- Pizzas ----------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Mediterranean");
			//	Console.WriteLine("2-Margarita");
			//	Console.WriteLine("3-Chicken");
			//	Console.WriteLine();
			//	Console.WriteLine("---------- Pizzas ----------");
			//}
			//if (menuItem == "4")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("---------- Beverages ----------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Water");
			//	Console.WriteLine("2-Coke");
			//	Console.WriteLine("3-Ayran");
			//	Console.WriteLine();
			//	Console.WriteLine("---------- Beverages ----------");
			//}
			//if (menuItem == "5")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("---------- Desserts ----------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Trileche");
			//	Console.WriteLine("2-Caramelized milk pudding");
			//	Console.WriteLine("3-Rice pudding");
			//	Console.WriteLine();
			//	Console.WriteLine("---------- Desserts ----------");
			//}

			#endregion

			#region Switch Case

			//Console.WriteLine("Please enter a mounth");
			//int mountNumber = int.Parse(Console.ReadLine());

			//switch (mountNumber)
			//{
			//	case 1: Console.WriteLine("January"); break;
			//	case 2: Console.WriteLine("February"); break;
			//	case 3: Console.WriteLine("March"); break;
			//	case 4: Console.WriteLine("April"); break;
			//	case 5: Console.WriteLine("May"); break;
			//	case 6: Console.WriteLine("June"); break;
			//	case 7: Console.WriteLine("July"); break;
			//	case 8: Console.WriteLine("August"); break;
			//	case 9: Console.WriteLine("September"); break;
			//	case 10: Console.WriteLine("October"); break;
			//	case 11: Console.WriteLine("November"); break;
			//	case 12: Console.WriteLine("December"); break;
			//	default: Console.WriteLine("Error"); break;
			//}

			#endregion

			#region Switch Case Calculator

			int number1, number2, result;
			char symbol;

			Console.WriteLine("Please enter first number: ");
			number1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Please enter second number: ");
			number2 = int.Parse(Console.ReadLine());

			Console.WriteLine("Select an operation");
			symbol = char.Parse(Console.ReadLine());

			switch (symbol)
			{
				case '+':
					result = number1 + number2;
					Console.WriteLine("Addition: " + result);
					break;

				case '-':
					result = number1 - number2;
					Console.WriteLine("Subtraction: " + result);
					break;
				case '*':
					result = number1 * number2;
					Console.WriteLine("Multiplication: " + result);
					break;
				case '/':
					result = number1 / number2;
					Console.WriteLine("Division: " + result);
					break;
					default: Console.WriteLine("This operation not supported"); break;
			}

			#endregion

			Console.Read();
		}
	}
}
