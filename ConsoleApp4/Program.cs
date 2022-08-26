using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObject
{

    public class product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string CompanyName { get; set; }

        public override string ToString()
        {
            return $"{id}->{name}->{price}->{CompanyName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<product> products = new List<product>()
            {
                new product { id = 1, name = "Mouse", price = 799, CompanyName = "Dell" },
                new product { id = 2, name = "Mouse", price = 699, CompanyName = "Lenovo" },
                new product { id = 3, name = "Laptop", price = 34799, CompanyName = "Dell" },
                new product { id = 4, name = "Laptop", price = 45799, CompanyName = "Sony" },
                new product { id = 5, name = "Laptop", price = 73899, CompanyName = "Lenovo" },
                new product { id = 6, name = "Keyboard", price = 599, CompanyName = "Dell" },
                new product { id = 7, name = "Keyboard", price = 999, CompanyName = "Microsoft" },
                new product { id = 8, name = "RAM 4GB", price = 2799, CompanyName = "Intel" },
                new product { id = 9, name = "Speaker", price = 5799, CompanyName = "Sony" },
                new product { id = 10, name = "USB", price = 1299, CompanyName = "Dell" }
            };

            var result = from p in products
                         select p;





            var result1 = from p in products
                          where p.price < 2000
                          select p;
            // OR Lambda expression
            var res = products.Where(p => p.price < 2000).ToList();






            var result2 = from p in products
                          where p.price > 2000 && p.price < 3000
                          select p;
            //OR Lambda expression
            var res2 = products.Where(p => p.price > 2000).OrderBy(x => x.name).ToList();




            var result3 = from p in products
                          where p.CompanyName.StartsWith("D")
                          select p;

            var result4 = from p in products
                          where p.CompanyName.EndsWith("l")
                          select p;
            var result5 =from p in products
                         where p.CompanyName.Contains("e")
                         select p;

            var result6 = from p in products
                          where p.price < 2500
                          orderby p.name descending
                          select p;





            
            // retrive single record
            var res4 = products.Where(x => x.id == 1).SingleOrDefault();





            var res3 = products.Where(x => x.price < 2500).OrderBy(x => x.price).ToList().Take(3);
            var res1 = products.Where(x => x.price < 2500).OrderBy(x => x.price).ToList().Skip(3);






            foreach (product data in result6)
            {
                Console.WriteLine(data);
            }
        }   
    }
}
