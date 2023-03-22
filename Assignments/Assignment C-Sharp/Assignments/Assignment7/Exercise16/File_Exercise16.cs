using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assignment_C_Sharp.Assignments.Assignment7.Exercise17
{
    class File_Exercise16
    {
        private int GetCountFormat(string format, FileInfo[] files)
        {
            if (format.Contains(".") == false) format = "." + format;

            return files.ToList().Where(x => x.FullName.Contains(format)).Count();
        }

        private void GetAllFilesExtensions(FileInfo[] files)
        {
            Dictionary<string, int> extensions = new Dictionary<string, int>();

            foreach(var file in files.ToList())
            {
                string extn = file.Extension;
                if (extensions.ContainsKey(extn)) extensions[extn]++;
                else extensions.Add(extn, 1);
            }

            foreach(var ext in extensions)
            {
                Console.WriteLine($"{ext.Key} extension - {ext.Value} files.");
            }

        }

        private static FileInfo[] GetLargestFiles(FileInfo[] files, int countsReceive = 1)
        {
            files = files.OrderBy(x => -x.Length).ToArray();

            FileInfo[] answer = new FileInfo[countsReceive];
            Array.Copy(files, 0, answer, 0, countsReceive);
            return answer;
        }


        public File_Exercise16()
        {
            string path = @"..\..\Assignments\Assignment7\Exercise16\Files";
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();

            //Number of Files
            Console.WriteLine("Return the number of text files in the directory (*.txt).");
            Console.WriteLine(".txt - " + GetCountFormat(".txt", files));

            // Return the number of files per extension type
            Console.WriteLine("\nThe number of files per extension type:");
            GetAllFilesExtensions(files);

            // Return the top 5 largest files, along with their file size (use anonymous types).
            Console.WriteLine("\nReturn the top 5 largest files, along with their file size (use anonymous types).");
            GetLargestFiles(files, 5).ToList().ForEach(x => Console.WriteLine(x.FullName));

            //Return the file with maximum length.
            Console.WriteLine("\nReturn the file with maximum length.");
            GetLargestFiles(files, 1).ToList().ForEach(x => Console.WriteLine(x.FullName));
        }

    }
}
