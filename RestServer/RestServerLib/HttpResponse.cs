using System;
using System.Collections.Generic;
using System.Text;

namespace RestServerLib
{
    public class HttpResponse
    {
        public int Status { get; }
        public string StatusMessage { get; }
        public string Payload { get; }

        public HttpResponse(int status, string statusMsg, string payload = null)
        {
            Status = status;
            StatusMessage = statusMsg;
            Payload = payload;
        }
    }
}
