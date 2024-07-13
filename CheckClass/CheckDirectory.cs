using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckClass
{
    public sealed class CheckDirectory
    {
        public CheckDirectory() 
        {
            Path = "no";
        }

        public CheckDirectory(string path)
        {
            Path = path;
        }

        public void GetInfoDirectory()
        {
            if (Directory.Exists(Path))
            {
                DirectoryInfo dir = new DirectoryInfo(Path);
                Console.WriteLine($"Name : {dir.Name}");
                Console.WriteLine($"Last creation time : {dir.CreationTime}");
                Console.WriteLine($"Last access time : {dir.LastAccessTime}");
                Console.WriteLine($"Last change time : {dir.LastWriteTime}");
                Console.WriteLine();
                var listDirectories = dir.GetDirectories();
                var listFiles = dir.GetFiles();
                Console.WriteLine("Content directory :");
                if(listDirectories.Length == 0 && listFiles.Length == 0)
                {
                    Console.WriteLine("No found");
                }
                else
                {
                    foreach (var file in listDirectories)
                    {
                        Console.WriteLine(file.Name);
                    }
                    foreach (var file in listFiles)
                    {
                        Console.WriteLine(file.Name);
                    }
                }
            }
            else
            {
                Console.WriteLine("No found directory");
            }
        }

        public string GetInfoDirectoryString()
        {
            StringBuilder result = new StringBuilder();
            if (Directory.Exists(Path))
            {
                DirectoryInfo dir = new DirectoryInfo(Path);
                result.Append($"Name : {dir.Name} \nLast creation time : {dir.CreationTime} \nLast access time : {dir.LastAccessTime} \nLast change time : {dir.LastWriteTime}");
                var listDirectories = dir.GetDirectories();
                var listFiles = dir.GetFiles();
                result.Append("Content directory :");
                if (listDirectories.Length == 0 && listFiles.Length == 0)
                {
                    result.Append("No found");
                }
                else
                {
                    foreach(var file in listDirectories)
                    {
                        result.Append(file.Name);
                    }
                    foreach (var file in listFiles)
                    {
                        result.Append(file.Name);
                    }
                }
            }
            else
            {
                result.Append("No found directory");
            }
            return result.ToString();
        }
        public string Path { get; set; }
    }
}
