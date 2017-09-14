using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point3D point1 = new Point3D(2, 4, 5);
            //Point3D point2 = new Point3D(1, 5, 6);
            //double result = DistanceCalculator.CalculateDistance(point1, point2);
            //Path path = new Path();
            //PathStorage.LoadPath(path);
            //PathStorage.SavePath(path);

            //Console.WriteLine();
            //Matrix<int> mat1 = new Matrix<int>(3, 3);
            // mat1[0, 0] = 1;
            // mat1[0, 1] = 3;
            // mat1[0, 2] = 3;
            // mat1[1, 0] = 5;
            // mat1[1, 1] = 7;
            // mat1[1, 2] = 7;
            // mat1[2, 0] = 9;
            // mat1[2, 1] = 11;
            // mat1[2, 2] = 11;
            // Matrix<int> mat2 = new Matrix<int>(2, 2);
            // mat2[0, 0] = 2;
            // mat2[0, 1] = 4;
            // mat2[1, 0] = 6;
            // mat2[1, 1] = 8;
            //Console.WriteLine((mat1 * mat2).ToString());

            //Console.WriteLine(mat1);
            SampleClass sp = new SampleClass();
            sp.DisplayVersion(typeof(SampleClass));
            Console.ReadLine();
        }

 
    }
}
