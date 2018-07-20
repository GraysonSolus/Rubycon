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
        //initialize HTTP client for async API calls
        private static HttpClient client = new HttpClient();


        //load homepage
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        //async method to get triangle coordinates from triangle name
        public async Task<ActionResult> TrianglePostAsync(Triangle tri)
        {
            string name = tri.Name;
            //retrieve triangle object
            var task = await GetCoordinatesAsync(name);

            //save object values to be displayed in view
            ViewBag.TriangleName = task.Name;
            ViewBag.PointAx = task.PointA.GetValue(0);
            ViewBag.PointAy = task.PointA.GetValue(1);
            ViewBag.PointBx = task.PointB.GetValue(0);
            ViewBag.PointBy = task.PointB.GetValue(1);
            ViewBag.PointCx = task.PointC.GetValue(0);
            ViewBag.PointCy = task.PointC.GetValue(1);

            return View("Index");
        }


        //async method to get triangle name from triangle coordinates
        public async Task<ActionResult> NamePostAsync(string pointA, string pointB, string pointC)
        {
            string coordinates = string.Format("{0};{1};{2}", pointA, pointB, pointC);
            ViewBag.TriangleName = await GetTriangleNameAsync(coordinates);

            return View("Index");
        }


        //async method which sends API request with appropriate parameters attached
        public async Task<Triangle> GetCoordinatesAsync(string name)
        {
            Triangle triangle = null;
            //set URI to API + params
            string uriString = string.Format("{0}/{1}", "http://localhost:65185/api/triangle/getcoordinates", name);

            //wait for client to return response
            HttpResponseMessage response = await client.GetAsync(uriString);
            //if successful save object to be returned
            if (response.IsSuccessStatusCode)
            {
                triangle = await response.Content.ReadAsAsync<Triangle>();
            }
            //set generic "something went wrong" value for testing
            else
            {
                triangle.Name = "I am Empty";
            }

            return triangle;
        }


        //async method which sends an API request to Name Calculator API
        public async Task<string> GetTriangleNameAsync(string input)
        {
            string name;
            //set URI string to take API params
            string uriString = string.Format("{0}/{1}", "http://localhost:65185/api/triangle/gettriangle", input);

            //await response
            HttpResponseMessage response = await client.GetAsync(uriString);
            if (response.IsSuccessStatusCode)
            {
                name = await response.Content.ReadAsAsync<string>();
            }
            else
            {
                name = "I didn't work.";
            }

            return name;
        }
    }
}
