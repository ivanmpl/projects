using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace async_sample
{
    class Program
    {

        static void Main(string[] args)
        {
            MakeBreakfast();
            GetWebResponses();
            Console.ReadLine();
        }

        #region breakfast
        public static async void MakeBreakfast()
        {
            Task<string> coffeeTask = MakeCoffee();
            System.Console.WriteLine("doing other stuff ...");
            string coffee = await coffeeTask;
            System.Console.WriteLine(coffee);
        }

        public static async Task<string> MakeCoffee()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 20; i++)
                {
                    System.Console.WriteLine("making coffee..");
                }
            });
            return "coffee ready";
        }
        #endregion
        public static async void GetWebResponses()
        {
            Task<string> webTask = ProcessURLAsync("http://www.contoso.com/");
            string response = await webTask;
            System.Console.WriteLine(response);
        }

        public static async Task<string> ProcessURLAsync(string url)
        {
            try
            {
                //HttpResponseMessage response = await client.GetAsync(url);
                //response.EnsureSuccessStatusCode();
                //string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                using (HttpClient client = new HttpClient())
                {
                System.Console.WriteLine("before client call");
                string responseBody = await client.GetStringAsync(url);
                System.Console.WriteLine("after client call");

                System.Console.WriteLine(responseBody);
                return responseBody;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return e.Message;
            }
        }

    }
}
