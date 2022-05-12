using GraphQLProject.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GraphQLProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private IProduct _productService;

        public ProductsController(IProduct productService)
        {
            _productService = productService;
        }
            // GET: api/<ProductsController>
            [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _productService.GetAllProductsAsync();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<Product>  GetById(int id)
        {
            return await _productService.GetProductByIdAsync(id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<Product> Post([FromBody] Product product)
        {
           return await _productService.InsertProductAsync(product);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public async Task<Product> Put(long id, [FromBody] Product product)
        {
            return await _productService.UpdateProductAsync(id, product);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProductAsync(id);
        }
    }
}
