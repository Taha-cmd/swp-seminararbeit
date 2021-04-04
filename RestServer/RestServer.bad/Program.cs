using System;
using System.Net;

namespace RestServer.bad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo");

            var server = new RestServer(IPAddress.Any);
           

            server.Start();
        }
    }
}
