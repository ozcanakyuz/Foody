using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinnesLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TProductListWithCategory();
        List<Product> TProductListWithCategoryAndLast12Items();
        List<Product> TGetFoodsByCategory(int categoryId); //!
    }
}
