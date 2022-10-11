using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPI.Models
{
    public class BucketModel
    {
        public List<Product> Products { get; set; }
        public List<Categorie> Categories { get; set; }

        public void ShowProducts()
        {
            foreach(Product products in Products)
            {
                Console.WriteLine(products);
            }

        }
        public void ShowCategories()
        {
            foreach (Categorie categories in Categories)
            {
                Console.WriteLine(categories);
            }

        }

    }
}
