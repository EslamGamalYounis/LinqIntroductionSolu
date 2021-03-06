using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C://windows";
            ShowLargeFilesWithoutLinq(path);
            Console.WriteLine("***********");
            ShowLargeFilesWithLinq(path);
        }

        private static void ShowLargeFilesWithLinq(string path)
        {
            var query =
                //from file in new DirectoryInfo(path).GetFiles()
                //        orderby file.Length descending
                //        select file;
                new DirectoryInfo(path).GetFiles()
                .OrderByDescending(i => i.Length).Take(5);

            foreach(var file in query)
            {
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N}");
            }

        }

        private static void ShowLargeFilesWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files,new FileInfoComparer());
            //foreach(FileInfo file in files)
            //{
            //    Console.WriteLine($"{file.Name} : {files.Length}");
            //}

            for(int i=0;i<5;i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N}");

            }
        }

        public class FileInfoComparer : IComparer<FileInfo>
        {
            public int Compare(FileInfo x, FileInfo y)
            {
                return x.Length.CompareTo(y.Length);
            }
        }
    }
}
