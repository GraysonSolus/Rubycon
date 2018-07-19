using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rubycon.Services
{
    public class Calculator
    {
        public static int Bx, By, Cx, Cy;

        //calculate coordinates of the Apex - Point B using point As coordinates and the triangle's column number
        public static int[] CalculateB (int[] pointA)
        {
            int column = pointA[0];
            int Ay = pointA[1];

            // if the column number is an even number, point B's X axis value is always half the value of the column
            if (column % 2 == 0)
            {
                Bx = (column / 2);
                By = Ay;
            }
            //if column number is odd, B's X value is always equal to the column value - 1, divided by 2. Y value is always incremented by 1
            else
            {
                Bx = (column - 1) / 2;
                By = Ay + 1;
            }

            int[] PointB = new int[]
            {
                Bx,
                By
            };

            return PointB;
        }

        //calculate coordinates of the Apex - Point C using point As coordinates and the triangle's column number
        public static int[] CalculateC (int[] pointA)
        {
            int column = pointA[0];
            int Ay = pointA[1];

            // if the column number is an even number, point C's X axis value is always half the value of the column
            if (column % 2 == 0)
            {
                Cx = (column / 2);
                Cy = Ay + 1;
            }
            //if column number is odd, B's X value is always equal to the column value - 1, divided by 2. Y value is always incremented by 1
            else
            {
                Cx = (column + 1) / 2;
                Cy = Ay + 1;
            }

            int[] PointC = new int[]
            {
                Cx,
                Cy
            };

            return PointC;
        }

        //takes list of coordinates and returns the triangle's name
        public static string CalculateName (ArrayList coordinates)
        {
            //separate 1st and 2nd entry in ArrayList into PointA coordinates and PointB coordinates respectively
            ArrayList PointA = (ArrayList)coordinates[0];
            ArrayList PointB = (ArrayList)coordinates[1];
            int Ax = (int)PointA[0];
            int Ay = (int)PointA[1];
            int By = (int)PointB[1];

            //use point A's Y axis as index for triangle's row (A, B, C, ...)
            Char c = (Char)(65 + Ay);
            string triangleRow = c.ToString();
            string triangleColumn;

            //if Y axes of both point A and B (apex) are identical, triangle is even
            if (Ay == By)
            {
                triangleColumn = ((Ax + 1) * 2).ToString();
            }
            //if Y axes are different, triangle is odd
            else
            {
                triangleColumn = ((Ax * 2) + 1).ToString();
            }

            string triangle = triangleRow + triangleColumn;

            return triangle;
        }

        //same method as CalculateNames, but with adjustments for pixel values
        public static string CalculateNamePixels (ArrayList coordinates)
        {
            ArrayList PointA = (ArrayList)coordinates[0];
            ArrayList PointB = (ArrayList)coordinates[1];
            int Ax = (int)PointA[0]/10;
            int Ay = (int)PointA[1];
            int By = (int)PointB[1];

            Char c = (Char)(65 + (Ay / 10));
            string pointRow = c.ToString();
            string pointColumn;

            if (Ay == By)
            {
                pointColumn = ((Ax + 1) * 2).ToString();
            }
            else
            {
                pointColumn = ((Ax * 2) + 1).ToString();
            }

            string triangle = pointRow + pointColumn;

            return triangle;
        }

        //method for converting point coordinate values to pixels for drawing
        public static int[] ToPixels(int[] coordinates)
        {
            List<int> values = new List<int>();

            for (int i = 0; i < coordinates.Length; i++)
            {
                values.Add(coordinates[i] * 10);
            }

            int[] pixels = values.ToArray();
            return pixels;
        }

        //overload of pixels method allowing single coordinate value to be selected (e.g. X axis only)
        public static int ToPixels(int coordinate)
        {
            int pixels = coordinate * 10;

            return pixels;
        }
    }
}