﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;

namespace hellowrod
{
    class Program
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder()
               .ConfigureWebHost(webHostBuilder => webHostBuilder
                   .UseKestrel()
                   .Configure(app => app.Run(
                        context => context.Response.WriteAsync("Hello World."))))
               .Build()
               .Run();

        }
    }
}
