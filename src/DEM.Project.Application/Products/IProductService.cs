using Abp.Application.Services;
using DEM.Project.Products.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DEM.Project.Products.Interface
{
    public interface IProductService : IApplicationService
    {
        Task<IEnumerable<ProductDto>> GetAll();
        Task<ProductDto> GetbyId(int id);
    }
}
