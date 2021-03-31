using RestServerLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestServer.good
{
    public class CoursesEndpoint : HttpEndpointHandlerBase
    {
        protected override HttpResponse Get(HttpRequest request)
        {
            Console.WriteLine("courses get handler retrieving courses from database");
            // do database stuff here
            return new HttpResponse(200, "OK", "list of courses");
        }
    }
}
