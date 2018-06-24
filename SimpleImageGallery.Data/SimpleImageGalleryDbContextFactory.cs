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
            var builder = new DbContextOptionsBuilder<SimpleImageGalleryDbContext>();
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SimpleImageGallery;Trusted_Connection=True;MultipleActiveResultSets=true",
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(SimpleImageGalleryDbContext).GetTypeInfo().Assembly.GetName().Name));
            return new SimpleImageGalleryDbContext(builder.Options);
        }
    }
}
