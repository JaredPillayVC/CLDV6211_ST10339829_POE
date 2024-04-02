using CLDV6211_ST10339829_POE.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLDV6211_ST10339829_POE.Controllers
{
    public class KhumaloCraft : Controller
    {
        public IActionResult Index()
        {
            var myWork = MyWork();
            return View(myWork);
        }

        public IActionResult AboutUs()
        {
            ViewBag.Message = "About Us";
            return View();
        }

        public IActionResult ContactUs()
        {
            ViewBag.Message = "Contact Us";
            return View();
        }

        public IActionResult MyWork()
        {
            // Static list of work 
            var khumaloCraft = new List<KhumaloCraftModel>
        {
            new KhumaloCraftModel { Id = 1, Name = "Handcrafted Oak Floor Lamp", Description = "Elevate your space with this minimalist-designed, handcrafted floor lamp. Made from 100% FSC-certified solid oak, this piece not only illuminates your bedroom, nursery, or living room but also serves as a timeless art piece, adding warmth and elegance to any interior", Price = 600, ImageUrl = "/images/1.jpg" },
            new KhumaloCraftModel { Id = 2, Name = "Elegant Oak Ambient Lamp", Description = "Experience the beauty of simplicity with our handcrafted oak ambient lamp. Its minimalist design and solid oak construction bring a natural, refined touch to any setting. Perfect for those who appreciate the subtle interplay of light and craftsmanship.", Price = 850, ImageUrl = "/images/2.jpg" },
            new KhumaloCraftModel { Id = 3, Name = "Illuminated Mountain Range Wooden Wall Art", Description = "Bring the serene majesty of mountain peaks into your home with this handcrafted wooden wall frame. Artisanally created with precision, each panel captures the essence of a rugged mountain scape, backlit to enhance the natural grain of the wood and cast a soothing ambient glow. Perfect for nature lovers, this piece transforms any room into a tranquil retreat.", Price = 650, ImageUrl = "/images/3.jpg" },
            new KhumaloCraftModel { Id = 4, Name = "Handmade Oak Floor Lamp", Description = "This handcrafted floor lamp, with its minimalist aesthetic, is designed to complement any living space. Made from solid oak, it emphasizes natural beauty and expert craftsmanship, making it an ideal addition for those who value elegance and simplicity.", Price = 550, ImageUrl = "/images/4.jpg" }

        };

            return View(khumaloCraft);
        }
    }
}
