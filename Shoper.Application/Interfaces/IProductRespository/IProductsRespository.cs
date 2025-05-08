using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoper.Application.Dtos.ProductDtos;
using Shoper.Domain.Entities;

namespace Shoper.Application.Interfaces.IProductRespository
{
    public interface IProductsRespository 
    {
        Task<List<Product>> GetProductByCategory(int categoryId);
        Task<List<Product>> GetProductByPriceFilter(decimal minprice,decimal maxprice);
        Task<List<Product>> GetProductBySearch(string search);
        
    }
}
