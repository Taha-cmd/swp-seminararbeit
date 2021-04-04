using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using RestServerLib;

namespace RestServer.bad
{
    public class RestServer
    {
        private readonly IPAddress address;
       

        public RestServer(IPAddress address)
        {
            this.address = address;
        }
        public void Start()
        {
            Console.WriteLine($"server listening on {address}:80");

            while (true)
            {
                Console.WriteLine("waiting for clients");
                var requestString = Console.ReadLine();
                Console.WriteLine("recieved request");


                var request = new HttpRequest(requestString);
                var endpoint = UrlParser.ParseEndpointFromUrl(request.Url);
                // Console.WriteLine(request.Verb +  " EndpoinT: " +  endpoint);

                /******************* Courses *******************/
                if (request.Verb == "POST"  && endpoint == "Courses")
                {
                    Console.WriteLine(" Course is created");
                   
                }
                else if (request.Verb == "GET" && endpoint == "Courses")
                {
                    Console.WriteLine("Courses will be retrieved");
                }
                else if (request.Verb == "DELETE" && endpoint == "Courses")
                {
                    Console.WriteLine(" Course deleted");
                }
                else if (request.Verb == "PUT" && endpoint == "Courses")
                {
                    Console.WriteLine("PUT request:  Course will be updated");
                }

                /******************* User *******************/
                else if (request.Verb == "POST" && endpoint == "User")
                {
                    Console.WriteLine(" User is created");
                }
                else if (request.Verb == "GET" && endpoint == "User")
                {
                    Console.WriteLine("User infos will be retrieved");
                }
                else if (request.Verb == "PUT" && endpoint == "User")
                {
                    Console.WriteLine("Infos  updated");
                }
                else if (request.Verb == "DELETE" && endpoint == "User")
                {
                    Console.WriteLine(" Course deleted");
                }
                /******************* Registration *******************/
                else if (request.Verb == "POST" && endpoint == "Register")
                {
                    Console.WriteLine("Enter Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string password = Console.ReadLine();
                    Console.WriteLine(" Successfully registred");
                    
                }
                /******************* Login **********************/
                else if (request.Verb == "POST" && endpoint == "Login")
                {
                    Console.WriteLine("Enter Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string password = Console.ReadLine();
                    Console.WriteLine(" Successfully Logged in");
                   
                }
                /******************* Professors **********************/
                else if (request.Verb == "POST" && endpoint == "Professor")
                {
                    Console.WriteLine("Enter Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter field:");
                    string FIELD = Console.ReadLine();
                    Console.WriteLine("Professor " + name + " Successfully Added to database");
                  
                }
                else if (request.Verb == "GET" && endpoint == "Professor")
                {
                    Console.WriteLine("List of Professor  will be retrieved and displayed");
                   
                }
                else if (request.Verb == "DELETE" && endpoint == "Professor")
                {
                    Console.WriteLine("Enter Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Professor " + name + " was  deleted from database");
                    //return new HttpResponse(200, "OK", "Course created");
                }
                else
                {
                    Console.WriteLine("404 NOT FOUND");
                    //return new HttpResponse(404, "NOT FOUND", "endPoint not found");
                }



                //response.Send(); in actuall code, not implemented here
            }
        }
    }
}
