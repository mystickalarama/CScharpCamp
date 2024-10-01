using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Double Variables
			//double number;
			//number = 4.85;
			//Console.WriteLine(number);

			//Console.WriteLine("***** Price List *****");
			//Console.WriteLine();

			//double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

			//applePrice = 14.85;
			//orangePrice = 20.95;
			//strawberryPrice = 45;
			//potatoPrice = 9.74;
			//tomatoPrice = 6.88;

			Console.OutputEncoding = Encoding.UTF8;

			//Console.WriteLine("---- Apple Unit Price: " + applePrice + "\u20BA");
			//Console.WriteLine("---- Orange Unit Price: " + orangePrice + "\u20BA");
			//Console.WriteLine("---- Strawberry Unit Price: " + strawberryPrice + "\u20BA");
			//Console.WriteLine("---- Potato Unit Price: " + potatoPrice + "\u20BA");
			//Console.WriteLine("---- Tomato Unit Price: " + tomatoPrice + "\u20BA");

			//Console.WriteLine();
			//Console.WriteLine();

			//double appleKg, orangeKg, strawberryKg, potatoKg, tomatoKg;

			//appleKg = 1.245;
			//orangeKg = 2.650;
			//strawberryKg = 0.750;
			//potatoKg = 4.850;
			//tomatoKg = 3.745;

			//double appleTotalPrice = applePrice * appleKg;
			//double orangeTotalPrice = orangePrice * orangeKg;
			//double strawberryTotalPrice = strawberryPrice * strawberryKg;
			//double potatoTotalPrice = potatoPrice * potatoKg;
			//double tomatoTotalPrice = tomatoPrice * tomatoKg;

			//Console.WriteLine("Product: Apple - " + "Unit Price: " + applePrice + "\u20BA" + " - " + appleKg + "Kg" + " Total Price: " + appleTotalPrice + "\u20BA");
			//Console.WriteLine("Product: Orange - " + "Unit Price: " + orangePrice + "\u20BA" + " - " + orangeKg + "Kg" + " Total Price: " + orangeTotalPrice + "\u20BA");
			//Console.WriteLine("Product: Strawberry - " + "Unit Price: " + strawberryPrice + "\u20BA" + " - " + strawberryKg + "Kg" + " Total Price: " + strawberryTotalPrice + "\u20BA");
			//Console.WriteLine("Product: Potato - " + "Unit Price: " + potatoPrice + "\u20BA" + " - " + potatoKg + "Kg" + " Total Price: " + potatoTotalPrice + "\u20BA");
			//Console.WriteLine("Product: Tomato - " + "Unit Price: " + tomatoPrice + "\u20BA" + " - " + tomatoKg + "Kg" + " Total Price: " + tomatoTotalPrice + "\u20BA");
			//Console.WriteLine();

			//double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + tomatoTotalPrice + potatoTotalPrice + strawberryTotalPrice;

			//Console.WriteLine("Shopping Total Price: " + shoppingTotalPrice + "\u20BA");

			#endregion

			#region Char Variables

			//char symbol;
			//symbol = '\u20BA';
			//Console.WriteLine(symbol);

			#endregion

			#region Inputs from keyboard - String Variables

			//Console.WriteLine("***** CSharp Airlines Passenger Information *****");

			//string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

			//Console.WriteLine("Name: ");
			//passengerName = Console.ReadLine();

			//Console.WriteLine("Surname: ");
			//passengerSurname = Console.ReadLine();

			//Console.WriteLine("District: ");
			//passengerDistrict = Console.ReadLine();

			//Console.WriteLine("City: ");
			//passengerCity = Console.ReadLine();

			//Console.WriteLine("Age: ");
			//passengerAge = Console.ReadLine();

			//Console.WriteLine("ID Number: ");
			//passengerIdentityNumber = Console.ReadLine();

			//Console.WriteLine();

			//Console.WriteLine("----------------------------------");
			//Console.WriteLine("Passenger ID Number: " + passengerIdentityNumber + " - Passenger Name-Surname: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);

			#endregion

			#region Inputs Integer from keyboard and transformations

			//int shoesPrice, computerPrice, chairPrice, tvPrice;
			//shoesPrice = 1000;
			//computerPrice = 20000;
			//chairPrice = 5000;
			//tvPrice = 12000;

			//int shoesCount, computerCount, chairCount, tvCount;

			//Console.WriteLine("How many units of shoes would you like?: ");
			//shoesCount = int.Parse(Console.ReadLine());

			//Console.WriteLine("How many units of computer would you like?: ");
			//computerCount = int.Parse(Console.ReadLine());

			//Console.WriteLine("How many units of chair would you like?: ");
			//chairCount = int.Parse(Console.ReadLine());

			//Console.WriteLine("How many units of TV would you like?: ");
			//tvCount = int.Parse(Console.ReadLine());

			//int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
			//Console.WriteLine();
			//Console.WriteLine("Total Price: " + totalPrice);

			#endregion

			#region Decimal number operations with the keyboard

			//double exam1, exam2, exam3, result;

			//Console.WriteLine("Please enter first exam point: ");
			//exam1 = double.Parse(Console.ReadLine());

			//Console.WriteLine("Please enter second exam point: ");
			//exam2 = double.Parse(Console.ReadLine());

			//Console.WriteLine("Please enter third exam point: ");
			//exam3 = double.Parse(Console.ReadLine());

			//result = (exam1 + exam2 + exam3) / 3;

			//Console.WriteLine();
			//Console.WriteLine("Average exam result: " + result);

			#endregion

			#region Charecter inputs from the keyboard

			//char gender;
			//Console.WriteLine("Please select gender: ");
			//gender = char.Parse(Console.ReadLine());
			
			//Console.WriteLine("Your gender is " + gender);

			#endregion

			Console.Read();
		}
	}
}