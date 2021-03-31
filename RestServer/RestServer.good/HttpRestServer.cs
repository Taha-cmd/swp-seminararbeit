using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using RestServerLib;

namespace RestServer.good
{
    public class HttpRestServer
    {
        private readonly IPAddress address;
        private readonly Dictionary<string, IHttpEndpointHandler> handlers = new Dictionary<string, IHttpEndpointHandler>();

        public HttpRestServer(IPAddress address)
        {
            this.address = address;
        }

        public void RegisterEndpoint(string endpoint, IHttpEndpointHandler handler)
        {
            if (handlers.ContainsKey(endpoint))
                throw new Exception($"endpoint {endpoint} allready has a handler registered");

            handlers.Add(endpoint, handler);
        }

        public void Start()
        {
            Console.WriteLine($"server listening on {address}:80");

            while(true)
            {
                Console.WriteLine("waiting for clients");
                var requestString = Console.ReadLine();
                Console.WriteLine("recieved request");


                var request = new HttpRequest(requestString);
                var endpoint = UrlParser.ParseEndpointFromUrl(request.Url);

                if(!handlers.ContainsKey(endpoint))
                {
                    // in actual code, we send 404 here
                    Console.WriteLine("404 page not found");
                    continue;
                }

                var response = handlers[endpoint].HandleRequest(request);

                //response.Send(); in actuall code, not implemented here
            }
        }


    }
}
