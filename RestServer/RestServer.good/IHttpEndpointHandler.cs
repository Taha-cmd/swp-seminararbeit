using System;
using System.Collections.Generic;
using System.Text;
using RestServerLib;

namespace RestServer.good
{
    public interface IHttpEndpointHandler
    {
        HttpResponse HandleRequest(HttpRequest request);
    }
}
