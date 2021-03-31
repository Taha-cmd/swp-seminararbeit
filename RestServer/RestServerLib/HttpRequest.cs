using System;

namespace RestServerLib
{
    public class HttpRequest
    {
        public string Verb { get; }
        public string Url { get; }
        public string Payload { get; }

        public HttpRequest(string verb, string url, string payload = null)
        {
            Verb = verb;
            Url = url;
            Payload = payload;
        }

        public HttpRequest(string requestString)
        {
            var tokens = requestString.Split(" ");
            Verb = tokens[0];
            Url = tokens[1];
        }

    }
}
