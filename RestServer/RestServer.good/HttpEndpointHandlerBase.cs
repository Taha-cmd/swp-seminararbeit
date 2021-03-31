using RestServerLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestServer.good
{
    public class HttpEndpointHandlerBase : IHttpEndpointHandler
    {
        public HttpResponse HandleRequest(HttpRequest request)
        {
            return request.Verb.ToUpper() switch
            {
                "GET" => Get(request),
                "PUT" => Put(request),
                "POST" => Post(request),
                "DELETE" => Delete(request),
                _ => throw new Exception($"http verb {request.Verb} not supported"),
            };
        }

        protected virtual HttpResponse Get(HttpRequest request) => DefaultResponse();
        protected virtual HttpResponse Post(HttpRequest request) => DefaultResponse();
        protected virtual HttpResponse Put(HttpRequest request) => DefaultResponse();
        protected virtual HttpResponse Delete(HttpRequest request) => DefaultResponse();

        private HttpResponse DefaultResponse()
        {
            Console.WriteLine("501 Not Implemented");
            return new HttpResponse(501, "Not Implemented");
        }
    }
}
