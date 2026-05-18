using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    internal class Polygon
    {
        public Point2D Center { get; set; }
        public int Length { get; set; }
        public ColorRGB Color { get; set; }
        public int NumberOfEdges { get; set; }
        public List<Point2D> Vertices { get; private set; }
        public const int scaleFactor = 3;// çizim çok küçük gözüktüğü için sabit bir değerle çarpmak için bir değişken atadım


        // parametresi olmayan bir constructor tanımladım
        public Polygon()
        {
            Center = new Point2D();
            Length = 4;
            Color = new ColorRGB();
            NumberOfEdges = 5;
            Vertices = new List<Point2D>();
        }

        // parametresi olan constructor
        public Polygon(Point2D center, int length, ColorRGB color, int numberOfEdges)
        {
            Center = center;
            Length = Math.Max(1, length);
            Color = color;
            NumberOfEdges = Math.Max(3, numberOfEdges);
            Vertices = new List<Point2D>();
        }

        // köşelerin kordinatlarını hesaplamak için bir fonksiyon
        public void calculateEdgeCoordinates()
        {
            Vertices.Clear();
            double angleStep = 360.0 / NumberOfEdges;

            for (int i = 0; i < NumberOfEdges; i++)
            {
                double angle = i * angleStep;
                double radians = angle * Math.PI / 180;

                int x = (int)Math.Round((Center.coordinate_X * scaleFactor) + (Length * scaleFactor) * Math.Cos(radians));
                int y = (int)Math.Round((Center.coordinate_Y * scaleFactor) + (Length * scaleFactor) * Math.Sin(radians));

                Vertices.Add(new Point2D(x, y));
            }
        }

        //açıya göre poligonu döndürmek için gerekl matematiksel işlemlerin olduğu bir fonksiyon
        public void rotatePolygon(double angle, bool counterClockwise)
        {
            if (Vertices.Count == 0) return;

            if (counterClockwise) angle = -angle;
            double radians = angle * Math.PI / 180;

            double cos = Math.Cos(radians);
            double sin = Math.Sin(radians);

            foreach (var vertex in Vertices)
            {
                int x = vertex.coordinate_X - Center.coordinate_X;
                int y = vertex.coordinate_Y - Center.coordinate_Y;

                int newX = (int)Math.Round(x * cos - y * sin);
                int newY = (int)Math.Round(x * sin + y * cos);

                vertex.coordinate_X = newX + Center.coordinate_X;
                vertex.coordinate_Y = newY + Center.coordinate_Y;
                vertex.calculatePolarCoordinates();
            }
        }
    }
}
