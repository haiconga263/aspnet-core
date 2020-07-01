using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DEM.Project.Products.Dto
{
    [AutoMap(typeof(Product))]
    public class ProductDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}
