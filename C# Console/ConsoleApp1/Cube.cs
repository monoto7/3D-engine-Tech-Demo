using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cube
    {
        double size;
        double x;
        double y;
        double z;
        public Cube(Double Size, double X, double Y, double Z)
        {
            size = Size;
            x = X;
            y = Y;
            z = Z;
        }
        public List<Tri> GenerateTris()
        {
            List<Tri> TriList = new List<Tri>();
            double[] Point1 = new double[3];
            double[] Point2 = new double[3];
            double[] Point3 = new double[3];
            Point1[0] = x;
            Point1[1] = y;
            Point1[2] = z;
            Point2[0] = x + size;
            Point2[1] = y;
            Point2[2] = z;
            Point3[0] = x + size;
            Point3[1] = y + size;
            Point3[2] = z;
            TriList.Add(new Tri(Point1, Point2, Point3));
            Point1[0] = x;
            Point1[1] = y;
            Point1[2] = z;
            Point2[0] = x;
            Point2[1] = y + size;
            Point2[2] = z;
            Point3[0] = x + size;
            Point3[1] = y + size;
            Point3[2] = z;
            TriList.Add(new Tri(Point1, Point2, Point3));
            Point1[0] = x;
            Point1[1] = y;
            Point1[2] = z;
            Point2[0] = x + size;
            Point2[1] = y;
            Point2[2] = z;
            Point3[0] = x + size;
            Point3[1] = y;
            Point3[2] = z + size;
            TriList.Add(new Tri(Point1, Point2, Point3));
            Point1[0] = x;
            Point1[1] = y;
            Point1[2] = z;
            Point2[0] = x;
            Point2[1] = y;
            Point2[2] = z + size;
            Point3[0] = x + size;
            Point3[1] = y;
            Point3[2] = z + size;
            TriList.Add(new Tri(Point1, Point2, Point3));
            Point1[0] = x;
            Point1[1] = y;
            Point1[2] = z;
            Point2[0] = x + size;
            Point2[1] = y;
            Point2[2] = z;
            Point3[0] = x + size;
            Point3[1] = y;
            Point3[2] = z + size;
            TriList.Add(new Tri(Point1, Point2, Point3));
            Point1[0] = x;
            Point1[1] = y;
            Point1[2] = z;
            Point2[0] = x;
            Point2[1] = y;
            Point2[2] = z;
            Point3[0] = z + size;
            Point3[1] = y + size;
            Point3[2] = z;
            TriList.Add(new Tri(Point1, Point2, Point3));
            return TriList;
        }
    }
}
