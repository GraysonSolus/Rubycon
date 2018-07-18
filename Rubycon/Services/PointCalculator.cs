using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rubycon.Services
{
    public class PointCalculator
    {
        public static int Bx, By, Cx, Cy;

        public static ArrayList CalculateB (ArrayList pointA)
        {
            int Ax = (int)pointA[0];
            int Ay = (int)pointA[1];

            if (Ax % 2 == 0)
            {
                Bx = (Ax / 2);
                By = Ay;
            }
            else
            {
                Bx = (Ax - 1) / 2;
                By = Ay + 1;
            }

            ArrayList PointB = new ArrayList
            {
                Bx,
                By
            };

            return PointB;
        }

        public static ArrayList CalculateC (ArrayList pointA)
        {
            int Ax = (int)pointA[0];
            int Ay = (int)pointA[1];

            if (Ax % 2 == 0)
            {
                Cx = (Ax / 2);
                Cy = Ay + 1;
            }
            else
            {
                Cx = (Ax + 1) / 2;
                Cy = Ay + 1;
            }

            ArrayList PointC = new ArrayList
            {
                Cx,
                Cy
            };

            return PointC;
        }
    }
}