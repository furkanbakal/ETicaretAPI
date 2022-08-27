using ETicaretServer.Application.Repositories;
using ETicaretServer.Domain.Entities;
using ETicaretServer.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretServer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;

        public ProductController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() {Id = Guid.NewGuid(), Name = "Product1", Price = 108, CreatedDate = DateTime.UtcNow, Stock = 10},
            //     new() {Id = Guid.NewGuid(), Name = "Product2", Price = 54, CreatedDate = DateTime.UtcNow, Stock = 20},
            //      new() {Id = Guid.NewGuid(), Name = "Product3", Price = 340, CreatedDate = DateTime.UtcNow, Stock = 24}
            //});
            Product p = await _productReadRepository.GetByIdAsync("6e25ca65-46e9-4bd1-8218-d8c6b60d386b", false);
            p.Name = "Tracking test 2";
            await _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}
