using SimpleImageGallery.Data.Models;
using System.Collections.Generic;

namespace SimpleImageGallery.Data
{
    public interface IImage
    {
        IEnumerable<GalleryImage> GetAll();
        IEnumerable<GalleryImage> GetWithTag(string tag);
        GalleryImage GetByID(int id);
    }
}
