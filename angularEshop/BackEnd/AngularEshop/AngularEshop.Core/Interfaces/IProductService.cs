using System;
using System.Threading.Tasks;
using AngularEshop.DataLayer.Entities.Product;

namespace AngularEshop.Core.Interfaces
{
    public interface IProductService:IDisposable
    {
        #region Product

        Task AddProduct(Product product);
        Task UpdateProduct(Product product);

        #endregion
    }
}