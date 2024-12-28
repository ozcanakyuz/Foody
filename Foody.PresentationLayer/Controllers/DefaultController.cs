using Foody.BusinnesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IProductService _productService;
        public DefaultController(IProductService productService)
        {
            _productService = productService;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index(int? categoryId)
        {
            if (!categoryId.HasValue)
            {
                // Eğer kategori ID'si null ise, varsayılan olarak 1'i kullanabiliriz.
                categoryId = 1; // varsayılan kategori ID'si
            }

            // ViewBag ile kategori ID'sini aktar
            ViewBag.CategoryId = categoryId;

            // Index view'ini döndürüyoruz
            return View();
        }
    }
}
