using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// CRUD --> Create - Read - Update - Delete

			Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
			Console.WriteLine();
			Console.WriteLine("------------------------------------");

			#region Add Category Operation

			//Console.Write("Eklemek istediğiniz kategori adı: ");
			//string categoryName = Console.ReadLine();

			//SqlConnection connection = new SqlConnection("Data Source=SHINSEKAI\\SQLEXPRESS;initial Catalog=TrainingCampDB;integrated security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("INSERT INTO TblCategory (CategoryName) values (@p1)", connection);
			//command.Parameters.AddWithValue("@p1", categoryName);
			//command.ExecuteNonQuery();
			//connection.Close();

			//Console.Write("Kategori başarıyla eklendi");

			#endregion

			#region Add Product Operation

			//Console.Write("Eklemek istediğiniz ürünün adı: ");
			//string productName = Console.ReadLine();

			//Console.Write("Eklemek istediğiniz ürünün fiyatı: ");
			//decimal productPrice = decimal.Parse(Console.ReadLine());

			////Console.Write("Eklemek istediğiniz ürünün durumu: ");
			////bool productStatus = bool.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=SHINSEKAI\\SQLEXPRESS;initial Catalog=TrainingCampDB;integrated security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("INSERT INTO TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
			//command.Parameters.AddWithValue("@productName", productName);
			//command.Parameters.AddWithValue("@productPrice", productPrice);
			//command.Parameters.AddWithValue("@productStatus", true);
			//command.ExecuteNonQuery();
			//connection.Close();

			//Console.Write("Ürün başarıyla eklendi");

			#endregion

			#region List Product

			//SqlConnection connection = new SqlConnection("Data Source=SHINSEKAI\\SQLEXPRESS;initial Catalog=TrainingCampDB;integrated security=true");

			//connection.Open();
			//SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
			//SqlDataAdapter adapter = new SqlDataAdapter(command);
			//DataTable dataTable = new DataTable();
			//adapter.Fill(dataTable);

			//foreach (DataRow row in dataTable.Rows)
			//{
			//	foreach (var item in row.ItemArray)
			//	{
			//		Console.Write(item.ToString() + " ");
			//	}
			//	Console.WriteLine();
			//}

			//connection.Close();

			#endregion

			#region Delete Product Operation

			//Console.Write("Silmek istediğiniz ürünün ID'si: ");
			//int productId =int.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=SHINSEKAI\\SQLEXPRESS;initial Catalog=TrainingCampDB;integrated security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("DELETE FROM TblProduct WHERE ProductId=@productId", connection);
			//command.Parameters.AddWithValue("@productId", productId);
			//command.ExecuteNonQuery();
			//connection.Close();

			//Console.Write("Ürün başarıyla silindi");

			#endregion

			#region Update Product

			Console.Write("Güncellemek istediğiniz ürünün ID'si: ");
			int productId = int.Parse(Console.ReadLine());

			Console.Write("Güncellenecek ürünün adı: ");
			string productName = Console.ReadLine();

			Console.Write("Güncellenecek ürünün fiyatı: ");
			decimal productPrice = decimal.Parse(Console.ReadLine());

			SqlConnection connection = new SqlConnection("Data Source=SHINSEKAI\\SQLEXPRESS;initial Catalog=TrainingCampDB;integrated security=true");
			connection.Open();

			SqlCommand command = new SqlCommand("UPDATE TblProduct SET ProductName=@productName, ProductPrice=@productPrice WHERE ProductId=@ProductId", connection);
			command.Parameters.AddWithValue("@productName", productName);
			command.Parameters.AddWithValue("@productPrice", productPrice);
			command.Parameters.AddWithValue("@productId", productId);
			command.ExecuteNonQuery();
			connection.Close();

			Console.Write("Ürün başarıyla güncellendi");

			#endregion

			Console.Read();

		}
	}
}
 