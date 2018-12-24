using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPNetwork IPnetwork = IPNetwork.Parse("100.100.100.10/19");
            Console.WriteLine("Network ID : {0}", IPnetwork.Network);
            Console.WriteLine("Custom Subnet Mask : {0}", IPnetwork.Netmask);
            Console.WriteLine("Broadcast IP : {0}", IPnetwork.Broadcast);
            Console.WriteLine("First Valid IP: {0}", IPnetwork.FirstUsable);
            Console.WriteLine("Last Valid IP : {0}", IPnetwork.LastUsable);
            Console.WriteLine("Usable : {0}", IPnetwork.Usable);
            Console.WriteLine("Total : {0}", IPnetwork.Total);
            Console.WriteLine("CIDR : {0}", IPnetwork.Cidr);
            Console.ReadKey();
        }
    }
}
