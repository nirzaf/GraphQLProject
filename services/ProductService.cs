using GraphQLProject.Models;

namespace GraphQLProject.services;

public class ProductService : IProduct
{
    private static List<Product> _products = new()
    {
        new Product {Id = 1, Name = "Coffee", Price = 100},
        new Product {Id = 2, Name = "Tea", Price = 200},
        new Product {Id = 3, Name = "Milk", Price = 300},
        new Product {Id = 4, Name = "Juice", Price = 400},
        new Product {Id = 5, Name = "Soda", Price = 500},
        new Product {Id = 6, Name = "Water", Price = 600},
        new Product {Id = 7, Name = "Coke", Price = 700},
        new Product {Id = 8, Name = "Fanta", Price = 800},
        new Product {Id = 9, Name = "Sprite", Price = 900},
        new Product {Id = 10, Name = "Pepsi", Price = 1000}
    };


    public async Task<List<Product>> GetAllProductsAsync()
    {
        return _products.ToList();
    }

    public async Task<Product> InsertProductAsync(Product product)
    {
        _products.Add(product);
        return product;
    }

    public async Task<Product> UpdateProductAsync(long id, Product product)
    {

        var p = _products.FirstOrDefault(c => c.Id == id);
        p.Name = product.Name;
        p.Price = product.Price;
        return p;
    }

    public void DeleteProductAsync(long id)
    {
        var p = _products.FirstOrDefault(c => c.Id == id);
        _products.Remove(p);
    }

    public async Task<Product> GetProductByIdAsync(long id)
    {
        return _products.FirstOrDefault(c => c.Id == id)!;
    }
}