using System.ComponentModel.DataAnnotations;

namespace OnlineShopingApplication.Models
{
    public class Product
    {
        public Product(int id, int quantity, string title, int price) 
        {
                this.Id = id;
                this.Quantity = quantity;
                this.Title = title;
                this.Price = price;
               
        }
        public int Id{ get; set; }
        [Required]
        public int Quantity{ get; set; }
        public string Title { get; set; }
        [Required]
        public int Price { get; set; }


        public Product() 
        {
                this.Id = 1;
                this.Quantity = 100;
                this.Title = "";
                this.Price = 100;
               
        }

        

        
              
    }
}