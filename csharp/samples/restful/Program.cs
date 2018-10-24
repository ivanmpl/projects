﻿using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace WebAPIClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        private static async Task ProcessRepositories()
        {
            var serializer = new DataContractJsonSerializer(typeof(List<repo>));
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                             new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var repositories = serializer.ReadObject(await streamTask) as List<repo>;

            foreach (var repo in repositories)
                Console.WriteLine(repo.name);



            // var stringTask = client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");
            // var msg = await stringTask;
            // Console.Write(msg);
        }

        static void Main(string[] args)
        {
            ProcessRepositories().Wait();
        }
    }
}