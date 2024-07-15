using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace CheckClass
{
    public sealed class CheckNetwork
    {
        public void GetInfoNetworking()
        {
            var adapters = NetworkInterface.GetAllNetworkInterfaces();
            Console.WriteLine($"Total devices : {adapters.Length}");
            foreach (var item in adapters)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine();
                Console.WriteLine($"Id devices : {item.Id}");
                Console.WriteLine($"Name devices : {item.Name}");
                Console.WriteLine($"Name description : {item.Description}");
                Console.WriteLine($"Name interface : {item.NetworkInterfaceType}");
                Console.WriteLine($"Physical address : {item.GetPhysicalAddress()}");
                Console.WriteLine($"Status : {item.OperationalStatus}");
                Console.WriteLine($"Speed : {item.Speed}");
                IPInterfaceStatistics stats = item.GetIPStatistics();
                Console.WriteLine($"Getting : {stats.BytesReceived}");
                Console.WriteLine($"Senting : {stats.BytesSent}");
                Console.WriteLine();
            }
        }
    }
}
