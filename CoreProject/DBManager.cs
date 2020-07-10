using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MySql.Data.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using IDAL;
using BOL;
namespace DAL
{
    public class DBManager:DBSpecification
    {
        public  void DisplayRecord()
        {
             using (var context = new LibraryContext())
            {
               //var products = context.Products.FromSqlRaw("SELECT * FROM products").ToList(); 
               //var products = context.Products;
               var products = from prod in context.Products
                                select prod;
               foreach (var product in products)
               {
                   Console.WriteLine(" Id: {0}, Title: {1}, UnitPrice: {2}, Quantity: {3}",product.Id,product.Title,product.UnitPrice,product.Quantity);
                 
               }
            }
        }
        public void InsertRecord()
        {
            using(var context = new LibraryContext())
            {
                var product = new Product(){
                            Id = 8,
                            Title = "HP",
                            UnitPrice = 15000,
                            Quantity = 2000
                };
                context.Products.Add(product);
                context.SaveChanges();
                Console.WriteLine("Row Added Successfully");

            }

        }

         public void UpdateRecord()
         {
             Console.WriteLine("enter product id");
            var id = int.Parse(Console.ReadLine());
            using(var context = new LibraryContext())
            {
                var product = context.Products.Find(id);
                Console.WriteLine("enter title");
                product.Title = Console.ReadLine();

                context.SaveChanges();
                Console.WriteLine("updated successfully");
            }
         }
         public void DeleteRecord()
         {
            Console.WriteLine(" enter id ");
            int id = int.Parse(Console.ReadLine());
            using(var context = new LibraryContext())
            {
                
                context.Products.Remove(context.Products.Find(id));
                context.SaveChanges();
            }
         }

    }
}
