using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Basic Array Examples

			// VariableType[] variableName = new VariableType[Quantity];

			//string[] colors = new string[4];
			//colors[0] = "Red";
			//colors[1] = "Yellow";
			//colors[2] = "White";
			//colors[3] = "Blue";

			//Console.WriteLine(colors[2]);

			//string[] cities = new string[5];

			//cities[0] = "Milan";
			//cities[1] = "Budapest";
			//cities[2] = "Lyon";
			//cities[3] = "Cairo";
			//cities[4] = "Tokyo";

			//Console.WriteLine(cities[5]);

			//int[] numbers = new int[10];

			//numbers[0] = 50;
			//numbers[1] = 48;
			//numbers[2] = 698;
			//numbers[3] = 24;
			//numbers[7] = 748;

			//Console.WriteLine(numbers[5]);

			//string[] cities = { "Tokyo", "Roma", "Ankara", "Prag", "Atina" };
			//Console.WriteLine(cities[0]);

			#endregion

			#region Listing all elements in the array

			//string[] colors = { "Yellow", "Red", "White", "Blue", "Green", "Orange", "Pink" };

			//for (int i = 0; i < colors.Length; i++)
			//{
			//	Console.WriteLine(colors[i]);
			//}

			//int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	if (numbers[i] % 3 == 0)
			//	{
			//		Console.WriteLine(numbers[i]);
			//	}
			//}

			//char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

			//for (int i = 0; i < symbols.Length; i++)
			//{
			//	Console.WriteLine(symbols[i]);
			//}

			//int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

			//int maxNumber = myArray[0];

			//for (int i = 0; i < myArray.Length; i++)
			//{
			//	if (myArray[i] > maxNumber)
			//	{
			//		maxNumber = myArray[i];
			//	}
			//}

			//Console.WriteLine(maxNumber);

			//string[] persons = { "Hana", "Takashi", "Rui", "Hanazawa", "Kuze", "Tomoki" };
			//Console.WriteLine(persons.Length);

			//int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
			//Array.Sort(numbers);
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.WriteLine(numbers[i]);
			//}

			//int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
			//Array.Reverse(numbers);
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.WriteLine(numbers[i]);
			//}

			#endregion

			#region Array methods

			//string[] customers = { "Ari", "Mai", "Kanzaki", "Hana", "Himawari", "Shikamaru" };
			//int index = Array.IndexOf(customers, "Hana");
			//Console.WriteLine(index);

			//int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
			//Console.WriteLine("Max value of array: " + numbers.Max());
			//Console.WriteLine("Min value of array: " + numbers.Min());

			#endregion

			#region Getting input from the user

			//string[] cities = new string[5];

			//for (int i = 0; i < cities.Length; i++)
			//{
			//	Console.Write($"Please enter the {i + 1}. city: ");
			//	cities[i] = Console.ReadLine();
			//}

			//Console.WriteLine();
			//Console.WriteLine("---------------------------");
			//for (int i = 0;i < cities.Length;i++)
			//{
			//	Console.WriteLine(cities[i]);
			//}
			//Console.WriteLine("---------------------------");

			//int[] numbers = { 10, 20, 30, 40, 50 };
			//int sum = 0;

			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	sum += numbers[i];
			//}
			//Console.WriteLine(sum);

			//int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

			//Console.WriteLine("Even numbers");

			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	if (numbers[i] % 2 == 0)
			//	{
			//		Console.WriteLine(numbers[i]);
			//	}
			//}

			//Console.WriteLine("-----------------");
			//Console.WriteLine("Odd numbers");

			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	if (numbers[i] % 2 == 1)
			//	{
			//		Console.WriteLine(numbers[i]);
			//	}
			//}

			#endregion

			Console.Read();
		}
	}
}
