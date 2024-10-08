﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Creating 10 stars in a column

			//for (int i = 1; i <= 10; i++)
			//{
			//	Console.WriteLine("*");
			//}

			#endregion

			#region Creating 10 stars in a row

			//for (int i = 1; i <= 10; i++)
			//{
			//	Console.Write("*");
			//}

			#endregion

			#region Create 10 stars vertically, with 10 stars in each row

			//for (int i = 1; i <= 10; i++)
			//{
			//	Console.Write("**********");
			//}

			#endregion

			#region Right triangle

			//for (int i = 1; i <= 5; i++)
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			#endregion

			#region Reverse right triangle

			//for (int i = 5; i >= 1; i--)
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			#endregion

			#region Right triangle and Reverse right triangle

			//for (int i = 1; i <= 5; i++)
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}
			//for (int k = 4; k >= 1; k--)
			//{
			//	for (int m = 1; m <= k; m++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			#endregion

			#region Şöbiyet

			//int n = 5;

			//for (int i = 1; i <= n; i++)
			//{
			//	for (int j = n - 1; j > 0; j--)
			//	{
			//		Console.Write(" ");
			//	}
			//	for (int k = 1; k <= 2 * i - 1; k++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			//// bottom section

			//for (int i = n - 1; i >= 1; i--)
			//{
			//	for (int j = n - 1; j > 0; j--)
			//	{
			//		Console.Write(" ");
			//	}
			//	for (int k = 1; k <= 2 * i -1; k++)
			//	{
			//		Console.Write('*');
			//	}
			//	Console.WriteLine();
			//}

			#endregion

			#region Pyramid

			//int n = 5;

			//for (int i = 1; i <= n; i++)
			//{
			//	for (int j = n - i;j > 0; j--)
			//	{
			//		Console.Write(" ");
			//	}
			//	for (int k = 1;k <= 2 * i - 1;k++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			#endregion

			#region Reverse pyramid

			int n = 5;

			for (int i = n; i >= 1; i--)
			{
				for (int j = n - i; j > 0; j--)
				{
					Console.Write(" ");
				}
				for (int k = 1; k <= 2 * i - 1; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			#endregion

			Console.Read();
		}
	}
}
