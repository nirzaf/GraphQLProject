namespace GraphQLProject.Models;

public interface IProduct
{
    Task<List<Product>> GetAllProductsAsync();
    Task<Product> InsertProductAsync(Product product);
    Task<Product> UpdateProductAsync(long id, Product product);
    void DeleteProductAsync(long id);
    Task<Product> GetProductByIdAsync(long id);

}