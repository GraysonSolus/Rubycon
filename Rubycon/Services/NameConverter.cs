using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rubycon.Services
{
    public class NameConverter
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

        public static int GetRow(string name)
        {
            int X = int.Parse(name.Remove(0, 1));

            return X;
        }
    }
}