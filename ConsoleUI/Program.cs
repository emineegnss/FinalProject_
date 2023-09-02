using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CategoryTest();

            // ProductTest();
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " / " + product.CategoryName );
            }
            


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            var item = categoryManager.GetById(3);
            Console.WriteLine(item.CategoryName);
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            Console.WriteLine("**************");
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                //Burada Product Name ile Category Name gelmesini isteyebiliriz (DTO ile gerçekleştirebiliriz)
                //Data Transformation Object
                Console.WriteLine(product.ProductName + " " + product.CategoryId);
            }
        }
    }
}