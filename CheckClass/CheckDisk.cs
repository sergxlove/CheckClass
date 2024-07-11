using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckClass
{
    public sealed class CheckDisk
    {
        public void GetInfoDisk()
        {
            var drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                Console.WriteLine($"Name : {item.Name}");
                Console.WriteLine($"Type : {item.DriveType}");
                Console.WriteLine($"Drive Format : {item.DriveFormat}");
                if(item.IsReady)
                {
                    Console.WriteLine($"Memory : {(item.TotalSize - item.TotalFreeSpace) / 1073741824} GB / {item.TotalFreeSpace / 1073741824} GB ");
                }
                Console.WriteLine();
            }
        }

        public string GetInfoDiskString()
        {
            StringBuilder result = new StringBuilder();
            var drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                result.Append($"Name : {item.Name} \nType : {item.DriveType} \nDrive Format : {item.DriveFormat}\n");
                if (item.IsReady) result.Append($"Memory : {(item.TotalSize - item.TotalFreeSpace) / 1073741824} GB / {item.TotalFreeSpace / 1073741824} GB \n");
            }
            result.Append('\n');
            return result.ToString();
        }
    }
}
