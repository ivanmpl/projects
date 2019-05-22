using System;
using System.Collections.Generic;

namespace BingSearchApp.Models
{
    // struct to hold search results and headers.
    struct SearchResult
    {
        public String jsonResult;
        public Dictionary<String, String> relevantHeaders;
    }

}