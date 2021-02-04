using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle(Yeni bir özellik ekliyorsan hiçbir kod degiştirmene gerek kalmaz,konfigürasyonu degiştirdik.)
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(10,20))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
