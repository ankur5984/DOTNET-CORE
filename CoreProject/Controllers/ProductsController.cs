using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using OnlineShopingApplication.Models;


namespace OnlineShopingApplication.Controllers
{
    public class ProductsController:Controller
    {
        public IActionResult Index()
        {
            List<Product> product = new List<Product>();
            product.Add(new Product(15, 100,"Reebok", 1500));
            product.Add(new Product(16, 101,"Addidas", 2500));
            product.Add(new Product(17, 102,"Lyke", 3500));
            this.ViewBag.products = product;
            return View();

        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            List<Product> product = new List<Product>();
            product.Add(new Product(15, 100,"Reebok", 1500));
            product.Add(new Product(16, 101,"Addidas", 2500));
            product.Add(new Product(17, 102,"Lyke", 3500));

            foreach (Product prod in product)
            {
                if (prod.Id == id){
                    this.ViewBag.products = prod;
                    break;
                }
                
            }
            
            return View();
        }

        [HttpGet]
        public IActionResult Update(){
            return View();
        }
        
        
        [HttpPost]
        public IActionResult Update(int id,int quant,int price){
           List<Product> products = new List<Product>();
            products.Add(new Product(15, 100,"Reebok", 1500));
            products.Add(new Product(16, 101,"Addidas", 2500));
            products.Add(new Product(17, 102,"Lyke", 3500));

            Product p = products.Find(product=>(product.Id == id));
            p.Quantity = quant;
            p.Price = price;
            if (p != null){
                if (ModelState.IsValid)
                {
                    return RedirectToAction("index","products");
                }

               
            }
            return View();         
        }

        public IActionResult Delete(int id){
            List<Product> products = new List<Product>();
            products.Add(new Product(15, 100,"Reebok", 1500));
            products.Add(new Product(16, 101,"Addidas", 2500));
            products.Add(new Product(17, 102,"Lyke", 3500));
            Product p = products.Find(product=>(product.Id == id));
            if (p != null){
                products.Remove(p);
                ////return RedirectToAction("index","products");
                
            }
            return View(products);

        }
    }
}