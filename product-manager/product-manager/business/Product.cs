using System;
namespace product_manager.business
{
    public class Product
    {
        public String code { get; set; }
        public String description { get; set; }
        public String price { get; set; }

        public Product()
        {

        }

        public Product(string code, string description, string price)
        {
            this.code = code;
            this.description = description;
            this.price = price;
        }

        public override string ToString()
        {
            return "Product:  " + code + "," + description + "," + price;
            
        }
    }
    
}

