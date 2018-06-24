using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SimpleImageGallery.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleImageGallery.Data
{
    public class SimpleImageGalleryDbContext : DbContext
    {
        public SimpleImageGalleryDbContext(DbContextOptions options) : base(options)
        {
           
        }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }
    }
}

