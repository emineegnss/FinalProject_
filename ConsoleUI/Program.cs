using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CategoryTest();
            //ProductTest();
            //TestDto();
           
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
               
            
        }

        private static void TestDto()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName + " / " + product.CategoryName);
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
            foreach (var product in productManager.GetAll().Data)
            {
                //Burada Product Name ile Category Name gelmesini isteyebiliriz (DTO ile gerçekleştirebiliriz)
                //Data Transformation Object
                Console.WriteLine(product.ProductName + " " + product.CategoryId);
            }
        }
    }
}