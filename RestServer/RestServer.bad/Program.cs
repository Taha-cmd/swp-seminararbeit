using System;
using System.Net;

namespace RestServer.bad
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var server = new RestServer(IPAddress.Any);
           

            server.Start();
        }
    }
}
