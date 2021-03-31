using RestServerLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestServer.good
{
    public class UsersEndpoint : HttpEndpointHandlerBase
    {
        protected override HttpResponse Get(HttpRequest request)
        {
            Console.WriteLine("users get handler retrieving user's data from database");
            // do database stuff here
            return new HttpResponse(200, "OK", "list of users");
        }

        protected override HttpResponse Post(HttpRequest request)
        {
            Console.WriteLine("users post handler saving new user in database");
            // do databasestuff here
            return new HttpResponse(201, "Created", "newly created user");
        }
    }
}
