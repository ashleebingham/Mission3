using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    internal class FoodItem
    {
        // Parameters
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string Expiration { get; set; }

        // Constructor
        public FoodItem(string name, string category, int quantity, string expiration)
        {
            this.Name = name;
            this.Category = category;
            this.Quantity = quantity;
            this.Expiration = expiration;
        }

    }
}
