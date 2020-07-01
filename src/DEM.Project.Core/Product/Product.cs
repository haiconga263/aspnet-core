using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEM.Project.Products
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}
