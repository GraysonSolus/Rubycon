using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rubycon.Services
{
    public class StringConverter
    {
        //method to get starting point X axis value from triangle name
        public static int GetX (string name)
        {
            int X = int.Parse(name.Remove(0, 1));

            //if triangle numeric value is even X axis can always be calculated with expression:
            if (X % 2 == 0)
            {
                X = (X / 2) - 1;
            }
            //if numeric value is odd, employ different expression to get X axis
            else
            {
                X = (X - 1) / 2;
            }

            return X;
        }

        //method to get Y axis of starting point from triangle name
        public static int GetY (string name)
        {
            //ASCII math to get index of triangle alphabet character
            int Y = char.ToUpper(name[0]) - 65;

            return Y;
        }

        //method to get the row of the triangle from its name
        public static int GetRow (string name)
        {
            int X = int.Parse(name.Remove(0, 1));

            return X;
        }

        //coordinate string: 0, 1; 1, 1; 1, 2
        public static ArrayList GetCoordinateArray (string coords)
        {
            //delimiters for array breakdown
            char delim1 = ';';
            char delim2 = ',';
            //split coordinates string by semicolons into 3 string arrays
            string[] coordString = coords.Trim().Split(delim1);
            ArrayList FinalCoordinates = new ArrayList();
            //split each element in the smaller strings by commas into single letter strings
            foreach (string point in coordString)
            {
                List<int> Point = new List<int>();
                string[] pointCoords = point.Split(delim2);
                //convert every string digit into an int
                foreach (string coordinate in pointCoords)
                {
                    //package int values into arrays in pairs
                    Point.Add(int.Parse(coordinate));
                }
                //add each new point coordinate array into triangle arraylist
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