using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using BingSearchApp.Models;

namespace BingSearchApp.Services
{
    class BingWebSearch
    {
        // property for access key
        private static string accessKey { get; set; }
        // bing search rest api endpoint
        const string uriBase = "https://api.cognitive.microsoft.com/bing/v7.0/search";
        // set accesskey with class construction
        public BingWebSearch()
        {
            accessKey = GetAPIKey();
        }

        // Get single API key from config file
        string GetAPIKey()
        {
            // Read each line of the file into a string array
            string[] lines = System.IO.File.ReadAllLines(@"init_config.json");

            //foreach (string line in lines)
            //{
            // Use a tab to indent each line of the file.
            //Console.WriteLine(line);
            //}

            // ... do what i say not what i do...
            string line = lines[1];
            string[] values = line.Split(':');
            string api_key = values[1].Substring(2, values[1].Length - 3);
            return api_key;
        }

        /// <summary>
        /// Makes a request to the Bing Web Search API and returns data as a SearchResult.
        /// </summary>
        public SearchResult BingTextSearch(string searchQuery)
        {

            // Construct the search request URI.
            var uriQuery = uriBase + "?q=" + Uri.EscapeDataString(searchQuery);

            // Perform request and get a response.
            WebRequest request = HttpWebRequest.Create(uriQuery);
            request.Headers["Ocp-Apim-Subscription-Key"] = accessKey;
            HttpWebResponse response = (HttpWebResponse)request.GetResponseAsync().Result;
            string json = new StreamReader(response.GetResponseStream()).ReadToEnd();

            // Create a result object.
            var searchResult = new SearchResult()
            {
                jsonResult = json,
                relevantHeaders = new Dictionary<String, String>()
            };

            // Extract Bing HTTP headers.
            foreach (String header in response.Headers)
            {
                if (header.StartsWith("BingAPIs-") || header.StartsWith("X-MSEdge-"))
                    searchResult.relevantHeaders[header] = response.Headers[header];
            }
            return searchResult;
        }

    }

}