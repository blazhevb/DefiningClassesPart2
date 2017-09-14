using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DefiningClassesPart2
{
    static class PathStorage
    {
        private static string signature = DateTime.Now.ToString("yyyyMMddHHmm");
        private const string inputPath = @"..\..\input.txt";
        private static string outputPath = @"..\..\" + signature + ".txt";
        public static void LoadPath(Path store)
        {
            using (StreamReader sr = new StreamReader(inputPath))
            {
                string line = sr.ReadLine();
                do
                {
                    int[] coordinates = line.Trim().Split(',').Select(int.Parse).ToArray();
                    store.points.Add(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                    line = sr.ReadLine();
                }
                while (line != null);
            }
        }

        public static void SavePath(Path store)
        {
            List<string> entries = new List<string>();
            foreach(Point3D point in store.points)
            {
                entries.Add(point.X + "," + point.Y + "," + point.Z);
            }
            File.WriteAllLines(outputPath, entries);
        }
        
    }
}
