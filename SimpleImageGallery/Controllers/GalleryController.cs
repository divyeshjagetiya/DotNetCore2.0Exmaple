using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Data;
using SimpleImageGallery.Data.Models;
using SimpleImageGallery.Models;

namespace SimpleImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IImage _imageService;

        public GalleryController(IImage imageService)
        {
            _imageService = imageService;
        }
        public IActionResult Index()
        {

            #region HardData Demo Commented
            /*
            var hikingImageTags = new List<ImageTag>();
            var cityImageTags = new List<ImageTag>();

            var tag1 = new ImageTag()
            {
                Description = "Adventure",
                Id = 0
            };
            var tag2 = new ImageTag()
            {
                Description = "Urban",
                Id = 1
            };
            var tag3 = new ImageTag()
            {
                Description = "New York",
                Id = 2
            };

            hikingImageTags.Add(tag1);
            cityImageTags.AddRange(new List<ImageTag> { tag2, tag3 });

            var imageList = new List<GalleryImage>()
            {
                new GalleryImage()
                {
                    Title="Hiking Trip",
                    Url = "https://images.pexels.com/photos/596126/pexels-photo-596126.jpeg",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },
                new GalleryImage()
                {
                    Title="On The Trail",
                    Url = "https://images.pexels.com/photos/372098/pexels-photo-372098.jpeg",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },
                new GalleryImage()
                {
                    Title="Downtown",
                    Url = "https://images.pexels.com/photos/373912/pexels-photo-373912.jpeg",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                }
            }; 
            */
            #endregion

            var imageList = _imageService.GetAll();
            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
            };
            return View(model);
        }
    }
}