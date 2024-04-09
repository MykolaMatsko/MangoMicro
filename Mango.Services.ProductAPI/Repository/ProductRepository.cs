using AutoMapper;
using Mango.Services.ProductAPI.DbContexts;
using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repository
{
	public class ProductRepository : IProductRepository
	{

		private readonly ApplicationDbContext _db;
		private IMapper _mapper;

        public ProductRepository(ApplicationDbContext db, Mapper mapper)
        {
            _db = db;
			_mapper = mapper;	
        }

        public Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
		{
			throw new NotImplementedException();
		}

		public Task<bool> DeleteProduct(int productId)
		{
			throw new NotImplementedException();
		}

		public Task<ProductDto> GetProductById(int productId)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<ProductDto>> GetProducts()
		{
			
		}
	}
}
