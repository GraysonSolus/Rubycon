using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rubycon.Models
{
    public class Triangle
    {
        [Range(2, 3)]
        public string Name { get; set; }
        public int[] PointA { get; set; }
        public int[] PointB { get; set; }
        public int[] PointC { get; set; }
    }
}