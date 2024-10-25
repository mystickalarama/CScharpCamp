using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Void Methods

			// ()
			// Methods that do not return a value - void

			//void CustomerList()
			//{
			//	Console.WriteLine("Takashi Hanamura");
			//	Console.WriteLine("Satoshi Ryume");
			//	Console.WriteLine("Rie Takahashi");
			//	Console.WriteLine("Yasuke Mamura");
			//}

			//CustomerList();

			//void Sum()
			//{
			//	int x = 1;
			//	int y = 2;
			//	int z = x + y;
			//	Console.WriteLine(z);
			//}

			//Sum();

			#endregion

			#region Methods that do not return a value with string parameter

			//void WriteMethod(string customerName)
			//{
			//	Console.WriteLine(customerName);
			//}

			//WriteMethod("Rie Takahashi");

			//void CustomerCard(string name, string surName)
			//{
			//	Console.WriteLine("Customer: " + name + " " + surName);
			//}

			//CustomerCard("Rie", "Takahashi");
			//CustomerCard("Mai", "Sakaguchi");


			#endregion

			#region Methods that do not return a value with int parameter

			//void Sum(int number1, int number2, int number3)
			//{
			//	int result = number1 + number2 + number3;
			//	Console.WriteLine(result);
			//}

			//Sum(4, 5, 6);

			#endregion

			#region Methods that return a value

			//string CustomerName()
			//{
			//	return "Rei Yasuda";
			//}

			//CustomerName();

			//string StudentCard()
			//{
			//	string name = "Rei";
			//	string surName = "Yasuda";

			//	return name + " " + surName;
			//}

			//Console.WriteLine(StudentCard());

			#endregion

			#region Methods that return a value with string parameter

			//string CountryCard(string countryName, string capital, string flagColor)
			//{
			//	string cardInfo = "Country: " + countryName + " - Capital: " + capital + " - Flag Color:  " + flagColor;

			//	return cardInfo;
			//}

			//string x, y, z;
			//Console.Write("Please enter the country name: ");
			//x = Console.ReadLine();

			//Console.Write("Please enter the capital name: ");
			//y = Console.ReadLine();

			//Console.Write("What is flag color: ");
			//z = Console.ReadLine();

			//Console.WriteLine(CountryCard(x, y, z));

			#endregion

			#region Methods that return a value with int parameter

			//int Sum(int number1, int number2)
			//{
			//	int result = number1 + number2;

			//	return result;
			//}

			//Console.WriteLine(Sum(32, 46));
			//Console.WriteLine(Sum(62, 76));
			//Console.WriteLine(Sum(16, 34));
			//Console.WriteLine(Sum(98, 1));

			#endregion

			#region Example

			string ExamResult(string student, int exam1, int exam2, int exam3)
			{
				int result = (exam1 + exam2 + exam3) / 3;

				if (result >= 50)
				{
					return "Student " + student + " passed the exam with a score of " + result;
				}
				else
				{
					return "Student " + student + " failed the exam with a score of " + result;
				}
			}

			Console.WriteLine(ExamResult("Takahashi", 45, 66, 79));
			Console.WriteLine(ExamResult("Elenour", 12, 46, 69));

			#endregion

			Console.Read();
		}
	}
}
