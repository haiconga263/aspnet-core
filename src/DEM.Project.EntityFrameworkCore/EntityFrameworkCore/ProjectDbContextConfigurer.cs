using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DEM.Project.EntityFrameworkCore
{
    public static class ProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProjectDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProjectDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
