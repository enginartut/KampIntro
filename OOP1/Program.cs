using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitPrice = 3;

            Product product2 = new Product() { Id = 5, CategoryId = 5, 
                ProductName = "Kalem", UnitsInStock = 4, UnitPrice=400 };

            //Pascal Case   //Camel Case   
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

           
            //int,double,string,bool değer tip
            //class, diziler, abstract class, interface ... referans  tip
            //ref out bak

        }
    }
}
