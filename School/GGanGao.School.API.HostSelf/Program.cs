using Microsoft.Owin.Hosting;
using System;

namespace GanGao.School.API.HostSelf
{
    class Program
    {
        private const string HOST_ADDRESS = "http://+:8082";
        static void Main(string[] args)
        {
            WebApp.Start<GanGao.School.API.StartupAPI>(HOST_ADDRESS);
            Console.WriteLine("Web API started!IP:{0}", HOST_ADDRESS);
            Console.ReadLine();
        }
    }
}
