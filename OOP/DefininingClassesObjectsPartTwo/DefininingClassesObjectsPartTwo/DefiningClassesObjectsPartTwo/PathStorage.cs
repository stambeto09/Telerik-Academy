using System;
using System.IO;
using System.Collections.Generic;

namespace DefiningClassesObjectsPartTwo
{
    public static class PathStorage
    {
        public static void LoadFile(List<Path>list,string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            using (reader)
            {
                string line = null;
                line = reader.ReadLine();
                while (line != null)
                {
                    line = reader.ReadLine();   
                }
            }
        }

        public static void SaveFile(List<Path> paths,string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath);
            using (writer)
            {
                for (int index = 0; index < paths.Count; index++)
                {
                    writer.WriteLine(paths[index]);
                }
            }
        }
    }
}
