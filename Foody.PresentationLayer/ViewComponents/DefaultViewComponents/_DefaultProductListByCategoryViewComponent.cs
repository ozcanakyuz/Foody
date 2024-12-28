using Foody.BusinnesLayer.Abstract;
using Foody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultProductListByCategorySectionComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _DefaultProductListByCategorySectionComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke(int categoryId)
        {
            if (categoryId == 0)
            {
                // Eğer categoryId geçersizse veya null ise, hata verebiliriz.
                return View(new List<Product>());
            }

            var products = _productService.TGetFoodsByCategory(categoryId);
            return View(products);
        }

    }
}
