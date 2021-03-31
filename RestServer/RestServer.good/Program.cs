using System;
using System.Net;
using RestServerLib;

namespace RestServer.good
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new HttpRestServer(IPAddress.Any);
            server.RegisterEndpoint("users", new UsersEndpoint());
            server.RegisterEndpoint("courses", new CoursesEndpoint());

            server.Start();
        }

    }
}
