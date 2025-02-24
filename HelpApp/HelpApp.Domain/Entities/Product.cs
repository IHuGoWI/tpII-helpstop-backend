using System.Collections.Generic;

namespace HelpApp.Domain.Entities
{
    public class Product
    {
        #region Atributos
        public int Id { get; set; }    
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public int CategoryID { get; set; }

        #endregion

        #region Constructors
        public Product(string name, string description, decimal price, int stock, string image)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }

        #endregion
    }
}
