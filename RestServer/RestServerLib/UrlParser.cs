using System;
using System.Collections.Generic;
using System.Text;

namespace RestServerLib
{
    public class UrlParser
    {
        public static string ParseEndpointFromUrl(string endpoint)
        {
            return endpoint.Split("/")[1];
        }

        public static string ParseToken(string endpoint, int position)
        {
            return endpoint.Split("/")[position];
        }

        
    }
}
