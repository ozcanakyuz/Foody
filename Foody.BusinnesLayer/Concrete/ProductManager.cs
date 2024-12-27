using Foody.BusinnesLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinnesLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> TProductListWithCategoryAndLast12Items()
        {
            return _productDal.ProductListWithCategoryAndLast12Items();
        }

        public void TDelete(int id)
        {
            _productDal.Delete(id);
        }
        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }
        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }
        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public List<Product> TProductListWithCategory()
        {
            return _productDal.ProductListWithCategory();
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }

        // !
        //public List<Product> TGetProductsByCategory(int categoryId)
        //{
        //    return _productDal.GetProductsByCategory(categoryId);
        //}
        // !
    }
}
