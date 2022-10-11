using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.Extensions.Hosting;
using ConsoleAPI.Models;
using Refit;
using Microsoft.Extensions.DependencyInjection;
using ConsoleAPI.RefitClient;

namespace ConsoleAPI
{
    class Program
    {
        private const string URI = "https://tester.consimple.pro/";

        static void Main(string[] args)
        {
            IRefitClient refitClient = RestService.For<IRefitClient>(URI); ;
            BucketModel backet = refitClient.GetBucketAsync().Result;
            backet.ShowProducts();
            backet.ShowCategories();
            
        }
    }
}

