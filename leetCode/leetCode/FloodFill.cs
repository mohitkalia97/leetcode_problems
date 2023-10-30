using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class FloodFill
    {
        public static int[][] doFloodFill(int[][] image, int sr, int sc, int color)
        {

            for (int i = 0; i < image.Length; i++)
            {
                for (int j = 0; j <= ((sc+sr) - i); j++)
                {
                    image[i][j] = color;

                }
            }

            //for (int i = 0; i < image.Length; i++)
            //{
            //    string s = "";

            //    for (int j = 0;  j < (image[i].Length) ; j++)
            //    {
            //        s = s + image[i][j].ToString();

            //    }

            //    Console.WriteLine(s);   
            //}
            return image;
        }
    }
}
