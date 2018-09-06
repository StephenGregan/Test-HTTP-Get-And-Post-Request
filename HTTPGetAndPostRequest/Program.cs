using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HTTPGetAndPostRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            GetRequest("http://google.com");
            PostRequest("https://ptsv2.com/");

            Console.ReadKey();
        }

        async static void GetRequest(string url)
        {
            // The using statement provides a Dispose method which releases the Objects resources
            // when it is no longer needed.
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync("http://google.com"))
                {
                    using (HttpContent content = response.Content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        Console.WriteLine(myContent);
                    }
                }
            }
        }

        async static void PostRequest(string url)
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("query1", "Stephen"),
                new KeyValuePair<string, string>("query2", "Ian")
            };

            HttpContent q = new FormUrlEncodedContent(queries);

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(url, q))
                {
                    using (HttpContent content = response.Content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;

                        Console.WriteLine(myContent);
                    }
                }
            }
        }
    }
}
