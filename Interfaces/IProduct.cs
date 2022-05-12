namespace GraphQLProject.Models;

public interface IProduct
{
    Task<List<Product>> GetAllProductsAsync();
    Task InsertProductAsync(Product product);
    Task UpdateProductAsync(long id, Product product);
    Task DeleteProductAsync(long id);
    Task<Product> GetProductByIdAsync(long id);

}