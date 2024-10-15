using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEachLoop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Foreach Loop

			// Foreach(1;2;3;4)

			// 1:Variable Type
			// 2:Variable Name
			// 3:In
			// 4:List, Colection, Array

			//string[] cities = { "Kyoto", "Tokyo", "Sapporo", "Osaka", "Fukuoka", "Nagoya" };

			//foreach (string city in cities)
			//{
			//	Console.WriteLine(city);
			//}

			//int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

			//foreach (int number in numbers)
			//{
			//	Console.WriteLine(number);
			//}

			//int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

			//foreach (int number in numbers)
			//{
			//	if (number % 2 == 0)
			//	{
			//		Console.WriteLine(number);
			//	}
			//}

			//int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
			//int total = 0;

			//foreach (int i in numbers)
			//{
			//	total += i;
			//}

			//Console.WriteLine(total);

			//List<int> numbers = new List<int>()
			//{
			//	1,2, 3, 4, 5, 6, 7, 8
			//};

			//foreach (int number in numbers)
			//{
			//	Console.WriteLine(number);
			//}

			//string word = "Konnichiwa";

			//foreach (char c in word)
			//{
			//	Console.WriteLine(c);
			//}

			#endregion

			#region Sample exam system application

			//Console.Write("***** C# Trainin Camp Exam System Application *****");
			//Console.WriteLine();
			//Console.WriteLine();
			//Console.WriteLine();
			//Console.WriteLine();

			//// Getting the number of students in the class from the user
			//Console.WriteLine("------------------------------");
			//Console.Write("How many students are there in your class: ");
			//int studentCount = int.Parse(Console.ReadLine());
			//Console.WriteLine("------------------------------");

			//// Arrays to store student names and their grade averages
			//string[] studentNames = new string[studentCount];
			//double[] studentExamAvg = new double[studentCount];

			//for (int i = 0; i < studentCount; i++)
			//{
			//	Console.Write($"Please enter the name of the {i+1}. student: ");
			//	studentNames[i] = Console.ReadLine();

			//	double totalExamResult = 0;

			//	// Entering 3 exam scores for each student
			//	for (int j = 0; j < 3; j++)
			//	{
			//		Console.Write($"{studentNames[i]}'s {j+1}. exam result: ");
			//		double value = double.Parse(Console.ReadLine());
			//		totalExamResult += value;
			//	}
			//	Console.WriteLine();
			//	studentExamAvg[i] = totalExamResult / 3;
			//}

			//for (int i = 0;i < studentCount; i++)
			//{
			//	Console.WriteLine("-------------------------------------");

			//	Console.WriteLine($"{studentNames[i]}'s average of exam results: {studentExamAvg[i]}");

			//	if (studentExamAvg[i] >= 50)
			//	{
			//		Console.WriteLine($"{studentNames[i]} passed the course");
			//	}
			//	else
			//	{
			//		Console.WriteLine($"{studentNames[i]} failed the course");
			//	}
			//	Console.WriteLine("-------------------------------------");
			//}

			#endregion

			Console.Read();
		}
	}
}
