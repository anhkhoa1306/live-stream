using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LiveStreamSample.Models;

namespace LiveStreamSample.Controllers
{
    public class PropertiesController : Controller
    {
        public static List<PropertyViewModel> properties = new List<PropertyViewModel>
        {
            new PropertyViewModel
            {
                Id = 1,
                Name = "Emirates",
                Owner = "Kyle",
                Price = 1000,
                UrlImage = $"/Images/1.jpg",
                LiveStreamIcon = "/Images/lt.gif"
            },
            new PropertyViewModel
            {
                Id = 2,
                Name = "Stamford Bridge",
                Owner = "Kyle",
                Price = 900,
                UrlImage = $"/Images/2.jpg",
                LiveStreamIcon = "/Images/lt.gif"
            },new PropertyViewModel
            {
                Id = 3,
                Name = "Anfield",
                Owner = "Kyle",
                Price = 1000,
                UrlImage = $"/Images/3.jpg",
                LiveStreamIcon = "/Images/lt.gif"
            },
            new PropertyViewModel
            {
                Id = 4,
                Name = "Old Trafford",
                Owner = "Kyle",
                Price = 800,
                UrlImage = $"/Images/4.jpg",
                LiveStreamIcon = "/Images/lt.gif"
            },
            new PropertyViewModel
            {
                Id = 5,
                Name = "Camp Nou",
                Owner = "Kyle",
                Price = 1000,
                UrlImage = $"/Images/5.jfif",
                LiveStreamIcon = "/Images/lt.gif"
            }
        };
       
        public PropertiesController()
        {
        }

        // GET: Properties
        public IActionResult Index()
        {
            return View(properties);
        }

        // GET: Properties/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = properties.FirstOrDefault
                (m => m.Id == id);
            return @property == null ? NotFound() : (IActionResult)View(@property);
        }

        [HttpPost]
        public JsonResult Edit(PropertyEditDto data)
        {
            var property = properties.FirstOrDefault(p => p.Id == data.Id);
            property.LiveUrl = data.LiveStreamUrl;
            return Json("'Success':'true'");
        }
    }
}
