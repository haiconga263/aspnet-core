using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using DEM.Project.Products.Dto;
using DEM.Project.Products.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEM.Project.Products.Service
{
    public class ProductService : ApplicationService, IProductService
    {
        public readonly IRepository<Product> _productRepository;
        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        [AbpAuthorize("Administration")]
        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            var rs = await _productRepository.GetAllListAsync();
            return new List<ProductDto>(ObjectMapper.Map<List<ProductDto>>(rs));
        }

        public async Task<ProductDto> GetbyId(int id)
        {
            var rs = await _productRepository.GetAsync(id);
            return ObjectMapper.Map<ProductDto>(rs);
        }
    }
}
