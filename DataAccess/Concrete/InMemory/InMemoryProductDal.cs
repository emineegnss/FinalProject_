using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {

            new(){ ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
            new(){ ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
            new(){ ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
            new(){ ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
            new(){ ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1},
            };
           
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            //_productda her p için dolaşılan ürün için yani benim verdiği,  verilen parametre ile eşleşen id bul. Gönderdiğim ürün idsine sahip olan listedeki ürünü bul

            _products.Remove(productToDelete);
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün idsine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;
            
        }
   
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
           return _products;
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
