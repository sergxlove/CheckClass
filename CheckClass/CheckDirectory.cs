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

            }
            else
            {
                Console.WriteLine("No found directory");
            }
        }

        public string Path { get; set; }
    }
}
