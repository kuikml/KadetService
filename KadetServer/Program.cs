using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using KadetServiceProject;

namespace KadetServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(KadryService));
            host.Open();

            Console.WriteLine("Server nasłuchuje .........");

            Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć działanie serwera");
            Console.ReadKey();
        }
    }
}
