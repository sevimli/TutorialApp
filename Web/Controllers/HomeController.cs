using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {

        Photographs pg = new Photographs();

        // GET: Home
        public ActionResult Index()
        {

            var model = new List<Photographs>();

            model.Add(new Photographs { Name = "im1",
                Url = "/Contents/images/image_01.jpg" });
            model.Add(new Photographs { Name = "im2",
                Url = "/Contents/images/image_02.jpg"
            });
            model.Add(new Photographs { Name = "im3",
                Url = "/Contents/images/image_03.jpg"
            });
            model.Add(new Photographs { Name = "im4",
                Url = "/Contents/images/image_04.jpg"
            });
            model.Add(new Photographs { Name = "im5",
                Url = "/Contents/images/image_05.jpg"
            });

            return View(model);
        }
    }
}

  