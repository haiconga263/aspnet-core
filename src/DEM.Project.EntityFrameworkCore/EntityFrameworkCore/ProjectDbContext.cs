using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DEM.Project.Authorization.Roles;
using DEM.Project.Authorization.Users;
using DEM.Project.MultiTenancy;
using DEM.Project.Products;

namespace DEM.Project.EntityFrameworkCore
{
    public class ProjectDbContext : AbpZeroDbContext<Tenant, Role, User, ProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Product> Product { get; set; }
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
            : base(options)
        {        
        }
    }
}
