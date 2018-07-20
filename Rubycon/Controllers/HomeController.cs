using Rubycon.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Rubycon.Controllers
{
    public class HomeController : Controller
    {
        private static HttpClient client = new HttpClient();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public async Task<ActionResult> TrianglePost(Triangle tri)
        {
            string name = tri.Name;
            var task = await GetCoordinatesAsync(name);

            ViewBag.TriangleName = task.Name;
            ViewBag.PointAx = task.PointA.GetValue(0);
            ViewBag.PointAy = task.PointA.GetValue(1);
            ViewBag.PointBx = task.PointB.GetValue(0);
            ViewBag.PointBy = task.PointB.GetValue(1);
            ViewBag.PointCx = task.PointC.GetValue(0);
            ViewBag.PointCy = task.PointC.GetValue(1);

            return View("Index");
        }

        public async Task<Triangle> GetCoordinatesAsync(string name)
        {
            Triangle triangle = null;
            string uriString = string.Format("{0}/{1}", "http://localhost:65185/api/triangle/getcoordinates", name);

            HttpResponseMessage response = await client.GetAsync(uriString);
            if (response.IsSuccessStatusCode)
            {
                triangle = await response.Content.ReadAsAsync<Triangle>();
            }
            else
            {
                triangle.Name = "I am Empty";
            }

            return triangle;
        }
    }
}
