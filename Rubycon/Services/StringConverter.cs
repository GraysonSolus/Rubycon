using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rubycon.Services
{
    public class StringConverter
    {
        public static int GetX (string name)
        {
            int X = int.Parse(name.Remove(0, 1));

            if (X % 2 == 0)
            {
                X = (X / 2) - 1;
            }
            else
            {
                X = (X - 1) / 2;
            }

            return X;
        }

        public static int GetY (string name)
        {
            int Y = char.ToUpper(name[0]) - 65;

            return Y;
        }

        public static int GetRow (string name)
        {
            int X = int.Parse(name.Remove(0, 1));

            return X;
        }

        //coordinate string: 0, 1; 1, 1; 1, 2
        public static ArrayList GetCoordinateArray (string coords)
        {
            char delim1 = ';';
            char delim2 = ',';
            string[] coordString = coords.Trim().Split(delim1);
            ArrayList FinalCoordinates = new ArrayList();
            ArrayList coordinates = new ArrayList
            {
                coordString
            };

            foreach (string point in coordString)
            {
                List<int> Point = new List<int>();
                string[] pointCoords = point.Split(delim2);
                foreach (string coordinate in pointCoords)
                {
                    Point.Add(int.Parse(coordinate));
                }
                FinalCoordinates.Add(Point);
            }

            return FinalCoordinates;
        }

        public static ArrayList GetCoordinateArrayPixels (string coords)
        {
            char delim1 = ';';
            char delim2 = ',';
            string[] coordString = coords.Trim().Split(delim1);
            ArrayList FinalCoordinates = new ArrayList();
            ArrayList coordinates = new ArrayList
            {
                coordString
            };

            foreach (string point in coordString)
            {
                ArrayList Point = new ArrayList();
                string[] pointCoords = point.Split(delim2);
                foreach (string coordinate in pointCoords)
                {
                    Point.Add(int.Parse(coordinate));
                }
                FinalCoordinates.Add(Point);
            }

            return FinalCoordinates;
        }
    }
}