using Mango.Services.ProductAPI.Models.Dto;
using Mango.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.ProductAPI.Controllers
{
	[Route("api/products")]
	public class ProductAPIController : ControllerBase
	{
		protected ResponseDto _response;
		private IProductRepository _productRepository;

        public ProductAPIController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
			this._response = new ResponseDto();
        }

        public IActionResult Index()
		{
			return View();
		}
	}
}
