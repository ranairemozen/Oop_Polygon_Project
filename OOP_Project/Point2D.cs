using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class Point2D
    {
        // x ve y koordinatlarını, açıyı ve yarıçapı tanımladım
        public int coordinate_X { get; set; }
        public int coordinate_Y { get; set; }
        public double radius { get; set; }
        public double alpha { get; set; }


        // parametresi olmayan bir constructor tanımladım
        public Point2D()
        {
            coordinate_X = coordinate_Y = 0;
            calculatePolarCoordinates();
        }

        // x ve y değerleri atayabilmem için parametresi olan bir constructor tanımladım
        public Point2D(int x, int y)
        {
            coordinate_X = x;
            coordinate_Y = y;
            calculatePolarCoordinates();
        }

        // random x ve y değerleriyle bir constructor tanımladım
        public Point2D(Random random)
        {
            coordinate_X = random.Next(0, 3);
            coordinate_Y = random.Next(0, 3);
            calculatePolarCoordinates();
        }

        // koordinatları yazdırmak için bir fonksiyon
        public void printCoordinates()
        {
            Console.WriteLine("Cartesian Coordinates: (" + coordinate_X + "," + coordinate_Y + ")");
        }

        // polar koordinatları hesaplamak için bir fonksiyon
        public void calculatePolarCoordinates()
        {
            radius = Math.Sqrt(coordinate_X * coordinate_X + coordinate_Y * coordinate_Y);
            alpha = Math.Atan2(coordinate_Y, coordinate_X) * 180 / Math.PI;
            if (alpha < 0)
                alpha += 360;
        }

        // polar kordinatları kullanarak kartezyen kordinatları hesapladım
        public void calculateCartesianCoordinates()
        {
            double radians = alpha * Math.PI / 180;
            coordinate_X = (int)Math.Round(radius * Math.Cos(radians));
            coordinate_Y = (int)Math.Round(radius * Math.Sin(radians));
        }

        // polar koordinatları yazdırmak için bir fonksiyon
        public void printPolarCoordinates()
        {
            Console.WriteLine("Polar Coordinates: (r = " + radius.ToString("F2") + ", θ = " + alpha.ToString("F2") + "°)");
        }
    }
}
