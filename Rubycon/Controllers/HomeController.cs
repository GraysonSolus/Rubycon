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

        [HttpGet]
        private async void TrianglePost(Triangle tri)
        {
            string name = tri.Name;
            var task = await GetCoordinatesAsync(name);

            ViewBag.TriangleName = task.Name;
            ViewBag.PointA = task.PointA;
            ViewBag.PointB = task.PointB;
            ViewBag.PointC = task.PointC;
        }

        async Task<Triangle> GetCoordinatesAsync(string name)
        {
            Triangle triangle = null;

            HttpResponseMessage response = await client.GetAsync("http://localhost:65185/api/triangle/getcoordinates/{name}");
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
