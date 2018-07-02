using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SimpleImageGallery.Data
{
    public class SimpleImageGalleryDbContextFactory : IDesignTimeDbContextFactory<SimpleImageGalleryDbContext>
    {
        public SimpleImageGalleryDbContext CreateDbContext(string[] args)
        {
            string localConnectionString = "Server=(localdb)\\mssqllocaldb;Database=SimpleImageGallery;Trusted_Connection=True;MultipleActiveResultSets=true";
            string connectionString = "Server=tcp:simpleimagegallery.database.windows.net,1433;Initial Catalog=SimpleImageGallery;Persist Security Info=False;User ID=divyeshjagetiya;Password=Xebia@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            var builder = new DbContextOptionsBuilder<SimpleImageGalleryDbContext>();
            builder.UseSqlServer(connectionString,
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(SimpleImageGalleryDbContext).GetTypeInfo().Assembly.GetName().Name));
            return new SimpleImageGalleryDbContext(builder.Options);
        }
    }
}
